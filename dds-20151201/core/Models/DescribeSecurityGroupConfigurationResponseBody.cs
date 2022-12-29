// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeSecurityGroupConfigurationResponseBody : TeaModel {
        /// <summary>
        /// Details about the ECS security groups.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSecurityGroupConfigurationResponseBodyItems Items { get; set; }
        public class DescribeSecurityGroupConfigurationResponseBodyItems : TeaModel {
            [NameInMap("RdsEcsSecurityGroupRel")]
            [Validation(Required=false)]
            public List<DescribeSecurityGroupConfigurationResponseBodyItemsRdsEcsSecurityGroupRel> RdsEcsSecurityGroupRel { get; set; }
            public class DescribeSecurityGroupConfigurationResponseBodyItemsRdsEcsSecurityGroupRel : TeaModel {
                /// <summary>
                /// The network type of the ECS security group. Valid values:
                /// 
                /// *   **vpc**
                /// *   **classic**
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// The region ID of the ECS security group.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the ECS security group.
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
