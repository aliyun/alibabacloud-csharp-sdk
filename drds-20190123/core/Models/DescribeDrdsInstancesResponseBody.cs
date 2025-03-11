// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of returned instances.</para>
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
                /// <para>The commodity code of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>drdsPost</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>The timestamp that indicates when the instance is created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1568620311000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>drds_test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>drdssen12****</para>
                /// </summary>
                [NameInMap("DrdsInstanceId")]
                [Validation(Required=false)]
                public string DrdsInstanceId { get; set; }

                /// <summary>
                /// <para>The timestamp that indicates when the instance expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4724323200000</para>
                /// </summary>
                [NameInMap("ExpireDate")]
                [Validation(Required=false)]
                public long? ExpireDate { get; set; }

                /// <summary>
                /// <para>The role of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>MASTER: The instance is a primary instance.</description></item>
                /// <item><description>SLAVE: The instance is a read-only instance to analyze complex queries.</description></item>
                /// <item><description>SLAVE_FLOW: The instance is a read-only instance for high-concurrency scenarios.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>MASTER</para>
                /// </summary>
                [NameInMap("InstRole")]
                [Validation(Required=false)]
                public string InstRole { get; set; }

                /// <summary>
                /// <para>The instance series.</para>
                /// 
                /// <b>Example:</b>
                /// <para>drds.sn2.4c16g</para>
                /// </summary>
                [NameInMap("InstanceSeries")]
                [Validation(Required=false)]
                public string InstanceSeries { get; set; }

                /// <summary>
                /// <para>The specification of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>drds.sn2.4c16g.8C32G</para>
                /// </summary>
                [NameInMap("InstanceSpec")]
                [Validation(Required=false)]
                public string InstanceSpec { get; set; }

                /// <summary>
                /// <para>The tag of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NORMAL</b>: The instance is a standard instance.</description></item>
                /// <item><description><b>HA</b>: The instance is a high-availability (HA) instance.</description></item>
                /// <item><description><b>VPC</b>: The instance is a VPC-based instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The machine type of the instance. Valid value: ecs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("MachineType")]
                [Validation(Required=false)]
                public string MachineType { get; set; }

                /// <summary>
                /// <para>The ID of the primary instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>drdssen12****</para>
                /// </summary>
                [NameInMap("MasterInstanceId")]
                [Validation(Required=false)]
                public string MasterInstanceId { get; set; }

                /// <summary>
                /// <para>The network type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>CLASSIC</b></description></item>
                /// <item><description><b>VPC</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CLASSIC</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The ID of the purchased instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>drdssen12****</para>
                /// </summary>
                [NameInMap("OrderInstanceId")]
                [Validation(Required=false)]
                public string OrderInstanceId { get; set; }

                /// <summary>
                /// <para>The version of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>V1</para>
                /// </summary>
                [NameInMap("ProductVersion")]
                [Validation(Required=false)]
                public string ProductVersion { get; set; }

                /// <summary>
                /// <para>The IDs of read-only instances that are associated with the instance.</para>
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
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-e</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aek2ljh3ye4****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The status of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUN</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PUBLIC</b>: The returned instance is a shared instance.</description></item>
                /// <item><description><b>PRIVATE</b>: The returned instance is a dedicated instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PRIVATE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The version of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

                /// <summary>
                /// <para>Indicates whether the version of the instance can be upgraded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Upgradable</para>
                /// </summary>
                [NameInMap("VersionAction")]
                [Validation(Required=false)]
                public string VersionAction { get; set; }

                /// <summary>
                /// <para>The list of returned virtual IP addresses (VIPs).</para>
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
                        /// <para>The virtual IP address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10.23.<em><b>.</b></em></para>
                        /// </summary>
                        [NameInMap("IP")]
                        [Validation(Required=false)]
                        public string IP { get; set; }

                        /// <summary>
                        /// <para>The ports that are opened on the VIP.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3306</para>
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public string Port { get; set; }

                        /// <summary>
                        /// <para>The type of the VIP. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>intranet: a private IP address</description></item>
                        /// <item><description>internet: a public IP address</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>intranet</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The ID of the VPC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-bpxxxxxxxxxxxy</para>
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        /// <summary>
                        /// <para>The ID of the vSwitch.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-bpxxxxxxxxxxxxx96</para>
                        /// </summary>
                        [NameInMap("VswitchId")]
                        [Validation(Required=false)]
                        public string VswitchId { get; set; }

                        /// <summary>
                        /// <para>The domain name that is mapped to the VIP.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>drdssen1243as.drds.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("dns")]
                        [Validation(Required=false)]
                        public string Dns { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the instance that is deployed in the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>drdssen12****</para>
                /// </summary>
                [NameInMap("VpcCloudInstanceId")]
                [Validation(Required=false)]
                public string VpcCloudInstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the VPC to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp**********</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The ID of the zone in which the resource is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bpxxxxxxxxxxxxx96</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// <para>The edition of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>starter</b>: Starter Edition</description></item>
                /// <item><description><b>enterprise</b>: Enterprise Edition</description></item>
                /// <item><description><b>standard</b>: Standard Edition</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enterprise</para>
                /// </summary>
                [NameInMap("series")]
                [Validation(Required=false)]
                public string Series { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of instances returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8734773E-7B21-4A22-9106-CBD245F8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of instances returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
