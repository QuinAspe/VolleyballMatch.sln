using System.Text.Json;
using VolleyballMatch.Core.Entities;

namespace VolleyballMatch.Web.Services
{
    public class MatchService
    {
        private readonly string filePath;

        public MatchService(string filePath)
        {
            this.filePath = filePath;
        }

        public async Task<List<Match>> GetMatchesAsync()
        {
            if (!File.Exists(filePath))
            {
                return new List<Match>();
            }

            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                return await JsonSerializer.DeserializeAsync<List<Match>>(stream) ?? new List<Match>();
            }
        }

        public async Task AddMatchAsync(Match newMatch)
        {
            List<Match> matches = await GetMatchesAsync();
            matches.Add(newMatch);

            using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                await JsonSerializer.SerializeAsync(stream, matches);
            }
        }
    }
}
