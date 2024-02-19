namespace VideoHouseGoldy79.Data.Models
{
    using VideoHouseGoldy79.Data.Common.Models;

    public class Setting : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }
}
