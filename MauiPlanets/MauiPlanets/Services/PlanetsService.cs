using MauiPlanets.Models;


namespace MauiPlanets.Services
{
    internal class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. In English, it is named after the ancient Roman god Mercurius (Mercury), god of commerce and communication, and the messenger of the gods. ",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.mos.cms.futurecdn.net/w3kqDGBSTqVnNTpd5pajWm.jpg",
                    "https://ychef.files.bbci.co.uk/624x351/p0hq20x5.png"
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description = "Of all the planets, Venus is the one most similar to Earth. In fact, Venus is often called Earth's “sister” planet. As similar as it is in some ways, however, it is also very different in others. ",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2023/05/688-venus-1200-jpg.webp?w=1024",
                    "https://planetfacts.org/wp-content/uploads/2023/12/planet_venus.jpg",
                    "https://www.brproud.com/wp-content/uploads/sites/80/2023/06/AdobeStock_58627825-1.jpeg?w=900"
                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "The Earth is the only planet known where life exists. Almost 1.5 million species of animals and plants have been discovered so far, and many more have yet to be found. While other planets may have small amounts of ice or steam, the Earth is 2/3 water. Earth has perfect conditions for a breathable atmosphere. ",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://images.photowall.com/products/71305/planet-earth-at-night.jpg?h=699&q=85",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "No planet has sparked the imaginations of humans as much " +
                "as Mars. It may be the reddish color of Mars, or the fact that it can " +
                "often be easily seen in the night sky, that has caused people to wonder " +
                "about this close neighbor of ours. Tales of “Martians” invading Earth " +
                "have been around for well over fifty years. But is it likely that any " +
                "kind of life really does exist on Mars? ",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://news.mit.edu/sites/default/files/images/202409/MIT-MissMars-01-press.jpg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },

            new()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the " +
                "largest in the Solar System. It is a gas giant with a mass more " +
                "than 2.5 times that of all the other planets in the Solar System " +
                "combined, and slightly less than one-thousandth the mass of the " +
                "Sun. Its diameter is eleven times that of Earth, and a tenth " +
                "that of the Sun. ",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://nypost.com/wp-content/uploads/sites/2/2021/12/astrology-jupiter-sign-1-copy.jpg?quality=75&strip=all"
                }
            },

            new()
            {
                Name = "Saturn",
                Subtitle = "The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and " +
                            "the second-largest in the Solar System, after " +
                            "Jupiter. It is a gas giant with an average " +
                            "radius of about nine and a half times that " +
                            "of Earth. It has only one-eighth the average " +
                            "density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                    "https://assets.newatlas.com/dims4/default/1a83d9c/2147483647/strip/true/crop/2000x1125+0+104/resize/1200x675!/quality/90/?url=http%3A%2F%2Fnewatlas-brightspot.s3.amazonaws.com%2F60%2Ffd%2F40cab325436baa5cc37b50deaef5%2Fdepositphotos-287851412-l.jpg"
                }
            },

            new()
            {
                Name = "Uranus",
                Subtitle = "The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. " +
                            "It is named after Greek sky deity Uranus (Caelus), who in " +
                            "Greek mythology is the father of Cronus (Saturn), a grandfather " +
                            "of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus " +
                            "has the third-largest planetary radius and fourth-largest " +
                            "planetary mass in the Solar System.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                    "https://planetfacts.org/wp-content/uploads/2023/12/planet_uranus.jpg"
                }
            },

            new()
            {
                Name = "Neptune",
                Subtitle = "The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth planet from the Sun and " +
                            "the farthest known planet in the Solar System. It is the " +
                            "fourth-largest planet in the Solar System by diameter, the " +
                            "third-most-massive planet, and the densest giant planet. " +
                            "It is 17 times the mass of Earth, and slightly more " +
                            "massive than its near-twin Uranus.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://planetfacts.org/wp-content/uploads/2023/12/planet_neptune.jpg"
                }
            },




            new()
            {
                Name = "Pluto",
                Subtitle = "Pluto was once a planet of our solar system.",
                HeroImage = "pluto.png",
                Description = "Pluto was once our solar system's ninth planet, but has " +
                           "been reclassified as a dwarf planet. It's located in the Kuiper Belt.",
                AccentColorStart = Color.FromArgb("#63510d"),
                AccentColorEnd = Color.FromArgb("FF0000"),
                Images= new()
                {
                    "https://i.natgeofe.com/n/b103fff5-6a84-4d19-b65e-5856998816c3/PIA19952_2x3.jpg"
                }
            },

            new()
            {
                Name = "Ceres",
                Subtitle = "Ceres is named after the Roman goddess of corn and harvest.",
                HeroImage = "ceres.png",
                Description = "Dwarf planet Ceres is the largest object in the asteroid belt between " +
                           "Mars and Jupiter. It was explored by NASA's Dawn spacecraft.",
                AccentColorStart = Color.FromArgb("#021311"),
                AccentColorEnd = Color.FromArgb("#61011d"),
                Images= new()
                {
                    "https://stsci-opo.org/STScI-01EVSTFG11Z011TWQSTZ4ASBBW.png",
                    "https://media.azpm.org/master/image/2018/9/20/hero/ceres_eDM0xNE.jpg"
                }
            },

            new()
            {
                Name = "Haumea",
                Subtitle = "Haumea is named after the Hawaiian goddess of fertility.",
                HeroImage = "haumea.png",
                Description = "Dwarf planet Haumea was orignally designated 2003 EL61 " +
                           "(and nicknamed Santa by one discovery team). Haumea is " +
                           "located in the Kuiper Belt, a doughnut-shaped region of " +
                           "icy bodies beyond orbit of Neptune.",
                AccentColorStart = Color.FromArgb("#d6a86b"),
                AccentColorEnd = Color.FromArgb("#d6be9f"),
                Images= new()
                {
                    "https://cdn.mos.cms.futurecdn.net/h5P8ZW8QJAscrMQ9r6euoc.jpg",
                    "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/fdedbd0d-a698-4b53-af5d-26c4046fa564/dbrcnsy-ebeff5ce-4619-4cc0-9666-0ceb2a4cb065.png/v1/fill/w_1024,h_696,q_80,strp/haumea_haumea_by_astra_planetshine_dbrcnsy-fullview.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9Njk2IiwicGF0aCI6IlwvZlwvZmRlZGJkMGQtYTY5OC00YjUzLWFmNWQtMjZjNDA0NmZhNTY0XC9kYnJjbnN5LWViZWZmNWNlLTQ2MTktNGNjMC05NjY2LTBjZWIyYTRjYjA2NS5wbmciLCJ3aWR0aCI6Ijw9MTAyNCJ9XV0sImF1ZCI6WyJ1cm46c2VydmljZTppbWFnZS5vcGVyYXRpb25zIl19.6-UJixRZG1E8soVMf0QfWPNWt8G8WaDcxOgPm1PMS2Y"
                }
            },

            new()
            {
                Name = "Makemake",
                Subtitle = "Makemake is named after the Rapanui god of fertility.",
                HeroImage = "makemake.png",
                Description = "Dwarf planet Makemake holds an important place in the " +
                           "history of the solar system studies because it was one " +
                           "of the objects - along with Eris - whose discovery prompted " +
                           "the International Astronomical Union to reconsider the " +
                           "definition of planet, and create the new group of " +
                           "dwarf planets",
                AccentColorStart = Color.FromArgb("#ba775d"),
                AccentColorEnd = Color.FromArgb("#cf8e70"),
                Images= new()
                {
                    "https://astronz.nz/cdn/shop/articles/makemake.png?v=1682129134",
                    "https://cdn.eso.org/images/screen/eso1246a.jpg"
                }


            },

            new()
            {
                Name = "Eris",
                Subtitle = "Eris is the largest dwarf planet.",
                HeroImage = "eris.png",
                Description = "Eris is one of the dwarf planets in our solar system. " +
                           "It's about the same size as Pluto, but it's three times " +
                           "farther from the Sun.",
                AccentColorStart = Color.FromArgb("#949de5"),
                AccentColorEnd = Color.FromArgb("#4b4b4b"),
                Images= new()
                {
                    "https://cdn.mos.cms.futurecdn.net/ufTfK2rbpQXZBjt2ZPsm57-1200-80.jpg",
                    "https://www.renderhub.com/3dstudio/dwarf-planet-eris/dwarf-planet-eris-01.jpg"
                }
            }
        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}