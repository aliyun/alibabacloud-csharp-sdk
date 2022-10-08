// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeSecurityIpsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityIpGroups")]
        [Validation(Required=false)]
        public DescribeSecurityIpsResponseBodySecurityIpGroups SecurityIpGroups { get; set; }
        public class DescribeSecurityIpsResponseBodySecurityIpGroups : TeaModel {
            [NameInMap("SecurityIpGroup")]
            [Validation(Required=false)]
            public List<DescribeSecurityIpsResponseBodySecurityIpGroupsSecurityIpGroup> SecurityIpGroup { get; set; }
            public class DescribeSecurityIpsResponseBodySecurityIpGroupsSecurityIpGroup : TeaModel {
                [NameInMap("SecurityIpGroupAttribute")]
                [Validation(Required=false)]
                public string SecurityIpGroupAttribute { get; set; }

                [NameInMap("SecurityIpGroupName")]
                [Validation(Required=false)]
                public string SecurityIpGroupName { get; set; }

                [NameInMap("SecurityIpList")]
                [Validation(Required=false)]
                public string SecurityIpList { get; set; }

            }

        }

        [NameInMap("SecurityIps")]
        [Validation(Required=false)]
        public string SecurityIps { get; set; }

    }

}
