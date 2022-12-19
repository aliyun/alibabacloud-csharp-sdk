// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateHoneypotNodeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to allow the honeypots to access the Internet. Valid values:
        /// 
        /// *   **true**: allows the honeypots to access the Internet.
        /// *   **false**: does not allow the honeypots to access the Internet.
        /// </summary>
        [NameInMap("AllowHoneypotAccessInternet")]
        [Validation(Required=false)]
        public bool? AllowHoneypotAccessInternet { get; set; }

        /// <summary>
        /// The number of probes that you want to allocate for the management node.
        /// </summary>
        [NameInMap("AvailableProbeNum")]
        [Validation(Required=false)]
        public int? AvailableProbeNum { get; set; }

        /// <summary>
        /// The name of the management node.
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// The CIDR blocks that are allowed to access the management node.
        /// </summary>
        [NameInMap("SecurityGroupProbeIpList")]
        [Validation(Required=false)]
        public List<string> SecurityGroupProbeIpList { get; set; }

    }

}
