// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListPublishableProductsResponseBody : TeaModel {
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
        public ListPublishableProductsResponseBodyData Data { get; set; }
        public class ListPublishableProductsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of API products that can be published to the portal. Each element in the list is named productInfo and contains the information about an API product.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public List<ListPublishableProductsResponseBodyDataContent> Content { get; set; }
            public class ListPublishableProductsResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The description of the API product. This corresponds to the Description property of the Product resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>An API product that provides weather query capabilities</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the API product. This corresponds to the Name property of the Product resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>weather-query-api</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the API product. This is the primary ID of the Product resource. You can use this ID in the PublishProduct operation at /himarket/v1/products/{productId}/publications to publish the product to the portal. You can also use it to locate the product in operations such as GetProduct and ListProductPublications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>product-xxxxxxxx</para>
                /// </summary>
                [NameInMap("productId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

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
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
