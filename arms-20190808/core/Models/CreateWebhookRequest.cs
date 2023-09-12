// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateWebhookRequest : TeaModel {
        /// <summary>
        /// The notification template that is sent when an alert is triggered. This parameter is required if the **Method** parameter is set to **Post**. You can use the $content placeholder to specify the notification content. The content cannot exceed 500 characters in length.
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// The name of the contact.
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// The HTTP request header.
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
        /// The HTTP request method.
        /// 
        /// *   `Get`
        /// *   `Post`
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
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The URL of the request **method**.
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
