// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListProductSubscriptionsResponseBody : TeaModel {
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
        public ListProductSubscriptionsResponseBodyData Data { get; set; }
        public class ListProductSubscriptionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The subscription list of the API product. The list element is named subscription, and each element represents an API product subscription record.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public List<ListProductSubscriptionsResponseBodyDataContent> Content { get; set; }
            public class ListProductSubscriptionsResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The ID of the consumer to which the subscription belongs. This ID and the consumerName returned in the same element refer to the same consumer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cs-xxxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("consumerId")]
                [Validation(Required=false)]
                public string ConsumerId { get; set; }

                /// <summary>
                /// <para>The name of the consumer to which the subscription belongs. This corresponds to the keyword search for the consumerName request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>consumer-1</para>
                /// </summary>
                [NameInMap("consumerName")]
                [Validation(Required=false)]
                public string ConsumerName { get; set; }

                /// <summary>
                /// <para>The ID of the subscribed API product. This is the primary ID of the API product resource and is the same as the productId path parameter in this operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>product-xxxxxxxx</para>
                /// </summary>
                [NameInMap("productId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

                /// <summary>
                /// <para>The name of the subscribed API product. This is the Name property of the API product resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>model-service</para>
                /// </summary>
                [NameInMap("productName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                /// <summary>
                /// <para>The type of the subscribed API product. Valid values: REST_API, HTTP_API, MCP_SERVER, AGENT_API, and MODEL_API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MCP_SERVER</para>
                /// </summary>
                [NameInMap("productType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                /// <summary>
                /// <para>The subscription status. Valid values: PENDING and APPROVED. (These values are defined in the enumeration for the status request parameter. This response parameter is not annotated with @enums.)</para>
                /// 
                /// <b>Example:</b>
                /// <para>APPROVED</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The subscription ID, which identifies an API product subscription record. You can use this ID to cancel the subscription by calling UnsubscribeHiMarketProduct or approve the subscription by calling ApproveProductSubscription. Both operations locate the record by using the /himarket/v1/consumers/{consumerId}/subscriptions/{subscriptionId} path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sub-xxxxxxxx</para>
                /// </summary>
                [NameInMap("subscriptionId")]
                [Validation(Required=false)]
                public string SubscriptionId { get; set; }

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
            /// <para>The number of entries per page.</para>
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
