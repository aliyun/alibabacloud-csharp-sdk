// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListCustomPersonsResponseBody : TeaModel {
        /// <summary>
        /// <para>The array of the figure libraries.</para>
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
                /// <para>The description of the figure library.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CategoryDescription-****</para>
                /// </summary>
                [NameInMap("CategoryDescription")]
                [Validation(Required=false)]
                public string CategoryDescription { get; set; }

                /// <summary>
                /// <para>The ID of the figure library.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CategoryId-****</para>
                /// </summary>
                [NameInMap("CategoryId")]
                [Validation(Required=false)]
                public string CategoryId { get; set; }

                /// <summary>
                /// <para>The name of the figure library.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CategoryName-****</para>
                /// </summary>
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                /// <summary>
                /// <para>The array of the figures.</para>
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
                        /// <para>The array of the faces.</para>
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
                                /// <para>The ID of the face.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>15****</para>
                                /// </summary>
                                [NameInMap("FaceId")]
                                [Validation(Required=false)]
                                public string FaceId { get; set; }

                                /// <summary>
                                /// <para>The URL of the facial image that was registered for the figure.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para><a href="http://example-****.jpeg">http://example-****.jpeg</a></para>
                                /// </summary>
                                [NameInMap("ImageUrl")]
                                [Validation(Required=false)]
                                public string ImageUrl { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The description of the figure.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PersonDescription-****</para>
                        /// </summary>
                        [NameInMap("PersonDescription")]
                        [Validation(Required=false)]
                        public string PersonDescription { get; set; }

                        /// <summary>
                        /// <para>The ID of the figure.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PersonId-****</para>
                        /// </summary>
                        [NameInMap("PersonId")]
                        [Validation(Required=false)]
                        public string PersonId { get; set; }

                        /// <summary>
                        /// <para>The name of the figure.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PersonName-****</para>
                        /// </summary>
                        [NameInMap("PersonName")]
                        [Validation(Required=false)]
                        public string PersonName { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FD4DED6B-0C26-5A8B-A6BE-4FA542AE4D57</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
