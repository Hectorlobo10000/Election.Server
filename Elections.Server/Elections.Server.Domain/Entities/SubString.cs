namespace Elections.Server.Domain.Entities
{
    public class SubString
    {
        public static string GetStringFixed(string character)
        {
            var firstLerrle = character.Substring(0, 1);
            var continuationCharacter = character.Substring(1, character.Length - 1);
            return string.Concat(firstLerrle.ToUpper(), continuationCharacter);
        }
    }
}