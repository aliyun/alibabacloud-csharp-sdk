// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLindormInstanceResponseBody : TeaModel {
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        [NameInMap("ArbiterVSwitchId")]
        [Validation(Required=false)]
        public string ArbiterVSwitchId { get; set; }

        [NameInMap("ArbiterZoneId")]
        [Validation(Required=false)]
        public string ArbiterZoneId { get; set; }

        [NameInMap("ArchVersion")]
        [Validation(Required=false)]
        public string ArchVersion { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        [NameInMap("ColdStorage")]
        [Validation(Required=false)]
        public int? ColdStorage { get; set; }

        [NameInMap("CoreDiskCategory")]
        [Validation(Required=false)]
        public string CoreDiskCategory { get; set; }

        [NameInMap("CoreNum")]
        [Validation(Required=false)]
        public int? CoreNum { get; set; }

        [NameInMap("CoreSingleStorage")]
        [Validation(Required=false)]
        public int? CoreSingleStorage { get; set; }

        [NameInMap("CoreSpec")]
        [Validation(Required=false)]
        public string CoreSpec { get; set; }

        [NameInMap("CreateMilliseconds")]
        [Validation(Required=false)]
        public long? CreateMilliseconds { get; set; }

        /// <summary>
        /// The storage capacity of the disk of a single log node. This parameter is returned only for multi-zone instances.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

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

        [NameInMap("EnableBlob")]
        [Validation(Required=false)]
        public bool? EnableBlob { get; set; }

        [NameInMap("EnableCdc")]
        [Validation(Required=false)]
        public bool? EnableCdc { get; set; }

        [NameInMap("EnableCompute")]
        [Validation(Required=false)]
        public bool? EnableCompute { get; set; }

        [NameInMap("EnableKms")]
        [Validation(Required=false)]
        public bool? EnableKms { get; set; }

        [NameInMap("EnableLTS")]
        [Validation(Required=false)]
        public bool? EnableLTS { get; set; }

        [NameInMap("EnableMLCtrl")]
        [Validation(Required=false)]
        public bool? EnableMLCtrl { get; set; }

        [NameInMap("EnableSSL")]
        [Validation(Required=false)]
        public bool? EnableSSL { get; set; }

        [NameInMap("EnableShs")]
        [Validation(Required=false)]
        public bool? EnableShs { get; set; }

        [NameInMap("EnableStream")]
        [Validation(Required=false)]
        public bool? EnableStream { get; set; }

        [NameInMap("EngineList")]
        [Validation(Required=false)]
        public List<GetLindormInstanceResponseBodyEngineList> EngineList { get; set; }
        public class GetLindormInstanceResponseBodyEngineList : TeaModel {
            [NameInMap("CoreCount")]
            [Validation(Required=false)]
            public string CoreCount { get; set; }

            [NameInMap("CpuCount")]
            [Validation(Required=false)]
            public string CpuCount { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("IsLastVersion")]
            [Validation(Required=false)]
            public bool? IsLastVersion { get; set; }

            [NameInMap("LatestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            [NameInMap("MemorySize")]
            [Validation(Required=false)]
            public string MemorySize { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public int? EngineType { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("ExpiredMilliseconds")]
        [Validation(Required=false)]
        public long? ExpiredMilliseconds { get; set; }

        [NameInMap("InstanceAlias")]
        [Validation(Required=false)]
        public string InstanceAlias { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        [NameInMap("InstanceStorage")]
        [Validation(Required=false)]
        public string InstanceStorage { get; set; }

        [NameInMap("LogDiskCategory")]
        [Validation(Required=false)]
        public string LogDiskCategory { get; set; }

        [NameInMap("LogNum")]
        [Validation(Required=false)]
        public int? LogNum { get; set; }

        [NameInMap("LogSingleStorage")]
        [Validation(Required=false)]
        public int? LogSingleStorage { get; set; }

        [NameInMap("LogSpec")]
        [Validation(Required=false)]
        public string LogSpec { get; set; }

        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        [NameInMap("MultiZoneCombination")]
        [Validation(Required=false)]
        public string MultiZoneCombination { get; set; }

        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// 400
        /// </summary>
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

        /// <summary>
        /// The type of the log nodes. This parameter is returned only for multi-zone instances.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The number of the log nodes. This parameter is returned only for multi-zone instances.
        /// </summary>
        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
