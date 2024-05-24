// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class RemoveListenerWhiteListItemRequest : TeaModel {
        /// <summary>
        /// The listening port.
        /// 
        /// This parameter is required.
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
        /// 
        /// This parameter is required.
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
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/27584.html) operation to query the most recent region list.
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
        /// The list of IP addresses or CIDR blocks that you want to remove from the whitelist. Separate multiple IP addresses or CIDR blocks with commas (,).
        /// 
        /// >  If all IP addresses are removed from the whitelist, the listener does not forward requests.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceItems")]
        [Validation(Required=false)]
        public string SourceItems { get; set; }

    }

}
