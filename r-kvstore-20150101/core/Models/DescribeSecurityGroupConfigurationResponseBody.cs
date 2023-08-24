// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeSecurityGroupConfigurationResponseBody : TeaModel {
        /// <summary>
        /// The network type of the security group. Valid values:
        /// 
        /// *   **classic**: the classic network.
        /// *   **vpc**: the virtual private cloud (VPC).
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSecurityGroupConfigurationResponseBodyItems Items { get; set; }
        public class DescribeSecurityGroupConfigurationResponseBodyItems : TeaModel {
            [NameInMap("EcsSecurityGroupRelation")]
            [Validation(Required=false)]
            public List<DescribeSecurityGroupConfigurationResponseBodyItemsEcsSecurityGroupRelation> EcsSecurityGroupRelation { get; set; }
            public class DescribeSecurityGroupConfigurationResponseBodyItemsEcsSecurityGroupRelation : TeaModel {
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// Queries the security groups that are included in the whitelist of an ApsaraDB for Redis instance.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The operation that you want to perform. Set the value to **DescribeSecurityGroupConfiguration**.
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the security group.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
