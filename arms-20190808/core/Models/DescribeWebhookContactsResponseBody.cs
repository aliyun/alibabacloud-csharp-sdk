// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeWebhookContactsResponseBody : TeaModel {
        /// <summary>
        /// The returned objects.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public DescribeWebhookContactsResponseBodyPageBean PageBean { get; set; }
        public class DescribeWebhookContactsResponseBodyPageBean : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// The number of alert contacts displayed on each page.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The total number of alert contacts.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

            /// <summary>
            /// The list of webhook alert contacts.
            /// </summary>
            [NameInMap("WebhookContacts")]
            [Validation(Required=false)]
            public List<DescribeWebhookContactsResponseBodyPageBeanWebhookContacts> WebhookContacts { get; set; }
            public class DescribeWebhookContactsResponseBodyPageBeanWebhookContacts : TeaModel {
                /// <summary>
                /// The details of the webhook alert contact.
                /// </summary>
                [NameInMap("Webhook")]
                [Validation(Required=false)]
                public DescribeWebhookContactsResponseBodyPageBeanWebhookContactsWebhook Webhook { get; set; }
                public class DescribeWebhookContactsResponseBodyPageBeanWebhookContactsWebhook : TeaModel {
                    /// <summary>
                    /// The header of the HTTP request.
                    /// </summary>
                    [NameInMap("BizHeaders")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> BizHeaders { get; set; }

                    /// <summary>
                    /// The parameters in the HTTP request.
                    /// </summary>
                    [NameInMap("BizParams")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> BizParams { get; set; }

                    /// <summary>
                    /// The alert notification template.
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public string Body { get; set; }

                    /// <summary>
                    /// The HTTP request method.
                    /// 
                    /// *   Get
                    /// *   Post
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

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
