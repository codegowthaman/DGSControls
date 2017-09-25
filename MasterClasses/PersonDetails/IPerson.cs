using System;
namespace DGSCONTROLS.MasterClasses.PersonDetails
{
   public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; set; }
        byte Age { get; set; }
        string Gender { get; set; }
        DateTime DateOfBirth { get; set; }
        long AdharNumber { get; set; }
    }
}
