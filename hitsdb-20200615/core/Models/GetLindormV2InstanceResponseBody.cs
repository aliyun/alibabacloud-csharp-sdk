// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLindormV2InstanceResponseBody : TeaModel {
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        [NameInMap("ArbiterVSwitchId")]
        [Validation(Required=false)]
        public string ArbiterVSwitchId { get; set; }

        [NameInMap("ArbiterZoneId")]
        [Validation(Required=false)]
        public string ArbiterZoneId { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        [NameInMap("CloudStorageSize")]
        [Validation(Required=false)]
        public long? CloudStorageSize { get; set; }

        [NameInMap("ColdStorage")]
        [Validation(Required=false)]
        public int? ColdStorage { get; set; }

        [NameInMap("CreateMilliseconds")]
        [Validation(Required=false)]
        public long? CreateMilliseconds { get; set; }

        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public string DeletionProtection { get; set; }

        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        [NameInMap("DiskThreshold")]
        [Validation(Required=false)]
        public string DiskThreshold { get; set; }

        [NameInMap("DiskUsage")]
        [Validation(Required=false)]
        public string DiskUsage { get; set; }

        [NameInMap("EnableCompute")]
        [Validation(Required=false)]
        public bool? EnableCompute { get; set; }

        [NameInMap("EngineList")]
        [Validation(Required=false)]
        public List<GetLindormV2InstanceResponseBodyEngineList> EngineList { get; set; }
        public class GetLindormV2InstanceResponseBodyEngineList : TeaModel {
            [NameInMap("ConnectAddressList")]
            [Validation(Required=false)]
            public List<GetLindormV2InstanceResponseBodyEngineListConnectAddressList> ConnectAddressList { get; set; }
            public class GetLindormV2InstanceResponseBodyEngineListConnectAddressList : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("EnableBackup")]
            [Validation(Required=false)]
            public string EnableBackup { get; set; }

            [NameInMap("EnableCDC")]
            [Validation(Required=false)]
            public string EnableCDC { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("IsLastVersion")]
            [Validation(Required=false)]
            public bool? IsLastVersion { get; set; }

            [NameInMap("LatestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            [NameInMap("NodeGroup")]
            [Validation(Required=false)]
            public List<GetLindormV2InstanceResponseBodyEngineListNodeGroup> NodeGroup { get; set; }
            public class GetLindormV2InstanceResponseBodyEngineListNodeGroup : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("CpuCoreCount")]
                [Validation(Required=false)]
                public int? CpuCoreCount { get; set; }

                [NameInMap("EnableAttachLocalDisk")]
                [Validation(Required=false)]
                public bool? EnableAttachLocalDisk { get; set; }

                [NameInMap("LocalDiskCapacity")]
                [Validation(Required=false)]
                public long? LocalDiskCapacity { get; set; }

                [NameInMap("LocalDiskCategory")]
                [Validation(Required=false)]
                public string LocalDiskCategory { get; set; }

                [NameInMap("MemorySizeGiB")]
                [Validation(Required=false)]
                public int? MemorySizeGiB { get; set; }

                [NameInMap("NodeSpec")]
                [Validation(Required=false)]
                public string NodeSpec { get; set; }

                [NameInMap("Quantity")]
                [Validation(Required=false)]
                public int? Quantity { get; set; }

                [NameInMap("ResourceGroupName")]
                [Validation(Required=false)]
                public string ResourceGroupName { get; set; }

                [NameInMap("SpecId")]
                [Validation(Required=false)]
                public string SpecId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("ExpiredMilliseconds")]
        [Validation(Required=false)]
        public long? ExpiredMilliseconds { get; set; }

        [NameInMap("InitialRootPassword")]
        [Validation(Required=false)]
        public string InitialRootPassword { get; set; }

        [NameInMap("InstanceAlias")]
        [Validation(Required=false)]
        public string InstanceAlias { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("PrimaryVSwitchId")]
        [Validation(Required=false)]
        public string PrimaryVSwitchId { get; set; }

        [NameInMap("PrimaryZoneId")]
        [Validation(Required=false)]
        public string PrimaryZoneId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("StandbyVSwitchId")]
        [Validation(Required=false)]
        public string StandbyVSwitchId { get; set; }

        [NameInMap("StandbyZoneId")]
        [Validation(Required=false)]
        public string StandbyZoneId { get; set; }

        [NameInMap("StorageUsage")]
        [Validation(Required=false)]
        public GetLindormV2InstanceResponseBodyStorageUsage StorageUsage { get; set; }
        public class GetLindormV2InstanceResponseBodyStorageUsage : TeaModel {
            [NameInMap("CapacityByDiskCategory")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> CapacityByDiskCategory { get; set; }

            [NameInMap("EngineUsage")]
            [Validation(Required=false)]
            public Dictionary<string, object> EngineUsage { get; set; }

        }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

        [NameInMap("WhiteIpList")]
        [Validation(Required=false)]
        public List<GetLindormV2InstanceResponseBodyWhiteIpList> WhiteIpList { get; set; }
        public class GetLindormV2InstanceResponseBodyWhiteIpList : TeaModel {
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("IpList")]
            [Validation(Required=false)]
            public string IpList { get; set; }

        }

        [NameInMap("ZoneEngineInfoMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> ZoneEngineInfoMap { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
