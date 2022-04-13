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
                public string CreateTime { get; set; }
                public string Description { get; set; }
                public string DestCidrIp { get; set; }
                public string DestGroupId { get; set; }
                public string DestGroupName { get; set; }
                public string DestGroupOwnerAccount { get; set; }
                public string DestPrefixListId { get; set; }
                public string DestPrefixListName { get; set; }
                public string Direction { get; set; }
                public string IpProtocol { get; set; }
                public string Ipv6DestCidrIp { get; set; }
                public string Ipv6SourceCidrIp { get; set; }
                public string NicType { get; set; }
                public string Policy { get; set; }
                public string PortRange { get; set; }
                public string Priority { get; set; }
                public string SourceCidrIp { get; set; }
                public string SourceGroupId { get; set; }
                public string SourceGroupName { get; set; }
                public string SourceGroupOwnerAccount { get; set; }
                public string SourcePortRange { get; set; }
                public string SourcePrefixListId { get; set; }
                public string SourcePrefixListName { get; set; }
            }
        };

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
