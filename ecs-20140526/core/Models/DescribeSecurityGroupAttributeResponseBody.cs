// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSecurityGroupAttributeResponseBody : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InnerAccessPolicy")]
        [Validation(Required=false)]
        public string InnerAccessPolicy { get; set; }

        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public DescribeSecurityGroupAttributeResponseBodyPermissions Permissions { get; set; }
        public class DescribeSecurityGroupAttributeResponseBodyPermissions : TeaModel {
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public List<DescribeSecurityGroupAttributeResponseBodyPermissionsPermission> Permission { get; set; }
            public class DescribeSecurityGroupAttributeResponseBodyPermissionsPermission : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DestCidrIp")]
                [Validation(Required=false)]
                public string DestCidrIp { get; set; }

                [NameInMap("DestGroupId")]
                [Validation(Required=false)]
                public string DestGroupId { get; set; }

                [NameInMap("DestGroupName")]
                [Validation(Required=false)]
                public string DestGroupName { get; set; }

                [NameInMap("DestGroupOwnerAccount")]
                [Validation(Required=false)]
                public string DestGroupOwnerAccount { get; set; }

                [NameInMap("DestPrefixListId")]
                [Validation(Required=false)]
                public string DestPrefixListId { get; set; }

                [NameInMap("DestPrefixListName")]
                [Validation(Required=false)]
                public string DestPrefixListName { get; set; }

                [NameInMap("Direction")]
                [Validation(Required=false)]
                public string Direction { get; set; }

                [NameInMap("IpProtocol")]
                [Validation(Required=false)]
                public string IpProtocol { get; set; }

                [NameInMap("Ipv6DestCidrIp")]
                [Validation(Required=false)]
                public string Ipv6DestCidrIp { get; set; }

                [NameInMap("Ipv6SourceCidrIp")]
                [Validation(Required=false)]
                public string Ipv6SourceCidrIp { get; set; }

                [NameInMap("NicType")]
                [Validation(Required=false)]
                public string NicType { get; set; }

                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public string Priority { get; set; }

                [NameInMap("SecurityGroupRuleId")]
                [Validation(Required=false)]
                public string SecurityGroupRuleId { get; set; }

                [NameInMap("SourceCidrIp")]
                [Validation(Required=false)]
                public string SourceCidrIp { get; set; }

                [NameInMap("SourceGroupId")]
                [Validation(Required=false)]
                public string SourceGroupId { get; set; }

                [NameInMap("SourceGroupName")]
                [Validation(Required=false)]
                public string SourceGroupName { get; set; }

                [NameInMap("SourceGroupOwnerAccount")]
                [Validation(Required=false)]
                public string SourceGroupOwnerAccount { get; set; }

                [NameInMap("SourcePortRange")]
                [Validation(Required=false)]
                public string SourcePortRange { get; set; }

                [NameInMap("SourcePrefixListId")]
                [Validation(Required=false)]
                public string SourcePrefixListId { get; set; }

                [NameInMap("SourcePrefixListName")]
                [Validation(Required=false)]
                public string SourcePrefixListName { get; set; }

            }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
