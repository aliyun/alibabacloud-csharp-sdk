// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateWebhookRequest : TeaModel {
        /// <summary>
        /// The notification template that is sent when an alert is triggered. This parameter is required if the **Method** parameter is set to **Post**. You can use the $content placeholder to specify the notification content. The content cannot exceed 500 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// The ID of the webhook alert contact. You can call the **SearchAlertContact** operation to obtain the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public long? ContactId { get; set; }

        /// <summary>
        /// The name of the webhook alert contact.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// The HTTP request headers.
        /// </summary>
        [NameInMap("HttpHeaders")]
        [Validation(Required=false)]
        public string HttpHeaders { get; set; }

        /// <summary>
        /// The parameters in the HTTP request.
        /// </summary>
        [NameInMap("HttpParams")]
        [Validation(Required=false)]
        public string HttpParams { get; set; }

        /// <summary>
        /// The HTTP request method. Valid values:
        /// 
        /// *   `Get`
        /// *   `Post`
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// The notification template that is sent when an alert is resolved. This parameter is required if the **Method** parameter is set to **Post**. You can use the $content placeholder to specify the notification content. The content cannot exceed 500 characters in length.
        /// </summary>
        [NameInMap("RecoverBody")]
        [Validation(Required=false)]
        public string RecoverBody { get; set; }

        /// <summary>
        /// The ID of the region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The URL of the HTTP request method.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
