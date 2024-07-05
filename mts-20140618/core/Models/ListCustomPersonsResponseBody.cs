// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListCustomPersonsResponseBody : TeaModel {
        /// <summary>
        /// The array of the figure libraries.
        /// </summary>
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public ListCustomPersonsResponseBodyCategories Categories { get; set; }
        public class ListCustomPersonsResponseBodyCategories : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public List<ListCustomPersonsResponseBodyCategoriesCategory> Category { get; set; }
            public class ListCustomPersonsResponseBodyCategoriesCategory : TeaModel {
                /// <summary>
                /// The description of the figure library.
                /// </summary>
                [NameInMap("CategoryDescription")]
                [Validation(Required=false)]
                public string CategoryDescription { get; set; }

                /// <summary>
                /// The ID of the figure library.
                /// </summary>
                [NameInMap("CategoryId")]
                [Validation(Required=false)]
                public string CategoryId { get; set; }

                /// <summary>
                /// The name of the figure library.
                /// </summary>
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                /// <summary>
                /// The array of the figures.
                /// </summary>
                [NameInMap("Persons")]
                [Validation(Required=false)]
                public ListCustomPersonsResponseBodyCategoriesCategoryPersons Persons { get; set; }
                public class ListCustomPersonsResponseBodyCategoriesCategoryPersons : TeaModel {
                    [NameInMap("Person")]
                    [Validation(Required=false)]
                    public List<ListCustomPersonsResponseBodyCategoriesCategoryPersonsPerson> Person { get; set; }
                    public class ListCustomPersonsResponseBodyCategoriesCategoryPersonsPerson : TeaModel {
                        /// <summary>
                        /// The array of the faces.
                        /// </summary>
                        [NameInMap("Faces")]
                        [Validation(Required=false)]
                        public ListCustomPersonsResponseBodyCategoriesCategoryPersonsPersonFaces Faces { get; set; }
                        public class ListCustomPersonsResponseBodyCategoriesCategoryPersonsPersonFaces : TeaModel {
                            [NameInMap("Face")]
                            [Validation(Required=false)]
                            public List<ListCustomPersonsResponseBodyCategoriesCategoryPersonsPersonFacesFace> Face { get; set; }
                            public class ListCustomPersonsResponseBodyCategoriesCategoryPersonsPersonFacesFace : TeaModel {
                                /// <summary>
                                /// The ID of the face.
                                /// </summary>
                                [NameInMap("FaceId")]
                                [Validation(Required=false)]
                                public string FaceId { get; set; }

                                /// <summary>
                                /// The URL of the facial image that was registered for the figure.
                                /// </summary>
                                [NameInMap("ImageUrl")]
                                [Validation(Required=false)]
                                public string ImageUrl { get; set; }

                            }

                        }

                        /// <summary>
                        /// The description of the figure.
                        /// </summary>
                        [NameInMap("PersonDescription")]
                        [Validation(Required=false)]
                        public string PersonDescription { get; set; }

                        /// <summary>
                        /// The ID of the figure.
                        /// </summary>
                        [NameInMap("PersonId")]
                        [Validation(Required=false)]
                        public string PersonId { get; set; }

                        /// <summary>
                        /// The name of the figure.
                        /// </summary>
                        [NameInMap("PersonName")]
                        [Validation(Required=false)]
                        public string PersonName { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
