namespace Nancy.Helios
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => "Nancy on Helios Baby!";
        }
    }
}