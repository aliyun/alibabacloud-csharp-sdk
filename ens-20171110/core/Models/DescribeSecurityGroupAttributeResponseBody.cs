// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSecurityGroupAttributeResponseBody : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public DescribeSecurityGroupAttributeResponseBodyPermissions Permissions { get; set; }
        public class DescribeSecurityGroupAttributeResponseBodyPermissions : TeaModel {
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public List<DescribeSecurityGroupAttributeResponseBodyPermissionsPermission> Permission { get; set; }
            public class DescribeSecurityGroupAttributeResponseBodyPermissionsPermission : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DestCidrIp")]
                [Validation(Required=false)]
                public string DestCidrIp { get; set; }

                [NameInMap("Direction")]
                [Validation(Required=false)]
                public string Direction { get; set; }

                [NameInMap("IpProtocol")]
                [Validation(Required=false)]
                public string IpProtocol { get; set; }

                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("SourceCidrIp")]
                [Validation(Required=false)]
                public string SourceCidrIp { get; set; }

                [NameInMap("SourcePortRange")]
                [Validation(Required=false)]
                public string SourcePortRange { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

    }

}
