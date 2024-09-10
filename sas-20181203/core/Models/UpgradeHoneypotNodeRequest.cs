// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpgradeHoneypotNodeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to allow the honeypot to access the Internet. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("AllowHoneypotAccessInternet")]
        [Validation(Required=false)]
        public bool? AllowHoneypotAccessInternet { get; set; }

        /// <summary>
        /// The language of the content within the request and response.
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the management node that you want to upgrade.
        /// 
        /// >  You can call the [ListHoneypotNode](~~ListHoneypotNode~~) operation to obtain the ID.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

    }

}
