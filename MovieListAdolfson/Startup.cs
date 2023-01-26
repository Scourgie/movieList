using Microsoft.EntityFrameworkCore;
using MovieListAdolfson.Models;



namespace MovieListAdolfson
{
    

    public class Startup
    {
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
       

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MovieContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MovieContext")));
        }

        

    }
}
