namespace GenericsChallenge2.Classes
{
    abstract class Superhero
    {
        readonly string Alias;
        readonly string SecretIdentity;
        readonly int Age;
        readonly Alignment Alignment;

        protected Superhero(string alias, string secretIdentity, int age, Alignment alignment)
        {
            Alias = alias;
            SecretIdentity = secretIdentity;
            Age = age;
            Alignment = alignment;
        }
    }
}
