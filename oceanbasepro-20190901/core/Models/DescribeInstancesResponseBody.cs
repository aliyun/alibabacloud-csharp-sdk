// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            [NameInMap("AvailableZones")]
            [Validation(Required=false)]
            public List<string> AvailableZones { get; set; }

            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }

            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            [NameInMap("DiskSize")]
            [Validation(Required=false)]
            public string DiskSize { get; set; }

            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            [NameInMap("EnableUpgradeNodes")]
            [Validation(Required=false)]
            public bool? EnableUpgradeNodes { get; set; }

            [NameInMap("ExpireSeconds")]
            [Validation(Required=false)]
            public int? ExpireSeconds { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("InstanceClass")]
            [Validation(Required=false)]
            public string InstanceClass { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("MaintainTime")]
            [Validation(Required=false)]
            public string MaintainTime { get; set; }

            [NameInMap("Mem")]
            [Validation(Required=false)]
            public long? Mem { get; set; }

            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("Resource")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesResource Resource { get; set; }
            public class DescribeInstancesResponseBodyInstancesResource : TeaModel {
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesResourceCpu Cpu { get; set; }
                public class DescribeInstancesResponseBodyInstancesResourceCpu : TeaModel {
                    [NameInMap("TotalCpu")]
                    [Validation(Required=false)]
                    public long? TotalCpu { get; set; }

                    [NameInMap("UnitCpu")]
                    [Validation(Required=false)]
                    public long? UnitCpu { get; set; }

                    [NameInMap("UsedCpu")]
                    [Validation(Required=false)]
                    public long? UsedCpu { get; set; }

                }

                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesResourceDiskSize DiskSize { get; set; }
                public class DescribeInstancesResponseBodyInstancesResourceDiskSize : TeaModel {
                    [NameInMap("TotalDiskSize")]
                    [Validation(Required=false)]
                    public long? TotalDiskSize { get; set; }

                    [NameInMap("UnitDiskSize")]
                    [Validation(Required=false)]
                    public long? UnitDiskSize { get; set; }

                    [NameInMap("UsedDiskSize")]
                    [Validation(Required=false)]
                    public long? UsedDiskSize { get; set; }

                }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesResourceMemory Memory { get; set; }
                public class DescribeInstancesResponseBodyInstancesResourceMemory : TeaModel {
                    [NameInMap("TotalMemory")]
                    [Validation(Required=false)]
                    public long? TotalMemory { get; set; }

                    [NameInMap("UnitMemory")]
                    [Validation(Required=false)]
                    public long? UnitMemory { get; set; }

                    [NameInMap("UsedMemory")]
                    [Validation(Required=false)]
                    public long? UsedMemory { get; set; }

                }

                [NameInMap("UnitCount")]
                [Validation(Required=false)]
                public long? UnitCount { get; set; }

            }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("SecurityIps")]
            [Validation(Required=false)]
            public List<string> SecurityIps { get; set; }

            [NameInMap("Series")]
            [Validation(Required=false)]
            public string Series { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("UsedDiskSize")]
            [Validation(Required=false)]
            public long? UsedDiskSize { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
