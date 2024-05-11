// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeWebhookContactsRequest : TeaModel {
        /// <summary>
        /// The ID of the alert contact.
        /// </summary>
        [NameInMap("ContactIds")]
        [Validation(Required=false)]
        public string ContactIds { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// The number of alert contacts displayed on each page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// The name of the webhook alert contact.
        /// </summary>
        [NameInMap("WebhookName")]
        [Validation(Required=false)]
        public string WebhookName { get; set; }

    }

}
