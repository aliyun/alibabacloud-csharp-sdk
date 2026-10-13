// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListPortalPublicationsResponseBody : TeaModel {
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
        public ListPortalPublicationsResponseBodyData Data { get; set; }
        public class ListPortalPublicationsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of published API products on the portal. The list elements are named portalConfig, and each element represents an API product publication record.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public List<ListPortalPublicationsResponseBodyDataContent> Content { get; set; }
            public class ListPortalPublicationsResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The creation time in ISO 8601 (RFC 3339) format in the UTC time zone, such as 2026-05-15T10:00:00Z.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-05-15T10:00:00Z</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <para>The description of the API product.</para>
                /// 
                /// <b>Example:</b>
                /// <para>API product for model services available to internal developers</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The API product ID. This is the primary ID of the Product resource, which identifies the API product associated with this publication record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>product-xxxxxxxx</para>
                /// </summary>
                [NameInMap("productId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

                /// <summary>
                /// <para>The API product name. This is the Name property of the Product resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>model-service</para>
                /// </summary>
                [NameInMap("productName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                /// <summary>
                /// <para>The API product type. The valid values are not defined in the API specification. Refer to the types displayed in the console.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP_API</para>
                /// </summary>
                [NameInMap("productType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                /// <summary>
                /// <para>The publication record ID of the API product. This ID is returned when the PublishProduct operation publishes the API product to the portal. You can use it in the /himarket/v1/products/{productId}/publications/{publicationId} path to locate the publication record for the UnpublishProduct operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>publication-xxxxxxxx</para>
                /// </summary>
                [NameInMap("publicationId")]
                [Validation(Required=false)]
                public string PublicationId { get; set; }

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
            /// <para>The total number of items.</para>
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
