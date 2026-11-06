// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class SubscribeProductResponseBody : TeaModel {
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
        public SubscribeProductResponseBodyData Data { get; set; }
        public class SubscribeProductResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the consumer to which the subscription belongs. This is the same as the consumerId path parameter in the request and refers to the same consumer as the consumerName returned at the same level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cs-xxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("consumerId")]
            [Validation(Required=false)]
            public string ConsumerId { get; set; }

            /// <summary>
            /// <para>The name of the consumer to which the subscription belongs. This consumer is the same as the consumerId returned at the same level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>consumer-1</para>
            /// </summary>
            [NameInMap("consumerName")]
            [Validation(Required=false)]
            public string ConsumerName { get; set; }

            /// <summary>
            /// <para>The ID of the subscribed API product. This is the primary ID of the Product resource and is the same as the productId specified in the request body.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product-xxxxxxxx</para>
            /// </summary>
            [NameInMap("productId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The name of the subscribed API product. This is the Name property of the Product resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model-service</para>
            /// </summary>
            [NameInMap("productName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The type of the subscribed API product. The value set is not declared in this operation definition. The response parameter with the same name in the related ListProductSubscriptions operation is annotated with @enums. Valid values: REST_API, HTTP_API, MCP_SERVER, AGENT_API, and MODEL_API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MCP_SERVER</para>
            /// </summary>
            [NameInMap("productType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The subscription status. Valid values: PENDING and APPROVED. The value set is declared in the enum of the status request parameter of the related ListProductSubscriptions operation. This response parameter is not annotated with @enums.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The subscription ID, which identifies the API product subscription record corresponding to this subscription. You can use this ID to call UnsubscribeHiMarketProduct to cancel the subscription or call ApproveProductSubscription to approve the subscription. Both operations identify the record by using /himarket/v1/consumers/{consumerId}/subscriptions/{subscriptionId}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sub-xxxxxxxx</para>
            /// </summary>
            [NameInMap("subscriptionId")]
            [Validation(Required=false)]
            public string SubscriptionId { get; set; }

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
