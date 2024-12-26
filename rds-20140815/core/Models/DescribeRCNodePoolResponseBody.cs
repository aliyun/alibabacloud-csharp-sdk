// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCNodePoolResponseBody : TeaModel {
        [NameInMap("NodePoolList")]
        [Validation(Required=false)]
        public List<DescribeRCNodePoolResponseBodyNodePoolList> NodePoolList { get; set; }
        public class DescribeRCNodePoolResponseBodyNodePoolList : TeaModel {
            [NameInMap("AutoPay")]
            [Validation(Required=false)]
            public bool? AutoPay { get; set; }

            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("CreateMode")]
            [Validation(Required=false)]
            public string CreateMode { get; set; }

            [NameInMap("DataDisk")]
            [Validation(Required=false)]
            public List<DescribeRCNodePoolResponseBodyNodePoolListDataDisk> DataDisk { get; set; }
            public class DescribeRCNodePoolResponseBodyNodePoolListDataDisk : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("DeleteWithInstance")]
                [Validation(Required=false)]
                public bool? DeleteWithInstance { get; set; }

                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public string Encrypted { get; set; }

                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

            }

            [NameInMap("DeploymentSetId")]
            [Validation(Required=false)]
            public string DeploymentSetId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            [NameInMap("InternetMaxBandwidthOut")]
            [Validation(Required=false)]
            public int? InternetMaxBandwidthOut { get; set; }

            [NameInMap("IoOptimized")]
            [Validation(Required=false)]
            public string IoOptimized { get; set; }

            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            [NameInMap("NodePoolId")]
            [Validation(Required=false)]
            public string NodePoolId { get; set; }

            [NameInMap("NodePoolName")]
            [Validation(Required=false)]
            public string NodePoolName { get; set; }

            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("SecurityEnhancementStrategy")]
            [Validation(Required=false)]
            public string SecurityEnhancementStrategy { get; set; }

            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            [NameInMap("SystemDisk")]
            [Validation(Required=false)]
            public DescribeRCNodePoolResponseBodyNodePoolListSystemDisk SystemDisk { get; set; }
            public class DescribeRCNodePoolResponseBodyNodePoolListSystemDisk : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

            }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeRCNodePoolResponseBodyNodePoolListTag> Tag { get; set; }
            public class DescribeRCNodePoolResponseBodyNodePoolListTag : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
