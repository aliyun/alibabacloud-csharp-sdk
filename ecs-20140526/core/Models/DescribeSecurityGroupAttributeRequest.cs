// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSecurityGroupAttributeRequest : TeaModel {
        /// <summary>
        /// The direction in which the security group rule is applied. Valid values:
        /// 
        /// *   egress: outbound
        /// *   ingress: inbound
        /// *   all: outbound and inbound
        /// 
        /// Default value: all.
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// The network interface type of the security group rule.
        /// 
        /// *   Default value for rules of security groups in the classic network: internet. Valid values for rules of security groups in the classic network:
        /// 
        ///     *   internet
        ///     *   intranet
        /// 
        ///     > You can query security group rules of only one network interface type in a single call. To query security group rules of both network interface types, call the operation twice.
        /// 
        /// *   When the security group is in a virtual private cloud (VPC), set the value to intranet. This is also the default value.
        /// 
        ///     > If you set this parameter to internet or leave this parameter empty, the intranet value is automatically used.
        /// </summary>
        [NameInMap("NicType")]
        [Validation(Required=false)]
        public string NicType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the security group. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
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
        /// The ID of the security group.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

    }

}
