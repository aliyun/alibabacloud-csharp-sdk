// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSecurityGroupAttributeResponseBody : TeaModel {
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public DescribeSecurityGroupAttributeResponseBodyPermissions Permissions { get; set; }
        public class DescribeSecurityGroupAttributeResponseBodyPermissions : TeaModel {
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public List<DescribeSecurityGroupAttributeResponseBodyPermissionsPermission> Permission { get; set; }
            public class DescribeSecurityGroupAttributeResponseBodyPermissionsPermission : TeaModel {
                public string CreationTime { get; set; }
                public string DestCidrIp { get; set; }
                public string Direction { get; set; }
                public string IpProtocol { get; set; }
                public string Policy { get; set; }
                public string PortRange { get; set; }
                public int? Priority { get; set; }
                public string SourceCidrIp { get; set; }
                public string SourcePortRange { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

    }

}
