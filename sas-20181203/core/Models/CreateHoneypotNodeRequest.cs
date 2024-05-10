// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateHoneypotNodeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to allow honeypots to access the Internet. Valid values:
        /// 
        /// *   **true**: allows honeypots to access the Internet.
        /// *   **false**: does not allow honeypots to access the Internet.
        /// </summary>
        [NameInMap("AllowHoneypotAccessInternet")]
        [Validation(Required=false)]
        public bool? AllowHoneypotAccessInternet { get; set; }

        /// <summary>
        /// The number of available probes.
        /// </summary>
        [NameInMap("AvailableProbeNum")]
        [Validation(Required=false)]
        public int? AvailableProbeNum { get; set; }

        /// <summary>
        /// The name of the management node.
        /// 
        /// This parameter is required.
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
