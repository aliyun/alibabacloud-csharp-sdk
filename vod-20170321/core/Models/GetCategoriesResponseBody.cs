// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetCategoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the category.</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public GetCategoriesResponseBodyCategory Category { get; set; }
        public class GetCategoriesResponseBodyCategory : TeaModel {
            /// <summary>
            /// <para>The ID of the category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            /// <summary>
            /// <para>The name of the category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>film</para>
            /// </summary>
            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            /// <summary>
            /// <para>The level of the category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: level 1 category</description></item>
            /// <item><description><b>1</b>: level 2 category</description></item>
            /// <item><description><b>2</b>: level 3 category</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public long? Level { get; set; }

            /// <summary>
            /// <para>The ID of the parent category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100012****</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

            /// <summary>
            /// <para>The type of the category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>default</b>: audio, video, and image files</description></item>
            /// <item><description><b>material</b>: short video materials</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the subcategory.</para>
        /// </summary>
        [NameInMap("SubCategories")]
        [Validation(Required=false)]
        public GetCategoriesResponseBodySubCategories SubCategories { get; set; }
        public class GetCategoriesResponseBodySubCategories : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public List<GetCategoriesResponseBodySubCategoriesCategory> Category { get; set; }
            public class GetCategoriesResponseBodySubCategoriesCategory : TeaModel {
                /// <summary>
                /// <para>The ID of the category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                /// <summary>
                /// <para>The name of the category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>film</para>
                /// </summary>
                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                /// <summary>
                /// <para>The level of the category. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: level 1 category</description></item>
                /// <item><description><b>1</b>: level 2 category</description></item>
                /// <item><description><b>2</b>: level 3 category</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public long? Level { get; set; }

                /// <summary>
                /// <para>The ID of the parent category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10020****</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                /// <summary>
                /// <para>The total number of subcategories.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SubTotal")]
                [Validation(Required=false)]
                public long? SubTotal { get; set; }

                /// <summary>
                /// <para>The type of the subcategory. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>default</b>: audio, video, and image files</description></item>
                /// <item><description><b>material</b>: short video materials</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of subcategories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3795</para>
        /// </summary>
        [NameInMap("SubTotal")]
        [Validation(Required=false)]
        public long? SubTotal { get; set; }

    }

}
