// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateWebhookContactResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned webhook alert contact.
        /// </summary>
        [NameInMap("WebhookContact")]
        [Validation(Required=false)]
        public CreateOrUpdateWebhookContactResponseBodyWebhookContact WebhookContact { get; set; }
        public class CreateOrUpdateWebhookContactResponseBodyWebhookContact : TeaModel {
            /// <summary>
            /// The information about the webhook alert contact.
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public CreateOrUpdateWebhookContactResponseBodyWebhookContactWebhook Webhook { get; set; }
            public class CreateOrUpdateWebhookContactResponseBodyWebhookContactWebhook : TeaModel {
                /// <summary>
                /// The HTTP request headers.
                /// </summary>
                [NameInMap("BizHeaders")]
                [Validation(Required=false)]
                public string BizHeaders { get; set; }

                /// <summary>
                /// The parameters in the HTTP request.
                /// </summary>
                [NameInMap("BizParams")]
                [Validation(Required=false)]
                public string BizParams { get; set; }

                /// <summary>
                /// The alert notification template.
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public string Body { get; set; }

                /// <summary>
                /// The HTTP request method.
                /// 
                /// *   Post
                /// *   Get
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// The notification template for clearing alerts.
                /// </summary>
                [NameInMap("RecoverBody")]
                [Validation(Required=false)]
                public string RecoverBody { get; set; }

                /// <summary>
                /// The URL of the request method.
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// The ID of the webhook alert contact.
            /// </summary>
            [NameInMap("WebhookId")]
            [Validation(Required=false)]
            public float? WebhookId { get; set; }

            /// <summary>
            /// The name of the webhook alert contact.
            /// </summary>
            [NameInMap("WebhookName")]
            [Validation(Required=false)]
            public string WebhookName { get; set; }

        }

    }

}
