// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeSecurityGroupConfigurationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSecurityGroupConfigurationResponseBodyItems Items { get; set; }
        public class DescribeSecurityGroupConfigurationResponseBodyItems : TeaModel {
            [NameInMap("RdsEcsSecurityGroupRel")]
            [Validation(Required=false)]
            public List<DescribeSecurityGroupConfigurationResponseBodyItemsRdsEcsSecurityGroupRel> RdsEcsSecurityGroupRel { get; set; }
            public class DescribeSecurityGroupConfigurationResponseBodyItemsRdsEcsSecurityGroupRel : TeaModel {
                public string SecurityGroupId { get; set; }
                public string NetType { get; set; }
                public string RegionId { get; set; }
            }
        };

    }

}
