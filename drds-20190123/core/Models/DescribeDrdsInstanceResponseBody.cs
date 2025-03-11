// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the instance.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDrdsInstanceResponseBodyData Data { get; set; }
        public class DescribeDrdsInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The commodity code of the instance.</para>
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
            /// <para>drdssen1243as</para>
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
            /// <item><description><b>MASTER</b>: The instance is a primary instance.</description></item>
            /// <item><description><b>SLAVE</b>: The instance is a read-only instance to analyze complex queries</description></item>
            /// <item><description><b>SLAVE_FLOW</b>: The instance is a read-only instance for high-concurrency scenarios</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MASTER</para>
            /// </summary>
            [NameInMap("InstRole")]
            [Validation(Required=false)]
            public string InstRole { get; set; }

            /// <summary>
            /// <para>The instance series of the instance.</para>
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
            /// <para>The machine type of the instance. The value of this parameter is <b>ecs</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }

            /// <summary>
            /// <para>The ID of the primary instance.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the instance is a primary instance.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>drdssen1243as</para>
            /// </summary>
            [NameInMap("MasterInstanceId")]
            [Validation(Required=false)]
            public string MasterInstanceId { get; set; }

            /// <summary>
            /// <para>The MySQL version that is supported by the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MysqlVersion")]
            [Validation(Required=false)]
            public int? MysqlVersion { get; set; }

            /// <summary>
            /// <para>The network type of the instance. Valid values: CLASSIC and VPC.</para>
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
            /// <para>The version of .</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.3.*</para>
            /// </summary>
            [NameInMap("ProductVersion")]
            [Validation(Required=false)]
            public string ProductVersion { get; set; }

            /// <summary>
            /// <para>The details about each read-only instance that is associated with the instance.</para>
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
            /// <para>The ID of the region in which the instance is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the instance belongs. The value of this parameter can be null.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NULL</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The state of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUN</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the instance used for storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The type of the instance. Valid values: PRIVATE and PUBLIC. The value of PRIVATE indicates that the instance is a dedicated instance. The value of PUBLIC indicates that the instance is a shared instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRIVATE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The version of the instance. The value of this parameter is 0.</para>
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
            /// <para>Upgradeable</para>
            /// </summary>
            [NameInMap("VersionAction")]
            [Validation(Required=false)]
            public string VersionAction { get; set; }

            /// <summary>
            /// <para>The list of returned virtual IP addresses (VIPs).</para>
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
                    /// <para>The domain name that is mapped to the VIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>drdssen1243as.drds.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("Dns")]
                    [Validation(Required=false)]
                    public string Dns { get; set; }

                    /// <summary>
                    /// <para>The number of remaining days before the VIP expires.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ExpireDays")]
                    [Validation(Required=false)]
                    public long? ExpireDays { get; set; }

                    /// <summary>
                    /// <para>The ports that are opened on the VIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3306</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    [NameInMap("RemoveWeight")]
                    [Validation(Required=false)]
                    public bool? RemoveWeight { get; set; }

                    /// <summary>
                    /// <para>The type of the VIP. Valid values: intranet and internet.</para>
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
                    /// <para>vpc-bp**********</para>
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                    /// <summary>
                    /// <para>The ID of the vSwitch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-bp***********</para>
                    /// </summary>
                    [NameInMap("VswitchId")]
                    [Validation(Required=false)]
                    public string VswitchId { get; set; }

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
            /// <para>The ID of the zone in which the instance is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-e</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4F76641-BA45-4320-BE7C-9C62CFDAC9B2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
