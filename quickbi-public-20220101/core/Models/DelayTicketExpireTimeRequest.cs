// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class DelayTicketExpireTimeRequest : TeaModel {
        /// <summary>
        /// The time to postpone.
        /// 
        /// *   Unit: minutes. Valid values: 0 to 240. Unit: minutes. Valid values: 4 hours.
        /// *   Expired bills cannot be extended.
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public int? ExpireTime { get; set; }

        /// <summary>
        /// The value of the third-party embedded ticket, that is, the accessTicket value in the URL.
        /// </summary>
        [NameInMap("Ticket")]
        [Validation(Required=false)]
        public string Ticket { get; set; }

    }

}
