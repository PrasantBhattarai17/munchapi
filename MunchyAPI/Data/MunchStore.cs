using MunchyAPI.Models;

namespace MunchyAPI.Data
{
    public static class MunchStore
    {
        public static List<MunchDTO> MunchList =  new List<MunchDTO>
            {
                new MunchDTO{Id=1, Name="McDonalds",Price=240,Rating=4},
                new MunchDTO{Id=2, Name="KFC",Price=430,Rating=5}
            };
    }
}
