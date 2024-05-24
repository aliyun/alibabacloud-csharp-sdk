// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class AddListenerWhiteListItemRequest : TeaModel {
        /// <summary>
        /// The frontend port that is used by the CLB instance.
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
        /// The ID of the region where the Classic Load Balancer (CLB) instance is created.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
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
        /// The IP addresses or CIDR blocks that you want to add to the whitelist.
        /// 
        /// This parameter takes effect when the **AccessControlStatus** parameter of the listener is set to **open_white_list**.
        /// 
        /// Separate multiple IP addresses or CIDR blocks with commas (,).
        /// 
        /// You cannot enter **0.0.0.0** or **0.0.0.0/0**. To disable access control, you can call the [SetListenerAccessControlStatus](https://help.aliyun.com/document_detail/27599.html) operation to set the value of the **AccessControlStatus** parameter to **close**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceItems")]
        [Validation(Required=false)]
        public string SourceItems { get; set; }

    }

}
