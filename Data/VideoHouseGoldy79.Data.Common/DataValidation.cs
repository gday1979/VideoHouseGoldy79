namespace VideoHouseGoldy79.Data.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class DataValidation
    {
       public const int NameMaxLength = 30;
       public const int FullNameMaxLength = 60;

       public static class Movie
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 50;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 800;

            public const int ModelCategoryMaxLength = 1;
        }

       public static class Actor
        {
            public const int ActorFirstNameMinLength = 2;
            public const int ActorFirstNameMaxLength = 50;

            public const int ActorLastNameMinLength = 2;
            public const int ActorLastNameMaxLength = 50;
        }

       public static class Actress
        {
            public const int ActressFirstNameMinLength = 2;
            public const int ActressFirstNameMaxLength = 50;

            public const int ActressLastNameMinLength = 2;
            public const int ActressLastNameMaxLength = 50;
        }

       public static class Author
        {
            public const int AuthorFirstNameMinLenght = 2;
            public const int AuthorFirstNameMaxLenght = 50;

            public const int AuthorLastNameMinLenght = 2;
            public const int AuthorLastNameMaxLenght = 50;
        }

       public static class Director
        {
            public const int DirectorFirstNameMinLength = 2;
            public const int DirectorFirstNameMaxLength = 50;

            public const int DirectorLastNameMinLength = 2;
            public const int DirectorLastNameMaxLength = 50;
        }
    }
}
