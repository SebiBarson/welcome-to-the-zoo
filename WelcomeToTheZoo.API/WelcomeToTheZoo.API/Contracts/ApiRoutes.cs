namespace WelcomeToTheZoo.API.Contracts
{
    public static class ApiRoutes
    {
        public const string Root = "api";

        public static class Animals
        {
            public const string Create = $"{Root}/animal";

            public const string GetAll = $"{Root}/animals";

            public const string GetById = $"{Root}/animals/{{id}}";
        }

        public static class Zoos
        {
            public const string Create = $"{Root}/zoo";

            public const string GetAll = $"{Root}/zoos";

            public const string GetById = $"{Root}/zoos/{{id}}";
        }
    }
}
