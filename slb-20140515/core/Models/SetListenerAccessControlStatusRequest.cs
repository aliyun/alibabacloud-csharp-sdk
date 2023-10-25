// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class SetListenerAccessControlStatusRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the whitelist. Valid values:
        /// 
        /// *   **open_white_list**: enables the whitelist.
        /// *   **close**: disables the whitelist.
        /// 
        /// >  After the whitelist is enabled, if no IP address is added to the whitelist, the CLB instance does not distribute network traffic.
        /// </summary>
        [NameInMap("AccessControlStatus")]
        [Validation(Required=false)]
        public string AccessControlStatus { get; set; }

        /// <summary>
        /// The frontend port that is used by the CLB instance.
        /// 
        /// Valid values: **1 to 65535**.
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// The frontend protocol that is used by the CLB instance.
        /// 
        /// >  This parameter is required when listeners that use different protocols listen on the same port.
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// The ID of the CLB instance.
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
        /// The region where the Classic Load Balancer (CLB) instance is created.
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

    }

}
