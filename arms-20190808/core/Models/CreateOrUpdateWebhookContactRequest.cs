// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateWebhookContactRequest : TeaModel {
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
        /// The notification template that is sent when an alert is triggered. This parameter is required if the **Method** parameter is set to **Post**. You can use the `$content` placeholder to specify the notification content. The content cannot exceed 500 characters in length. For more information, see [Variable description of a notification template](~~251834~~).\\
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
        /// The notification template that is sent when an alert is resolved. This parameter is required if the **Method** parameter is set to **Post**. You can use the `$content` placeholder to specify the notification content. The content cannot exceed 500 characters in length. For more information, see [Variable description of a notification template](~~251834~~).
        /// </summary>
        [NameInMap("RecoverBody")]
        [Validation(Required=false)]
        public string RecoverBody { get; set; }

        /// <summary>
        /// The URL of the HTTP request **method**.
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// The ID of the webhook alert contact.
        /// 
        /// *   If you do not specify this parameter, a new webhook alert contact is created.
        /// * If you specify this parameter, the specified webhook alert contact is modified.
        /// </summary>
        [NameInMap("WebhookId")]
        [Validation(Required=false)]
        public long? WebhookId { get; set; }

        /// <summary>
        /// The name of the webhook alert contact.
        /// </summary>
        [NameInMap("WebhookName")]
        [Validation(Required=false)]
        public string WebhookName { get; set; }

    }

}
