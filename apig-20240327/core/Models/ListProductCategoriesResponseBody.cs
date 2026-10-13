// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListProductCategoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListProductCategoriesResponseBodyData Data { get; set; }
        public class ListProductCategoriesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of product categories. Each element in the list is named category and contains the information about a product category.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public List<ListProductCategoriesResponseBodyDataContent> Content { get; set; }
            public class ListProductCategoriesResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The product category ID. You can use this ID as the categoryId path parameter for GetProductCategory, UpdateProductCategory, and DeleteProductCategory. You can also use it as an element in the categories parameter, which is a set of category IDs, for SetProductCategories and CreateProduct.</para>
                /// 
                /// <b>Example:</b>
                /// <para>category-xxxxxxxx</para>
                /// </summary>
                [NameInMap("categoryId")]
                [Validation(Required=false)]
                public string CategoryId { get; set; }

                /// <summary>
                /// <para>The product category description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Product category for AI-related capabilities</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The product category icon, which consists of the icon type (type) and icon information (value) fields.</para>
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public HiMarketIcon Icon { get; set; }

                /// <summary>
                /// <para>The product category name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ai-capabilities</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
