// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeHostSecurityGroupAttributeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecGroupPermission")]
        [Validation(Required=false)]
        public DescribeHostSecurityGroupAttributeResponseBodySecGroupPermission SecGroupPermission { get; set; }
        public class DescribeHostSecurityGroupAttributeResponseBodySecGroupPermission : TeaModel {
            [NameInMap("SecGroupPermission")]
            [Validation(Required=false)]
            public List<DescribeHostSecurityGroupAttributeResponseBodySecGroupPermissionSecGroupPermission> SecGroupPermission { get; set; }
            public class DescribeHostSecurityGroupAttributeResponseBodySecGroupPermissionSecGroupPermission : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Direction")]
                [Validation(Required=false)]
                public string Direction { get; set; }

                [NameInMap("IpProtocol")]
                [Validation(Required=false)]
                public string IpProtocol { get; set; }

                [NameInMap("NicType")]
                [Validation(Required=false)]
                public string NicType { get; set; }

                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                [NameInMap("SourceCidrIp")]
                [Validation(Required=false)]
                public string SourceCidrIp { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public int? Success { get; set; }

    }

}
