using MunchyAPI.Models;

namespace MunchyAPI.Data
{
    public static class MunchStore
    {
        public static List<MunchDTO> MunchList =  new List<MunchDTO>
            {
                new MunchDTO{Id=1, Name="Itallic"},
                new MunchDTO{Id=2, Name="Indian"}
            };
    }
}
