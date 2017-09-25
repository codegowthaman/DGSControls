using System.Collections;

namespace DGSCONTROLS.MasterClasses.PersonDetails
{
    public interface  IEmployee :IPerson, IAddress  
    {

        IList Qualifications { get; set; }
        int YearofExperience { get; set; }
        string Designation { get; set; }
        string DateOfJoining { get; set; }
        IList ExtraQualifications { get; set; }
    }
}
