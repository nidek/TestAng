using MVCAngular.Models.League;
using MVCAngular.Models.Team;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MVCAngular.Models.Start
{
    public class StartVmBuilder
    {
        public StartVm BuildStartVm()
        {
            var startVm = new StartVm
            {
                Teams = GetSerializedTeams(),
                Leagues = GetSerializedLeagues(),

            };
            
            return startVm;
        }

        public string GetSerializedTeams()
        {
            var teams = new[]
            {                 
                new TeamVm {name = "Liverpool FC", league ="Premier League", place ="7th"},
                new TeamVm {name ="HV71", league ="SHL", place ="4rd"},
                new TeamVm {name ="IFK Norrköping", league ="Allsvenskan", place ="(not started)"},
            };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(teams, settings);
        }

        public string GetSerializedLeagues()
        {
            var leagues = new[]
            {                 
                new LeagueVm {name = "Premier League", country="England"},
                new LeagueVm {name ="SHL", country ="Sweden"},
                new LeagueVm {name ="Allsvenskan", country ="Sweden"},
            };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(leagues, settings);
        }
    }
}