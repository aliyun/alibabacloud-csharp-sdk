// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSecurityGroupAttributeResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=true)]
        public string SecurityGroupId { get; set; }

        [NameInMap("Permissions")]
        [Validation(Required=true)]
        public DescribeSecurityGroupAttributeResponsePermissions Permissions { get; set; }
        public class DescribeSecurityGroupAttributeResponsePermissions : TeaModel {
            [NameInMap("Permission")]
            [Validation(Required=true)]
            public List<DescribeSecurityGroupAttributeResponsePermissionsPermission> Permission { get; set; }
            public class DescribeSecurityGroupAttributeResponsePermissionsPermission : TeaModel {
                public string DestCidrIp { get; set; }
                public string SourceCidrIp { get; set; }
                public string IpProtocol { get; set; }
                public int? Priority { get; set; }
                public string Policy { get; set; }
                public string Direction { get; set; }
                public string CreationTime { get; set; }
                public string PortRange { get; set; }
                public string SourcePortRange { get; set; }
            }
        };

    }

}
