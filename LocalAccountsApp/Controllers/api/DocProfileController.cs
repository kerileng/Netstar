using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Profiler;
using Profiler.Models;

namespace LocalAccountsApp.Controllers.api
{
    
    public class DocProfileController : ApiController
    {
        [Authorize(Roles ="admin")]
        public void AddProfile(DoctorsProfile profile)
        {
            using(var context = new NETSTAREntities())
            {
                context.DoctorsProfiles.Add(profile);
                context.SaveChanges();
            }
        }

        public List<Profile> GetAllProfiles()
        {
            List<Profiler.Models.Profile> profiles = new List<Profile>();
            using(var context = new NETSTAREntities())
            {
                profiles = context.DoctorsProfiles.Select(x => new Profile() { Discipline = x.Discipline, DoctorID = x.DoctorID, Firstname = x.Firstname, HPCSANo = x.HPCSANo, IDNo = x.IDNo, Lastname = x.Lastname, Province = x.Province, Region = x.Region, Title = x.Title }).ToList();
            }

            return profiles;
        }

        public DoctorsProfile GetByIDNo(int idNumber)
        {
            DoctorsProfile profile = new DoctorsProfile();
            using(var context = new NETSTAREntities())
            {
                profile = context.DoctorsProfiles.Where(x => x.IDNo == idNumber).FirstOrDefault();
            }
            return profile;
        }

        public DoctorsProfile GetByHPCSANoo(int hpcsan0)
        {
            DoctorsProfile profile = new DoctorsProfile();
            using (var context = new NETSTAREntities())
            {
                profile = context.DoctorsProfiles.Where(x => x.HPCSANo == hpcsan0).FirstOrDefault();
            }
            return profile;
        }

        public DoctorsProfile GetByTitle(string title)
        {
            DoctorsProfile profile = new DoctorsProfile();
            using (var context = new NETSTAREntities())
            {
                profile = context.DoctorsProfiles.Where(x => x.Title.Equals(title)).FirstOrDefault();
            }
            return profile;
        }

        public DoctorsProfile GetByFirstName(string firstName)
        {
            DoctorsProfile profile = new DoctorsProfile();
            using (var context = new NETSTAREntities())
            {
                profile = context.DoctorsProfiles.Where(x => x.Firstname.Equals(firstName)).FirstOrDefault();
            }
            return profile;
        }

        public DoctorsProfile GetByLastName(string lastName)
        {
            DoctorsProfile profile = new DoctorsProfile();
            using (var context = new NETSTAREntities())
            {
                profile = context.DoctorsProfiles.Where(x => x.Lastname == lastName).FirstOrDefault();
            }
            return profile;
        }

        public DoctorsProfile GetByDiscipline(string discipline)
        {
            DoctorsProfile profile = new DoctorsProfile();
            using (var context = new NETSTAREntities())
            {
                profile = context.DoctorsProfiles.Where(x => x.Discipline.Equals(discipline)).FirstOrDefault();
            }
            return profile;
        }

        public DoctorsProfile GetByProvince(string province)
        {
            DoctorsProfile profile = new DoctorsProfile();
            using (var context = new NETSTAREntities())
            {
                profile = context.DoctorsProfiles.Where(x => x.Province.Equals(province)).FirstOrDefault();
            }
            return profile;
        }

        public DoctorsProfile GetByRegion(string region)
        {
            DoctorsProfile profile = new DoctorsProfile();
            using (var context = new NETSTAREntities())
            {
                profile = context.DoctorsProfiles.Where(x => x.Region == region).FirstOrDefault();
            }
            return profile;
        }

    }
}
