// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLindormV2InstanceDetailsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>164901546557****</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-uf6664pqjawb87k36****</para>
        /// </summary>
        [NameInMap("ArbiterVSwitchId")]
        [Validation(Required=false)]
        public string ArbiterVSwitchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai-g</para>
        /// </summary>
        [NameInMap("ArbiterZoneId")]
        [Validation(Required=false)]
        public string ArbiterZoneId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>480</para>
        /// </summary>
        [NameInMap("CloudStorageSize")]
        [Validation(Required=false)]
        public long? CloudStorageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("ColdStorage")]
        [Validation(Required=false)]
        public int? ColdStorage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1627290664000</para>
        /// </summary>
        [NameInMap("CreateMilliseconds")]
        [Validation(Required=false)]
        public long? CreateMilliseconds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public string DeletionProtection { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PerformanceStorage</para>
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>80%</para>
        /// </summary>
        [NameInMap("DiskThreshold")]
        [Validation(Required=false)]
        public string DiskThreshold { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.0%</para>
        /// </summary>
        [NameInMap("DiskUsage")]
        [Validation(Required=false)]
        public string DiskUsage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableCompute")]
        [Validation(Required=false)]
        public bool? EnableCompute { get; set; }

        [NameInMap("EngineList")]
        [Validation(Required=false)]
        public List<GetLindormV2InstanceDetailsResponseBodyEngineList> EngineList { get; set; }
        public class GetLindormV2InstanceDetailsResponseBodyEngineList : TeaModel {
            [NameInMap("ConnectAddressList")]
            [Validation(Required=false)]
            public List<GetLindormV2InstanceDetailsResponseBodyEngineListConnectAddressList> ConnectAddressList { get; set; }
            public class GetLindormV2InstanceDetailsResponseBodyEngineListConnectAddressList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ld-mxj9asg***-proxy-lindorm-vpc.lindorm.aliyuncs.com:33060</para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>33060</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>INTRANET</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TABLE</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsLastVersion")]
            [Validation(Required=false)]
            public bool? IsLastVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2.2.19.2</para>
            /// </summary>
            [NameInMap("LatestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            [NameInMap("NodeGroup")]
            [Validation(Required=false)]
            public List<GetLindormV2InstanceDetailsResponseBodyEngineListNodeGroup> NodeGroup { get; set; }
            public class GetLindormV2InstanceDetailsResponseBodyEngineListNodeGroup : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>caculated</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("CpuCoreCount")]
                [Validation(Required=false)]
                public int? CpuCoreCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableAttachLocalDisk")]
                [Validation(Required=false)]
                public bool? EnableAttachLocalDisk { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("LocalDiskCapacity")]
                [Validation(Required=false)]
                public long? LocalDiskCapacity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("LocalDiskCategory")]
                [Validation(Required=false)]
                public string LocalDiskCategory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>64</para>
                /// </summary>
                [NameInMap("MemorySizeGiB")]
                [Validation(Required=false)]
                public int? MemorySizeGiB { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>lindorm.g.2xlarge</para>
                /// </summary>
                [NameInMap("NodeSpec")]
                [Validation(Required=false)]
                public string NodeSpec { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Quantity")]
                [Validation(Required=false)]
                public int? Quantity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>job_debug</para>
                /// </summary>
                [NameInMap("ResourceGroupName")]
                [Validation(Required=false)]
                public string ResourceGroupName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ecs.c6.large</para>
                /// </summary>
                [NameInMap("SpecId")]
                [Validation(Required=false)]
                public string SpecId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ACTIVATION</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2.2.3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1629993600000</para>
        /// </summary>
        [NameInMap("ExpiredMilliseconds")]
        [Validation(Required=false)]
        public long? ExpiredMilliseconds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("InitialRootPassword")]
        [Validation(Required=false)]
        public string InitialRootPassword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>lindorm-test</para>
        /// </summary>
        [NameInMap("InstanceAlias")]
        [Validation(Required=false)]
        public string InstanceAlias { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ACTIVATION</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>00:00Z</para>
        /// </summary>
        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-uf6fdqa7c0pipnqzq****</para>
        /// </summary>
        [NameInMap("PrimaryVSwitchId")]
        [Validation(Required=false)]
        public string PrimaryVSwitchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai-e</para>
        /// </summary>
        [NameInMap("PrimaryZoneId")]
        [Validation(Required=false)]
        public string PrimaryZoneId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1556DCB0-043A-4444-8BD9-CF4A68E7EE64</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-aek2i6weeb4nfii</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>lindorm_v2</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-2zec0kcn08cgdtr6****</para>
        /// </summary>
        [NameInMap("StandbyVSwitchId")]
        [Validation(Required=false)]
        public string StandbyVSwitchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai-f</para>
        /// </summary>
        [NameInMap("StandbyZoneId")]
        [Validation(Required=false)]
        public string StandbyZoneId { get; set; }

        [NameInMap("StorageUsage")]
        [Validation(Required=false)]
        public GetLindormV2InstanceDetailsResponseBodyStorageUsage StorageUsage { get; set; }
        public class GetLindormV2InstanceDetailsResponseBodyStorageUsage : TeaModel {
            [NameInMap("CapacityByDiskCategory")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> CapacityByDiskCategory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("EngineUsage")]
            [Validation(Required=false)]
            public Dictionary<string, object> EngineUsage { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-bp1xxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-bp1xxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

        [NameInMap("WhiteIpList")]
        [Validation(Required=false)]
        public List<GetLindormV2InstanceDetailsResponseBodyWhiteIpList> WhiteIpList { get; set; }
        public class GetLindormV2InstanceDetailsResponseBodyWhiteIpList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>swhy</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[\&quot;10.2.0.0/18\&quot;, \&quot;10.0.0.0/24\&quot;, \&quot;119.23.188.139/32\&quot;]</para>
            /// </summary>
            [NameInMap("IpList")]
            [Validation(Required=false)]
            public string IpList { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ZoneEngineInfoMap</para>
        /// </summary>
        [NameInMap("ZoneEngineInfoMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> ZoneEngineInfoMap { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
