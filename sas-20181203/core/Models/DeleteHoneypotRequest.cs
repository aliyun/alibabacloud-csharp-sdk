// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteHoneypotRequest : TeaModel {
        /// <summary>
        /// The ID of the honeypot.
        /// 
        /// > You can call the [ListHoneypot](~~ListHoneypot~~) operation to query the IDs of honeypots.
        /// </summary>
        [NameInMap("HoneypotId")]
        [Validation(Required=false)]
        public string HoneypotId { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
