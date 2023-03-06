// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdateAccountWebhookRequest : TeaModel {
        /// <summary>
        /// The space ID of the user under the ISV account.
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// Specifies whether to use HTTP callbacks to receive receipts. Valid values: Y and N. A value of Y indicates that HTTP callbacks are used to receive receipts. A value of N indicates that HTTP callbacks are not used to receive receipts.
        /// </summary>
        [NameInMap("HttpFlag")]
        [Validation(Required=false)]
        public string HttpFlag { get; set; }

        /// <summary>
        /// Specifies whether to use Message Service (MNS) queues to receive receipts. Valid values: Y and N. A value of Y indicates that MNS queues are used to receive receipts. A value of N indicates that MNS queues are not used to receive receipts.
        /// </summary>
        [NameInMap("QueueFlag")]
        [Validation(Required=false)]
        public string QueueFlag { get; set; }

        /// <summary>
        /// The callback URL to which status reports are sent by using HTTP callbacks.
        /// </summary>
        [NameInMap("StatusCallbackUrl")]
        [Validation(Required=false)]
        public string StatusCallbackUrl { get; set; }

    }

}
