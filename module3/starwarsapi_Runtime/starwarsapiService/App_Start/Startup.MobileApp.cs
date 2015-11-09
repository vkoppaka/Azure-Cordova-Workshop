using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;
using Microsoft.Azure.Mobile.Server.Config;
using starwarsapiService.DataObjects;
using starwarsapiService.Models;
using Owin;

namespace starwarsapiService
{
    public partial class Startup
    {
        public static void ConfigureMobileApp(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            //For more information on Web API tracing, see http://go.microsoft.com/fwlink/?LinkId=620686 
            config.EnableSystemDiagnosticsTracing();

            new MobileAppConfiguration()
                .UseDefaultConfiguration()
                .ApplyTo(config);

            // Use Entity Framework Code First to create database tables based on your DbContext
            Database.SetInitializer(new starwarsapiInitializer());

            // To prevent Entity Framework from modifying your database schema, use a null database initializer
            // Database.SetInitializer(null);

            app.UseMobileAppAuthentication(config);
            app.UseWebApi(config);
        }
    }

    public class starwarsapiInitializer : CreateDatabaseIfNotExists<starwarsapiContext>
    {
        protected override void Seed(starwarsapiContext context)
        {
            List<MovieItem> movieItems = new List<MovieItem>
            {
                new MovieItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "A New Hope",
                    ReleaseDate = new DateTime(1977,05,25),
                    ImageUrl = "https://starwarsimages.blob.core.windows.net/images/episode4.jpeg",
                    SortOrder = 1,
                    Episode = "IV"
                },
                new MovieItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "The Empire Strikes Back",
                    ReleaseDate = new DateTime(1980,05,17),
                    ImageUrl = "https://starwarsimages.blob.core.windows.net/images/episode5.jpeg",
                    SortOrder = 2,
                    Episode = "V"
                },
                new MovieItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Return of the Jedi",
                    ReleaseDate = new DateTime(1983,05,25),
                    ImageUrl = "https://starwarsimages.blob.core.windows.net/images/episode6.jpeg",
                    SortOrder = 3,
                    Episode = "VI"
                },
                new MovieItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "The Phantom Menance",
                    ReleaseDate = new DateTime(1999,05,19),
                    ImageUrl = "https://starwarsimages.blob.core.windows.net/images/episode1.jpeg",
                    SortOrder = 4,
                    Episode = "I"
                },
                new MovieItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Attack of the Clones",
                    ReleaseDate = new DateTime(2002,05,16),
                    ImageUrl = "https://starwarsimages.blob.core.windows.net/images/episode2.jpeg",
                    SortOrder = 5,
                    Episode = "II"
                },
                new MovieItem
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = "Revenge of the Sith",
                    ReleaseDate = new DateTime(2005,05,19),
                    ImageUrl = "https://starwarsimages.blob.core.windows.net/images/episode3.jpeg",
                    SortOrder = 6,
                    Episode = "III"
                }
            };

            foreach (MovieItem movieItem in movieItems)
            {
                context.Set<MovieItem>().Add(movieItem);
            }

            base.Seed(context);
        }
    }
}

