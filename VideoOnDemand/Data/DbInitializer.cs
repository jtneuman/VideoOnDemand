using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoOnDemand.Entities;

namespace VideoOnDemand.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            var description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante tincidunt tempus. Donec vitae sapien ut libero venenatis faucibus. Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Sed consequat, leo eget bibendum sodales, augue velit cursus nunc,";

            // If you need to recreate the database then uncomment these two code lines.
            // All data will be deleted with the database and cannot be recovered.
            // context.Database.EnsureDeleted();
            // context.Database.EnsureCreated();

            // Look for any courses to check if the DB has been seeded.
            if (context.Instructors.Any())
            {
                return;
            }

            var instructors = new List<Instructor>
            {
                new Instructor{ Name = "John Doe",
                    Description = description.Substring(20, 50),
                    Thumbnail = "/images/Ice-Age-Scrat-icon.png"
                },
                new Instructor{Name = "Jane Doe",
                    Description = description.Substring(30, 40),
                    Thumbnail = "/images/Ice-Age-Scrat-icon.png"
                }
            };
            context.Instructors.AddRange(instructors);
            context.SaveChanges();
        }
    }
}
