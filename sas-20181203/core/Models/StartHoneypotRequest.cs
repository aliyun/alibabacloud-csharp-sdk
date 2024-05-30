// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class StartHoneypotRequest : TeaModel {
        /// <summary>
        /// The ID of the honeypot.
        /// 
        /// >  You can call the [ListHoneypot](~~ListHoneypot~~) operation to query the IDs of honeypots.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("HoneypotId")]
        [Validation(Required=false)]
        public string HoneypotId { get; set; }

        /// <summary>
        /// The language of the content in the request and response messages. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
