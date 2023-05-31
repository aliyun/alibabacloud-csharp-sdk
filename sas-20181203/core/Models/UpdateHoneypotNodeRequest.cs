// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateHoneypotNodeRequest : TeaModel {
        /// <summary>
        /// The number of available probes.
        /// </summary>
        [NameInMap("AvailableProbeNum")]
        [Validation(Required=false)]
        public int? AvailableProbeNum { get; set; }

        /// <summary>
        /// The ID of the management node.
        /// 
        /// > You can call the [ListHoneypotNode](~~ListHoneypotNode~~) operation to query the IDs of management nodes.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

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
