// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodyInstance Instance { get; set; }
        public class DescribeInstanceResponseBodyInstance : TeaModel {
            [NameInMap("AutoRenewal")]
            [Validation(Required=false)]
            public bool? AutoRenewal { get; set; }

            [NameInMap("AutoUpgradeObVersion")]
            [Validation(Required=false)]
            public bool? AutoUpgradeObVersion { get; set; }

            [NameInMap("AvailableZones")]
            [Validation(Required=false)]
            public List<string> AvailableZones { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DataMergeTime")]
            [Validation(Required=false)]
            public string DataMergeTime { get; set; }

            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }

            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            [NameInMap("EnableUpgradeLogDisk")]
            [Validation(Required=false)]
            public bool? EnableUpgradeLogDisk { get; set; }

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

            [NameInMap("IsLatestObVersion")]
            [Validation(Required=false)]
            public bool? IsLatestObVersion { get; set; }

            [NameInMap("IsTrustEcs")]
            [Validation(Required=false)]
            public bool? IsTrustEcs { get; set; }

            [NameInMap("MaintainTime")]
            [Validation(Required=false)]
            public string MaintainTime { get; set; }

            [NameInMap("ObRpmVersion")]
            [Validation(Required=false)]
            public string ObRpmVersion { get; set; }

            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("Resource")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyInstanceResource Resource { get; set; }
            public class DescribeInstanceResponseBodyInstanceResource : TeaModel {
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceResourceCpu Cpu { get; set; }
                public class DescribeInstanceResponseBodyInstanceResourceCpu : TeaModel {
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
                public DescribeInstanceResponseBodyInstanceResourceDiskSize DiskSize { get; set; }
                public class DescribeInstanceResponseBodyInstanceResourceDiskSize : TeaModel {
                    [NameInMap("DataUsedSize")]
                    [Validation(Required=false)]
                    public double? DataUsedSize { get; set; }

                    [NameInMap("MaxDiskUsedObServer")]
                    [Validation(Required=false)]
                    public List<string> MaxDiskUsedObServer { get; set; }

                    [NameInMap("MaxDiskUsedPercent")]
                    [Validation(Required=false)]
                    public double? MaxDiskUsedPercent { get; set; }

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

                [NameInMap("LogDiskSize")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceResourceLogDiskSize LogDiskSize { get; set; }
                public class DescribeInstanceResponseBodyInstanceResourceLogDiskSize : TeaModel {
                    [NameInMap("TotalDiskSize")]
                    [Validation(Required=false)]
                    public long? TotalDiskSize { get; set; }

                    [NameInMap("UnitDiskSize")]
                    [Validation(Required=false)]
                    public long? UnitDiskSize { get; set; }

                }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceResourceMemory Memory { get; set; }
                public class DescribeInstanceResponseBodyInstanceResourceMemory : TeaModel {
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

            [NameInMap("Series")]
            [Validation(Required=false)]
            public string Series { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
