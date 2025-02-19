namespace TTRPG_Manager.Domain
{
    

    public class TTRPG
    {
        public struct Setting
        {
            uint id;
            string Name;
            string Description;
        }

        public string Name { get; set; }
        public Setting Genre { get; set; }
    }
}
