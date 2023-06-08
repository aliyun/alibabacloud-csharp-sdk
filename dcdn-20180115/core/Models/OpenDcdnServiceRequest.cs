// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class OpenDcdnServiceRequest : TeaModel {
        /// <summary>
        /// Activates Dynamic Route for CDN (DCDN).
        /// </summary>
        [NameInMap("BillType")]
        [Validation(Required=false)]
        public string BillType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// > *   DCDN can be activated only once per Alibaba Cloud account. The Alibaba Cloud account must pass real-name verification.
        /// >*   You can call this operation up to 5 times per second per account.
        /// </summary>
        [NameInMap("WebsocketBillType")]
        [Validation(Required=false)]
        public string WebsocketBillType { get; set; }

    }

}
