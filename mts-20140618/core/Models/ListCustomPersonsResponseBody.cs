// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListCustomPersonsResponseBody : TeaModel {
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public ListCustomPersonsResponseBodyCategories Categories { get; set; }
        public class ListCustomPersonsResponseBodyCategories : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public List<ListCustomPersonsResponseBodyCategoriesCategory> Category { get; set; }
            public class ListCustomPersonsResponseBodyCategoriesCategory : TeaModel {
                public string CategoryDescription { get; set; }
                public string CategoryId { get; set; }
                public string CategoryName { get; set; }
                public ListCustomPersonsResponseBodyCategoriesCategoryPersons Persons { get; set; }
                public class ListCustomPersonsResponseBodyCategoriesCategoryPersons : TeaModel {
                    [NameInMap("Person")]
                    [Validation(Required=false)]
                    public List<ListCustomPersonsResponseBodyCategoriesCategoryPersonsPerson> Person { get; set; }
                    public class ListCustomPersonsResponseBodyCategoriesCategoryPersonsPerson : TeaModel {
                        [NameInMap("Faces")]
                        [Validation(Required=false)]
                        public ListCustomPersonsResponseBodyCategoriesCategoryPersonsPersonFaces Faces { get; set; }
                        public class ListCustomPersonsResponseBodyCategoriesCategoryPersonsPersonFaces : TeaModel {
                            [NameInMap("Face")]
                            [Validation(Required=false)]
                            public List<ListCustomPersonsResponseBodyCategoriesCategoryPersonsPersonFacesFace> Face { get; set; }
                            public class ListCustomPersonsResponseBodyCategoriesCategoryPersonsPersonFacesFace : TeaModel {
                                public string FaceId { get; set; }
                                public string ImageUrl { get; set; }
                            }
                        };

                        [NameInMap("PersonDescription")]
                        [Validation(Required=false)]
                        public string PersonDescription { get; set; }

                        [NameInMap("PersonId")]
                        [Validation(Required=false)]
                        public string PersonId { get; set; }

                        [NameInMap("PersonName")]
                        [Validation(Required=false)]
                        public string PersonName { get; set; }

                    }

                }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
