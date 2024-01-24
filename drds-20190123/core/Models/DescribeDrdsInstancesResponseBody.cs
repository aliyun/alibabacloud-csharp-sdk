// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsInstancesResponseBody : TeaModel {
        /// <summary>
        /// The list of returned instances.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeDrdsInstancesResponseBodyInstances Instances { get; set; }
        public class DescribeDrdsInstancesResponseBodyInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<DescribeDrdsInstancesResponseBodyInstancesInstance> Instance { get; set; }
            public class DescribeDrdsInstancesResponseBodyInstancesInstance : TeaModel {
                /// <summary>
                /// The commodity code of the service.
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
                /// *   MASTER: The instance is a primary instance.
                /// *   SLAVE: The instance is a read-only instance to analyze complex queries.
                /// *   SLAVE_FLOW: The instance is a read-only instance for high-concurrency scenarios.
                /// </summary>
                [NameInMap("InstRole")]
                [Validation(Required=false)]
                public string InstRole { get; set; }

                /// <summary>
                /// The instance series.
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
                /// The machine type of the instance. Valid value: ecs.
                /// </summary>
                [NameInMap("MachineType")]
                [Validation(Required=false)]
                public string MachineType { get; set; }

                /// <summary>
                /// The ID of the primary instance.
                /// </summary>
                [NameInMap("MasterInstanceId")]
                [Validation(Required=false)]
                public string MasterInstanceId { get; set; }

                /// <summary>
                /// The network type of the instance. Valid values:
                /// 
                /// *   **CLASSIC**
                /// *   **VPC**
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
                /// The version of the service.
                /// </summary>
                [NameInMap("ProductVersion")]
                [Validation(Required=false)]
                public string ProductVersion { get; set; }

                /// <summary>
                /// The IDs of read-only instances that are associated with the instance.
                /// </summary>
                [NameInMap("ReadOnlyDBInstanceIds")]
                [Validation(Required=false)]
                public DescribeDrdsInstancesResponseBodyInstancesInstanceReadOnlyDBInstanceIds ReadOnlyDBInstanceIds { get; set; }
                public class DescribeDrdsInstancesResponseBodyInstancesInstanceReadOnlyDBInstanceIds : TeaModel {
                    [NameInMap("ReadOnlyDBInstanceId")]
                    [Validation(Required=false)]
                    public List<string> ReadOnlyDBInstanceId { get; set; }

                }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group to which the instance belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The status of the instance.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The type of the instance. Valid values:
                /// 
                /// *   **PUBLIC**: The returned instance is a shared instance.
                /// *   **PRIVATE**: The returned instance is a dedicated instance.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The version of the instance.
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
                public DescribeDrdsInstancesResponseBodyInstancesInstanceVips Vips { get; set; }
                public class DescribeDrdsInstancesResponseBodyInstancesInstanceVips : TeaModel {
                    [NameInMap("Vip")]
                    [Validation(Required=false)]
                    public List<DescribeDrdsInstancesResponseBodyInstancesInstanceVipsVip> Vip { get; set; }
                    public class DescribeDrdsInstancesResponseBodyInstancesInstanceVipsVip : TeaModel {
                        /// <summary>
                        /// The virtual IP address.
                        /// </summary>
                        [NameInMap("IP")]
                        [Validation(Required=false)]
                        public string IP { get; set; }

                        /// <summary>
                        /// The ports that are opened on the VIP.
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public string Port { get; set; }

                        /// <summary>
                        /// The type of the VIP. Valid values:
                        /// 
                        /// *   intranet: a private IP address
                        /// *   internet: a public IP address
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

                        /// <summary>
                        /// The domain name that is mapped to the VIP.
                        /// </summary>
                        [NameInMap("dns")]
                        [Validation(Required=false)]
                        public string Dns { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the instance that is deployed in the VPC.
                /// </summary>
                [NameInMap("VpcCloudInstanceId")]
                [Validation(Required=false)]
                public string VpcCloudInstanceId { get; set; }

                /// <summary>
                /// The ID of the VPC to which the instance belongs.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The ID of the zone in which the resource is located.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// The edition of the instance. Valid values:
                /// 
                /// *   **starter**: Starter Edition
                /// *   **enterprise**: Enterprise Edition
                /// *   **standard**: Standard Edition
                /// </summary>
                [NameInMap("series")]
                [Validation(Required=false)]
                public string Series { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of instances returned on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of instances returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
