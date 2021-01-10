// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListCustomPersonsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Categories")]
        [Validation(Required=false)]
        public ListCustomPersonsResponseBodyCategories Categories { get; set; }
        public class ListCustomPersonsResponseBodyCategories : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public List<ListCustomPersonsResponseBodyCategoriesCategory> Category { get; set; }
            public class ListCustomPersonsResponseBodyCategoriesCategory : TeaModel {
                [NameInMap("Person")]
                [Validation(Required=false)]
                public List<ListCustomPersonsResponseBodyCategoriesCategoryPerson> Person { get; set; }
                public class ListCustomPersonsResponseBodyCategoriesCategoryPerson : TeaModel {
                    [NameInMap("PersonName")]
                    [Validation(Required=false)]
                    public string PersonName { get; set; }

                    [NameInMap("PersonDescription")]
                    [Validation(Required=false)]
                    public string PersonDescription { get; set; }

                    [NameInMap("Faces")]
                    [Validation(Required=false)]
                    public ListCustomPersonsResponseBodyCategoriesCategoryPersonFaces Faces { get; set; }
                    public class ListCustomPersonsResponseBodyCategoriesCategoryPersonFaces : TeaModel {
                        [NameInMap("Face")]
                        [Validation(Required=false)]
                        public List<ListCustomPersonsResponseBodyCategoriesCategoryPersonFacesFace> Face { get; set; }
                        public class ListCustomPersonsResponseBodyCategoriesCategoryPersonFacesFace : TeaModel {
                            public string ImageUrl { get; set; }
                            public string FaceId { get; set; }
                        }
                    };

                    [NameInMap("PersonId")]
                    [Validation(Required=false)]
                    public string PersonId { get; set; }

                }

            }
        };

    }

}
