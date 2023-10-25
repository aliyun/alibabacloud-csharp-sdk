// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateRulesRequest : TeaModel {
        /// <summary>
        /// The frontend listener port that is used by the SLB instance.
        /// 
        /// Valid values: **1 to 65535**.
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// The frontend protocol that is used by the SLB instance.
        /// 
        /// > This parameter is required if the same port is used by listeners that use different protocols.
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// The ID of the SLB instance.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the Server Load Balancer (SLB) instance is deployed.
        /// 
        /// You can call the [DescribeRegions](~~27584~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The forwarding rules that you want to create. You can create up to 10 forwarding rules in each request. Each forwarding rule contains the following parameters:
        /// 
        /// *   **RuleName**: Required. The value must be of the STRING type. The name of the forwarding rule. The name must be 1 to 40 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (\_). Forwarding rule names must be unique within the same listener.
        /// *   **Domain**: Optional. The value must be of the STRING type. The domain name that is associated with the forwarding rule. You must specify at least one of this parameter and **Url**.
        /// *   **Url**: Optional. The value must be of the STRING type. The URL must be 1 to 80 characters in length and can contain only letters, digits, hyphens (-), forward slashes (/), periods (.), percent signs (%), question marks (?), number signs (#), and ampersands (&). The URL cannot be a forward slash (/). However, the URL must start with a forward slash (/). You must specify at least one of this parameter and **Domain**.
        /// *   **VServerGroupId**: Required. The value must be of the STRING type. The ID of the vServer group that is associated with the forwarding rule.
        /// 
        /// > You must specify at least one of `Domain` and `Url`. The combination of `Domain` and `Url` must be unique within the same listener.
        /// </summary>
        [NameInMap("RuleList")]
        [Validation(Required=false)]
        public string RuleList { get; set; }

    }

}
