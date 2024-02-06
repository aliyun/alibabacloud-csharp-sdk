// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSecurityGroupAttributeResponseBody : TeaModel {
        /// <summary>
        /// The description of the security group.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Details about the rules.
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public DescribeSecurityGroupAttributeResponseBodyPermissions Permissions { get; set; }
        public class DescribeSecurityGroupAttributeResponseBodyPermissions : TeaModel {
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public List<DescribeSecurityGroupAttributeResponseBodyPermissionsPermission> Permission { get; set; }
            public class DescribeSecurityGroupAttributeResponseBodyPermissionsPermission : TeaModel {
                /// <summary>
                /// The time at which the security group rule was created. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The range of destination IP addresses for outbound access control.
                /// </summary>
                [NameInMap("DestCidrIp")]
                [Validation(Required=false)]
                public string DestCidrIp { get; set; }

                /// <summary>
                /// The direction in which the security group rule is applied.
                /// </summary>
                [NameInMap("Direction")]
                [Validation(Required=false)]
                public string Direction { get; set; }

                /// <summary>
                /// The transport layer protocol.
                /// </summary>
                [NameInMap("IpProtocol")]
                [Validation(Required=false)]
                public string IpProtocol { get; set; }

                /// <summary>
                /// The policy.
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// The source port range.
                /// </summary>
                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                /// <summary>
                /// The priority of the rule.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// The range of source IP addresses for inbound access control.
                /// </summary>
                [NameInMap("SourceCidrIp")]
                [Validation(Required=false)]
                public string SourceCidrIp { get; set; }

                /// <summary>
                /// The source port number range for the security group.
                /// </summary>
                [NameInMap("SourcePortRange")]
                [Validation(Required=false)]
                public string SourcePortRange { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the destination security group.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// The name of the destination security group.
        /// </summary>
        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

    }

}
