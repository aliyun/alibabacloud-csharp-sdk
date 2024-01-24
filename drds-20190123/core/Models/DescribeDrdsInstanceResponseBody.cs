// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsInstanceResponseBody : TeaModel {
        /// <summary>
        /// The details of the instance.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDrdsInstanceResponseBodyData Data { get; set; }
        public class DescribeDrdsInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// The commodity code of the instance.
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// The timestamp that indicates when the instance is created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The description of the instance.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("DrdsInstanceId")]
            [Validation(Required=false)]
            public string DrdsInstanceId { get; set; }

            /// <summary>
            /// The timestamp that indicates when the instance expires.
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public long? ExpireDate { get; set; }

            /// <summary>
            /// The role of the instance. Valid values:
            /// 
            /// *   **MASTER**: The instance is a primary instance.
            /// *   **SLAVE**: The instance is a read-only instance to analyze complex queries
            /// *   **SLAVE_FLOW**: The instance is a read-only instance for high-concurrency scenarios
            /// </summary>
            [NameInMap("InstRole")]
            [Validation(Required=false)]
            public string InstRole { get; set; }

            /// <summary>
            /// The instance series of the instance.
            /// </summary>
            [NameInMap("InstanceSeries")]
            [Validation(Required=false)]
            public string InstanceSeries { get; set; }

            /// <summary>
            /// The specification of the instance.
            /// </summary>
            [NameInMap("InstanceSpec")]
            [Validation(Required=false)]
            public string InstanceSpec { get; set; }

            /// <summary>
            /// The tag of the instance. Valid values:
            /// 
            /// *   **NORMAL**: The instance is a standard instance.
            /// *   **HA**: The instance is a high-availability (HA) instance.
            /// *   **VPC**: The instance is a VPC-based instance.
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// The machine type of the instance. The value of this parameter is **ecs**.
            /// </summary>
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }

            /// <summary>
            /// The ID of the primary instance.
            /// 
            /// >  This parameter is returned only when the instance is a primary instance.
            /// </summary>
            [NameInMap("MasterInstanceId")]
            [Validation(Required=false)]
            public string MasterInstanceId { get; set; }

            /// <summary>
            /// The MySQL version that is supported by the instance.
            /// </summary>
            [NameInMap("MysqlVersion")]
            [Validation(Required=false)]
            public int? MysqlVersion { get; set; }

            /// <summary>
            /// The network type of the instance. Valid values: CLASSIC and VPC.
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// The ID of the purchased instance.
            /// </summary>
            [NameInMap("OrderInstanceId")]
            [Validation(Required=false)]
            public string OrderInstanceId { get; set; }

            /// <summary>
            /// The version of .
            /// </summary>
            [NameInMap("ProductVersion")]
            [Validation(Required=false)]
            public string ProductVersion { get; set; }

            /// <summary>
            /// The details about each read-only instance that is associated with the instance.
            /// </summary>
            [NameInMap("ReadOnlyDBInstanceIds")]
            [Validation(Required=false)]
            public DescribeDrdsInstanceResponseBodyDataReadOnlyDBInstanceIds ReadOnlyDBInstanceIds { get; set; }
            public class DescribeDrdsInstanceResponseBodyDataReadOnlyDBInstanceIds : TeaModel {
                [NameInMap("ReadOnlyDBInstanceId")]
                [Validation(Required=false)]
                public List<string> ReadOnlyDBInstanceId { get; set; }

            }

            /// <summary>
            /// The ID of the region in which the instance is created.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group to which the instance belongs. The value of this parameter can be null.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The state of the instance.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The type of the instance used for storage.
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// The type of the instance. Valid values: PRIVATE and PUBLIC. The value of PRIVATE indicates that the instance is a dedicated instance. The value of PUBLIC indicates that the instance is a shared instance.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The version of the instance. The value of this parameter is 0.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

            /// <summary>
            /// Indicates whether the version of the instance can be upgraded.
            /// </summary>
            [NameInMap("VersionAction")]
            [Validation(Required=false)]
            public string VersionAction { get; set; }

            /// <summary>
            /// The list of returned virtual IP addresses (VIPs).
            /// </summary>
            [NameInMap("Vips")]
            [Validation(Required=false)]
            public DescribeDrdsInstanceResponseBodyDataVips Vips { get; set; }
            public class DescribeDrdsInstanceResponseBodyDataVips : TeaModel {
                [NameInMap("Vip")]
                [Validation(Required=false)]
                public List<DescribeDrdsInstanceResponseBodyDataVipsVip> Vip { get; set; }
                public class DescribeDrdsInstanceResponseBodyDataVipsVip : TeaModel {
                    /// <summary>
                    /// The domain name that is mapped to the VIP.
                    /// </summary>
                    [NameInMap("Dns")]
                    [Validation(Required=false)]
                    public string Dns { get; set; }

                    /// <summary>
                    /// The number of remaining days before the VIP expires.
                    /// </summary>
                    [NameInMap("ExpireDays")]
                    [Validation(Required=false)]
                    public long? ExpireDays { get; set; }

                    /// <summary>
                    /// The ports that are opened on the VIP.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    /// <summary>
                    /// The type of the VIP. Valid values: intranet and internet.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// The ID of the VPC.
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                    /// <summary>
                    /// The ID of the vSwitch.
                    /// </summary>
                    [NameInMap("VswitchId")]
                    [Validation(Required=false)]
                    public string VswitchId { get; set; }

                }

            }

            /// <summary>
            /// The ID of the instance that is deployed in the VPC.
            /// </summary>
            [NameInMap("VpcCloudInstanceId")]
            [Validation(Required=false)]
            public string VpcCloudInstanceId { get; set; }

            /// <summary>
            /// The ID of the zone in which the instance is located.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
