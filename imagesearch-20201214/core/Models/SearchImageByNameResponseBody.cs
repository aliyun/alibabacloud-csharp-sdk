// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class SearchImageByNameResponseBody : TeaModel {
        /// <summary>
        /// <para>The product descriptions returned.</para>
        /// </summary>
        [NameInMap("Auctions")]
        [Validation(Required=false)]
        public List<SearchImageByNameResponseBodyAuctions> Auctions { get; set; }
        public class SearchImageByNameResponseBodyAuctions : TeaModel {
            /// <summary>
            /// <para>The category of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
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
            /// <para>The attribute, which is an integer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("IntAttr")]
            [Validation(Required=false)]
            public int? IntAttr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("IntAttr2")]
            [Validation(Required=false)]
            public int? IntAttr2 { get; set; }

            [NameInMap("IntAttr3")]
            [Validation(Required=false)]
            public int? IntAttr3 { get; set; }

            [NameInMap("IntAttr4")]
            [Validation(Required=false)]
            public int? IntAttr4 { get; set; }

            /// <summary>
            /// <para>The name of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2092061_1.jpg</para>
            /// </summary>
            [NameInMap("PicName")]
            [Validation(Required=false)]
            public string PicName { get; set; }

            /// <summary>
            /// <para>The ID of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2092061_1</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The similarity score of the returned image. Valid values: 0 to 1.</para>
            /// <remarks>
            /// <para> To use this feature, you must upgrade the SDK to version 3.1.1.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public float? Score { get; set; }

            /// <summary>
            /// <para>The score information about the image.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is not supported. We recommend that you use the Score parameter.</description></item>
            /// <item><description>The SortExprValues parameter indicates a 2-tuple in which values are separated by a semicolon (;). The first value indicates the correlation score of the returned image. A greater value indicates a higher correlation with the sample image. Different algorithms are used.</description></item>
            /// <item><description>If the value of CategoryId is within the value range from 0 to 2, the value range of SortExprValues is from 0 to 7.33136443711219e+24.</description></item>
            /// <item><description>If the value of CategoryId is not within the value range from 0 to 2, the value range of SortExprValues is from 0 to 5.37633353624177e+24. If the returned image is identical with the sample image, the highest correlation score is generated.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5.37633353624177e+24;0</para>
            /// </summary>
            [NameInMap("SortExprValues")]
            [Validation(Required=false)]
            public string SortExprValues { get; set; }

            /// <summary>
            /// <para>The attribute, which is a string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ss</para>
            /// </summary>
            [NameInMap("StrAttr")]
            [Validation(Required=false)]
            public string StrAttr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("StrAttr2")]
            [Validation(Required=false)]
            public string StrAttr2 { get; set; }

            [NameInMap("StrAttr3")]
            [Validation(Required=false)]
            public string StrAttr3 { get; set; }

            [NameInMap("StrAttr4")]
            [Validation(Required=false)]
            public string StrAttr4 { get; set; }

        }

        /// <summary>
        /// <para>The error code returned.</para>
        /// <list type="bullet">
        /// <item><description>A value of 0 indicates that the operation is successful.</description></item>
        /// <item><description>Values other than 0 indicate errors.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The summary of the search result.</para>
        /// </summary>
        [NameInMap("Head")]
        [Validation(Required=false)]
        public SearchImageByNameResponseBodyHead Head { get; set; }
        public class SearchImageByNameResponseBodyHead : TeaModel {
            /// <summary>
            /// <para>The number of images returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DocsFound")]
            [Validation(Required=false)]
            public int? DocsFound { get; set; }

            /// <summary>
            /// <para>The number of images that match the search conditions on the Image Search instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("DocsReturn")]
            [Validation(Required=false)]
            public int? DocsReturn { get; set; }

            /// <summary>
            /// <para>The time it takes to complete the search process. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>95</para>
            /// </summary>
            [NameInMap("SearchTime")]
            [Validation(Required=false)]
            public int? SearchTime { get; set; }

        }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The information such as the system-selected category and result of subject recognition.</para>
        /// </summary>
        [NameInMap("PicInfo")]
        [Validation(Required=false)]
        public SearchImageByNameResponseBodyPicInfo PicInfo { get; set; }
        public class SearchImageByNameResponseBodyPicInfo : TeaModel {
            /// <summary>
            /// <para>The categories that are supported by the system.</para>
            /// </summary>
            [NameInMap("AllCategories")]
            [Validation(Required=false)]
            public List<SearchImageByNameResponseBodyPicInfoAllCategories> AllCategories { get; set; }
            public class SearchImageByNameResponseBodyPicInfoAllCategories : TeaModel {
                /// <summary>
                /// <para>The ID of the category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>other</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// <para>The name of the category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>88888888</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The category selected by the system.</para>
            /// <para>If a category is specified in the request, the specified category prevails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public int? CategoryId { get; set; }

            /// <summary>
            /// <para>The recognized subjects.</para>
            /// </summary>
            [NameInMap("MultiRegion")]
            [Validation(Required=false)]
            public List<SearchImageByNameResponseBodyPicInfoMultiRegion> MultiRegion { get; set; }
            public class SearchImageByNameResponseBodyPicInfoMultiRegion : TeaModel {
                /// <summary>
                /// <para>The result of subject recognition.</para>
                /// <para>The subject area of the image, in the format of x1,x2,y1,y2. Specifically, x1 and y1 specify the upper-left pixel, and x2 and y2 specify the lower-right pixel. If a subject area is specified in the request, the specified subject area prevails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>280,486,232,351</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

            /// <summary>
            /// <para>The result of subject recognition.</para>
            /// <para>The subject area of the image, in the format of x1,x2,y1,y2. Specifically, x1 and y1 specify the upper-left pixel, and x2 and y2 specify the lower-right pixel. If a subject area is specified in the request, the specified subject area prevails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>280,486,232,351</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36C43E96-8F68-44AA-B1AF-B1F7AB94A6C1</para>
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
