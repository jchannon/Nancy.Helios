namespace Nancy.Helios
{
    using global::Owin;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
        }
    }
}