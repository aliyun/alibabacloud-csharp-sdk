// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeSecurityGroupConfigurationResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSecurityGroupConfigurationResponseBodyItems Items { get; set; }
        public class DescribeSecurityGroupConfigurationResponseBodyItems : TeaModel {
            [NameInMap("EcsSecurityGroupRelation")]
            [Validation(Required=false)]
            public List<DescribeSecurityGroupConfigurationResponseBodyItemsEcsSecurityGroupRelation> EcsSecurityGroupRelation { get; set; }
            public class DescribeSecurityGroupConfigurationResponseBodyItemsEcsSecurityGroupRelation : TeaModel {
                public string NetType { get; set; }
                public string RegionId { get; set; }
                public string SecurityGroupId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
