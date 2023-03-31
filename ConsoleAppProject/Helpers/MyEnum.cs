using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace ConsoleAppProject.Helpers
{
    /// <summary>
    /// This is an example of how annotations can ber added
    /// to an Enumeration.  Access to thee name and the description
    /// is through EnumHelpers class or ExtensionMethods
    /// by Derek & Andrei
    /// </summary>
    public enum MyEnum
    {
        [Display(Name = "First Value")]
        [System.ComponentModel.Description("This is the First Value")]
        FirstValue = 2,
        
        [System.ComponentModel.Description("This is the Second Value")]
        [Display(Name = "Second Value")]
        SecondValue = 4,
        
        [System.ComponentModel.Description("This is the Third Value")]
        [Display(Name = "Third Value")]
        ThirdValue = 6
    }
}
