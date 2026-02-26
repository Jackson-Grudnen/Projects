using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Web;

namespace XFlowsive
{
    public partial class Form1 : Form
    {
        private Process currentProcess;
        string season_;
        Song song;
        string lastSongUrl;
        public Form1()
        {
            InitializeComponent();
        }
        private class Song
        {
            public string Url { get; set; }
            public TimeSpan Duration { get; set; }
            public string Artist { get; set; }
            public string Album { get; set; }
            public string Season { get; set; }
            public string Genre { get; set; }
        }
        private Song GetRandomSong(string season_)
        {
            var lines = File.ReadAllLines("songList.txt")
                            .Where(l => !string.IsNullOrWhiteSpace(l) && l.Contains(season_))
                            .ToList();

            var rand = new Random();
            var line = lines[rand.Next(lines.Count)];

            var parts = line.Split(',');

            string url = parts[0].Trim();
            string time = parts[1].Trim();
            var artist = parts[2].Trim();
            var album = parts[3].Trim();
            var season = parts[4].Trim();
            var genre = parts[5].Trim();

            TimeSpan duration = TimeSpan.Parse("00:" + time); // converts 2:00 → 00:02:00
            lastSongUrl = url;

            return new Song
            {
                Url = url,
                Duration = duration,
                Artist = artist,
                Album = album,
                Season = season,
                Genre = genre
            };
        }
        private Song GetRandomSong(string artist, string album, string season, string genre)
        {

            var lines = File.ReadAllLines("songList.txt")
                    .Where(l =>!string.IsNullOrWhiteSpace(l) && (string.IsNullOrWhiteSpace(lastSongUrl) || !l.Contains(lastSongUrl)))
                    .ToList();

            // Try progressively fewer matches
            var randNum = new Random();
            int reqMatch = 4;
            if (randNum.Next(5) == 1)
            {
                reqMatch--;
            }
            for (int requiredMatches = reqMatch; requiredMatches >= 0; requiredMatches--)
            {
                var filtered = lines.Where(l =>
                {
                    int matchCount = 0;

                    if (!string.IsNullOrWhiteSpace(artist) && l.Contains(artist))
                        matchCount++;

                    if (!string.IsNullOrWhiteSpace(album) && l.Contains(album))
                        matchCount++;

                    if (!string.IsNullOrWhiteSpace(season) && l.Contains(season))
                        matchCount++;

                    if (!string.IsNullOrWhiteSpace(genre) && l.Contains(genre))
                        matchCount++;

                    return matchCount == requiredMatches;
                }).ToList();

                if (filtered.Any())
                {
                    var rand = new Random();
                    var line = filtered[rand.Next(filtered.Count)];
                    return ParseSong(line);
                }
            }

            throw new Exception("No songs found.");
        }
        private Song ParseSong(string line)
        {
            var parts = line.Split(',');

            string url = parts[0].Trim();
            string time = parts[1].Trim();
            var artist_ = parts[2].Trim();
            var album_ = parts[3].Trim();
            var season_ = parts[4].Trim();
            var genre_ = parts[5].Trim();

            TimeSpan duration = TimeSpan.Parse("00:" + time);
            lastSongUrl = url;

            return new Song
            {
                Url = url,
                Duration = duration,
                Artist = artist_,
                Album = album_,
                Season = season_,
                Genre = genre_
            };
        }
        private async void PlayRandomSong()
        {
            if (song == null)
            {
                song = GetRandomSong(season_);
            }
            else
            {
                song = GetRandomSong(song.Artist, song.Album, song.Season, song.Genre);
            }
            // Kill previous if running
            KillEdgeAppWindows();

            currentProcess = Process.Start(new ProcessStartInfo
            {
                FileName = "msedge.exe",
                Arguments = $"--app={song.Url}",
                UseShellExecute = true
            });

            await Task.Delay(song.Duration + TimeSpan.FromSeconds(10));

            PlayRandomSong(); // recursively play next
        }
        private void KillEdgeAppWindows()
        {
            var processes = Process.GetProcessesByName("msedge");

            foreach (var proc in processes)
            {
                try
                {
                    if (!proc.HasExited)
                        proc.Kill();
                }
                catch { }
            }
        }

        private async void Form1_Load_1(object sender, EventArgs e)
        {
            int month = DateTime.Now.Month;

            if (month >= 3 && month <= 5)
            {
                season_ = "$Spring";
            }
            else if (month >= 6 && month <= 8)
            {
                season_ = "$Summer";
            }
            else if (month >= 9 && month <= 11)
            {
                season_ = "$Fall";
            }
            else
            {
                season_ = "$Winter";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            PlayRandomSong();
        }
    }
}
