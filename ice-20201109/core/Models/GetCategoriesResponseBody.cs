// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
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
            /// <para>The category ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>46</para>
            /// </summary>
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            /// <summary>
            /// <para>The category name.</para>
            /// </summary>
            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            /// <summary>
            /// <para>The level of the category. A value of <b>0</b> indicates a level-1 category, a value of <b>1</b> indicates a level-2 category, and a value of <b>2</b> indicates a level-3 category.</para>
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
            /// <para>-1</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

            /// <summary>
            /// <para>The type of the category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>default</b>: audio, video, and image files. This is the default value.</description></item>
            /// <item><description><b>material</b>: short video materials.</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The subcategories in the category.</para>
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
                /// <para>The category ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>129</para>
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                /// <summary>
                /// <para>The category name.</para>
                /// <list type="bullet">
                /// <item><description>The value can be up to 64 bytes in length.</description></item>
                /// <item><description>The value is encoded in UTF-8.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                /// <summary>
                /// <para>The level of the category. A value of <b>0</b> indicates a level-1 category, a value of <b>1</b> indicates a level-2 category, and a value of <b>2</b> indicates a level-3 category.</para>
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
                /// <para>46</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                /// <summary>
                /// <para>The total number of subcategories.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("SubTotal")]
                [Validation(Required=false)]
                public long? SubTotal { get; set; }

                /// <summary>
                /// <para>The type of the category. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>default</b>: audio, video, and image files. This is the default value.</description></item>
                /// <item><description><b>material</b>: short video materials.</description></item>
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
        /// <para>100</para>
        /// </summary>
        [NameInMap("SubTotal")]
        [Validation(Required=false)]
        public long? SubTotal { get; set; }

    }

}
