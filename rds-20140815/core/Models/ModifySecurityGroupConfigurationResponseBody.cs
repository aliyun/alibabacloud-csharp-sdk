// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifySecurityGroupConfigurationResponseBody : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// An array that consists of information about the ECS security group.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public ModifySecurityGroupConfigurationResponseBodyItems Items { get; set; }
        public class ModifySecurityGroupConfigurationResponseBodyItems : TeaModel {
            [NameInMap("EcsSecurityGroupRelation")]
            [Validation(Required=false)]
            public List<ModifySecurityGroupConfigurationResponseBodyItemsEcsSecurityGroupRelation> EcsSecurityGroupRelation { get; set; }
            public class ModifySecurityGroupConfigurationResponseBodyItemsEcsSecurityGroupRelation : TeaModel {
                /// <summary>
                /// The network type of the ECS security group. Valid values:
                /// 
                /// *   **Classic**
                /// *   **VPC**
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The region ID.
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
