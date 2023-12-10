namespace GamerProject
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1995 && gamer.FirstName == "ENGİN" && gamer.IdentityNumber == 12345678901)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}