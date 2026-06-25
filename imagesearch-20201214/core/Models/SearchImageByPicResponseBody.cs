// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class SearchImageByPicResponseBody : TeaModel {
        /// <summary>
        /// <para>The descriptions of all returned products.</para>
        /// </summary>
        [NameInMap("Auctions")]
        [Validation(Required=false)]
        public List<SearchImageByPicResponseBodyAuctions> Auctions { get; set; }
        public class SearchImageByPicResponseBodyAuctions : TeaModel {
            /// <summary>
            /// <para>The image category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8888888</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public int? CategoryId { get; set; }

            /// <summary>
            /// <para>The user-defined content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zidingyi</para>
            /// </summary>
            [NameInMap("CustomContent")]
            [Validation(Required=false)]
            public string CustomContent { get; set; }

            /// <summary>
            /// <para>The integer type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("IntAttr")]
            [Validation(Required=false)]
            public int? IntAttr { get; set; }

            /// <summary>
            /// <para>The integer type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("IntAttr2")]
            [Validation(Required=false)]
            public int? IntAttr2 { get; set; }

            /// <summary>
            /// <para>The integer type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("IntAttr3")]
            [Validation(Required=false)]
            public int? IntAttr3 { get; set; }

            /// <summary>
            /// <para>The integer type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("IntAttr4")]
            [Validation(Required=false)]
            public int? IntAttr4 { get; set; }

            /// <summary>
            /// <para>The image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2092061_1.jpg</para>
            /// </summary>
            [NameInMap("PicName")]
            [Validation(Required=false)]
            public string PicName { get; set; }

            /// <summary>
            /// <para>The product ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2092061_1</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The image similarity score. Valid values: 0 to 1.</para>
            /// <remarks>
            /// <para>You must upgrade to V3.1.1 to use this feature.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public float? Score { get; set; }

            /// <summary>
            /// <para>The system scoring information.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This field is deprecated. Use Score instead.</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>SortExprValues is a semicolon-separated tuple. The first value indicates the relevance score of the image. A higher value indicates higher relevance to the query image. The scoring varies depending on the algorithm model.</description></item>
            /// <item><description>When the category is 0 to 2, the value range of SortExprValues is 0 to 7.33136443711219e+24.</description></item>
            /// <item><description>For other category values, the value range of SortExprValues is 0 to 5.37633353624177e+24. This score reaches its maximum when two images are identical.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5.37633353624177e+24;0</para>
            /// </summary>
            [NameInMap("SortExprValues")]
            [Validation(Required=false)]
            public string SortExprValues { get; set; }

            /// <summary>
            /// <para>The string type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("StrAttr")]
            [Validation(Required=false)]
            public string StrAttr { get; set; }

            /// <summary>
            /// <para>The string type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("StrAttr2")]
            [Validation(Required=false)]
            public string StrAttr2 { get; set; }

            /// <summary>
            /// <para>The string type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("StrAttr3")]
            [Validation(Required=false)]
            public string StrAttr3 { get; set; }

            /// <summary>
            /// <para>The string type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("StrAttr4")]
            [Validation(Required=false)]
            public string StrAttr4 { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description>0: successful.</description></item>
        /// <item><description>Non-zero: failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The overview of the search results.</para>
        /// </summary>
        [NameInMap("Head")]
        [Validation(Required=false)]
        public SearchImageByPicResponseBodyHead Head { get; set; }
        public class SearchImageByPicResponseBodyHead : TeaModel {
            /// <summary>
            /// <para>The number of results returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DocsFound")]
            [Validation(Required=false)]
            public int? DocsFound { get; set; }

            /// <summary>
            /// <para>The number of results matched in the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("DocsReturn")]
            [Validation(Required=false)]
            public int? DocsReturn { get; set; }

            /// <summary>
            /// <para>The search duration, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>95</para>
            /// </summary>
            [NameInMap("SearchTime")]
            [Validation(Required=false)]
            public int? SearchTime { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The information such as category prediction and subject identification results.</para>
        /// </summary>
        [NameInMap("PicInfo")]
        [Validation(Required=false)]
        public SearchImageByPicResponseBodyPicInfo PicInfo { get; set; }
        public class SearchImageByPicResponseBodyPicInfo : TeaModel {
            /// <summary>
            /// <para>The information about all categories supported by the system.</para>
            /// </summary>
            [NameInMap("AllCategories")]
            [Validation(Required=false)]
            public List<SearchImageByPicResponseBodyPicInfoAllCategories> AllCategories { get; set; }
            public class SearchImageByPicResponseBodyPicInfoAllCategories : TeaModel {
                /// <summary>
                /// <para>The category ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>88888888</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// <para>The category name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>other</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The category prediction result. If the category is specified in the request, the value specified in the request is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88888888</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public int? CategoryId { get; set; }

            /// <summary>
            /// <para>The collection of subject identification results.</para>
            /// <remarks>
            /// <para>You must upgrade to V3.1.1 to use this feature.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("MultiRegion")]
            [Validation(Required=false)]
            public List<SearchImageByPicResponseBodyPicInfoMultiRegion> MultiRegion { get; set; }
            public class SearchImageByPicResponseBodyPicInfoMultiRegion : TeaModel {
                /// <summary>
                /// <para>The subject identification result. The subject region of the image, in the format of x1,x2,y1,y2, where x1,y1 is the upper-left point and x2,y2 is the lower-right point. If the subject region is specified in the request, the value specified in the request is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>280,486,232,351</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

            /// <summary>
            /// <para>The subject identification result. The subject region of the image, in the format of x1,x2,y1,y2, where x1,y1 is the upper-left point and x2,y2 is the lower-right point. If the subject region is specified in the request, the value specified in the request is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>280,486,232,351</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B3137727-7D6E-488C-BA21-0E034C38A879</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
