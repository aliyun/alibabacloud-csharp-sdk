// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListCategoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response payload.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCategoryResponseBodyData Data { get; set; }
        public class ListCategoryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of categories.</para>
            /// </summary>
            [NameInMap("CategoryList")]
            [Validation(Required=false)]
            public List<ListCategoryResponseBodyDataCategoryList> CategoryList { get; set; }
            public class ListCategoryResponseBodyDataCategoryList : TeaModel {
                /// <summary>
                /// <para>The category ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cate_cdd11b1b79a74e8bbd675c356a91ee3xxxxxxxx</para>
                /// </summary>
                [NameInMap("CategoryId")]
                [Validation(Required=false)]
                public string CategoryId { get; set; }

                /// <summary>
                /// <para>The category name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>类目1</para>
                /// </summary>
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                /// <summary>
                /// <para>The category type. The only valid value is:</para>
                /// <list type="bullet">
                /// <item><description><c>UNSTRUCTURED</c>: A standard category.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UNSTRUCTURED</para>
                /// </summary>
                [NameInMap("CategoryType")]
                [Validation(Required=false)]
                public string CategoryType { get; set; }

                /// <summary>
                /// <para>Indicates whether the category is the default. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: The category is the default.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: The category is not the default.</para>
                /// </description></item>
                /// </list>
                /// <para>You cannot delete the default category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <para>The parent category ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cate_addd11b1b79a74e8bbd675c356a91ee3xxxxxxxx</para>
                /// </summary>
                [NameInMap("ParentCategoryId")]
                [Validation(Required=false)]
                public string ParentCategoryId { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether more results are available for retrieval. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: More results are available.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: This is the last page of results.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }

            /// <summary>
            /// <para>The maximum number of results to return per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token used to retrieve the next page of results. This parameter is omitted when no more results are available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AAAAALHWGpGoYCcYMxiFfmlhvh7Z4G8jiXR6IjHYd+M9WQVJ</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of matching categories.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace id is null or invalid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17204B98-xxxx-4F9A-8464-2446A84821CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The request succeeded.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
