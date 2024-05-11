// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteWebhookContactRequest : TeaModel {
        /// <summary>
        /// The ID of the webhook alert contact.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WebhookId")]
        [Validation(Required=false)]
        public long? WebhookId { get; set; }

    }

}
