// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class BatchDeleteVpcFirewallControlPolicyRequest : TeaModel {
        /// <summary>
        /// The UUIDs of access control policies.
        /// </summary>
        [NameInMap("AclUuidList")]
        [Validation(Required=false)]
        public List<string> AclUuidList { get; set; }

        /// <summary>
        /// The instance ID of the VPC firewall.
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

    }

}
