// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeDBClusterAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the cluster.</para>
        /// </summary>
        [NameInMap("DBCluster")]
        [Validation(Required=false)]
        public DescribeDBClusterAttributeResponseBodyDBCluster DBCluster { get; set; }
        public class DescribeDBClusterAttributeResponseBodyDBCluster : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>140692647406****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>The scheduled restart time. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in Coordinated Universal Time (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-06T12:00:00Z</para>
            /// </summary>
            [NameInMap("AppointmentRestartTime")]
            [Validation(Required=false)]
            public string AppointmentRestartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;MajorVersion&quot;:&quot;MinorVersion&quot;}</para>
            /// </summary>
            [NameInMap("AvailableUpgradeMajorVersion")]
            [Validation(Required=false)]
            public Dictionary<string, object> AvailableUpgradeMajorVersion { get; set; }

            /// <summary>
            /// <para>The site ID. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>26842</b>: the China site (aliyun.com)</description></item>
            /// <item><description><b>26888</b>: the international site (alibabacloud.com)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>26842</para>
            /// </summary>
            [NameInMap("Bid")]
            [Validation(Required=false)]
            public string Bid { get; set; }

            /// <summary>
            /// <para>The edition of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Basic</b>: Single-replica Edition</description></item>
            /// <item><description><b>HighAvailability</b>: Double-replica Edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HighAvailability</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The commodity code of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>clickhouse_go_public_cn</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The VPC endpoint of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-bp1qx68m06981****.ads.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            /// <summary>
            /// <para>The version of the ApsaraDB for ClickHouse console that is used to manage the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>v1</b></description></item>
            /// <item><description><b>v2</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("ControlVersion")]
            [Validation(Required=false)]
            public string ControlVersion { get; set; }

            /// <summary>
            /// <para>The time when the cluster was created. The value is in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-13T11:33:11Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-bp108z124a8o7****</para>
            /// </summary>
            [NameInMap("DBClusterDescription")]
            [Validation(Required=false)]
            public string DBClusterDescription { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-bp108z124a8o7****</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The network type of the cluster. Only VPC is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc</para>
            /// </summary>
            [NameInMap("DBClusterNetworkType")]
            [Validation(Required=false)]
            public string DBClusterNetworkType { get; set; }

            /// <summary>
            /// <para>The cluster state. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Preparing</b>: The cluster is being prepared.</description></item>
            /// <item><description><b>Creating</b>: The cluster is being created.</description></item>
            /// <item><description><b>Running</b>: The cluster is running.</description></item>
            /// <item><description><b>Deleting</b>: The cluster is being deleted.</description></item>
            /// <item><description><b>SCALING_OUT</b>: The storage capacity of the cluster is being expanded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DBClusterStatus")]
            [Validation(Required=false)]
            public string DBClusterStatus { get; set; }

            /// <summary>
            /// <para>The type of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Common</b>: a common cluster</description></item>
            /// <item><description><b>Readonly</b>: a read-only cluster</description></item>
            /// <item><description><b>Guard</b>: a disaster recovery cluster</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Common</para>
            /// </summary>
            [NameInMap("DBClusterType")]
            [Validation(Required=false)]
            public string DBClusterType { get; set; }

            /// <summary>
            /// <para>The specifications of the cluster.</para>
            /// <list type="bullet">
            /// <item><description><para>Valid values when the cluster is of Single-replica Edition:</para>
            /// <list type="bullet">
            /// <item><description><b>S4-NEW</b></description></item>
            /// <item><description><b>S8</b></description></item>
            /// <item><description><b>S16</b></description></item>
            /// <item><description><b>S32</b></description></item>
            /// <item><description><b>S64</b></description></item>
            /// <item><description><b>S104</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Valid values when the cluster is of Double-replica Edition:</para>
            /// <list type="bullet">
            /// <item><description><b>C4-NEW</b></description></item>
            /// <item><description><b>C8</b></description></item>
            /// <item><description><b>C16</b></description></item>
            /// <item><description><b>C32</b></description></item>
            /// <item><description><b>C64</b></description></item>
            /// <item><description><b>C104</b></description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>C8</para>
            /// </summary>
            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }

            /// <summary>
            /// <para>The number of nodes.</para>
            /// <list type="bullet">
            /// <item><description>Valid values when the cluster is of Single-replica Edition: 1 to 48.</description></item>
            /// <item><description>Valid values when the cluster is of Double-replica Edition: 1 to 24.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DBNodeCount")]
            [Validation(Required=false)]
            public long? DBNodeCount { get; set; }

            /// <summary>
            /// <para>The storage capacity of a single node of the cluster. Unit: GB.</para>
            /// <para>Valid values: 100 to 32000.</para>
            /// <remarks>
            /// <para> This value is a multiple of 100.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DBNodeStorage")]
            [Validation(Required=false)]
            public long? DBNodeStorage { get; set; }

            /// <summary>
            /// <para>The Key Management Service (KMS) key that is used to encrypt data.</para>
            /// <remarks>
            /// <para> If the value of the EncryptionType parameter is off, an empty string is returned for this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>685f416f-87c9-4554-8d3a-75b6ce25****</para>
            /// </summary>
            [NameInMap("EncryptionKey")]
            [Validation(Required=false)]
            public string EncryptionKey { get; set; }

            /// <summary>
            /// <para>The encryption type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CloudDisk</b>: Disk encryption is enabled.</description></item>
            /// <item><description><b>off</b>: Data is not encrypted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CloudDisk</para>
            /// </summary>
            [NameInMap("EncryptionType")]
            [Validation(Required=false)]
            public string EncryptionType { get; set; }

            /// <summary>
            /// <para>The type of the database engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ClickHouse</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The latest minor version to which the cluster can be updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.34.0</para>
            /// </summary>
            [NameInMap("EngineLatestMinorVersion")]
            [Validation(Required=false)]
            public string EngineLatestMinorVersion { get; set; }

            /// <summary>
            /// <para>The current minor version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.6.0</para>
            /// </summary>
            [NameInMap("EngineMinorVersion")]
            [Validation(Required=false)]
            public string EngineMinorVersion { get; set; }

            /// <summary>
            /// <para>The engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21.8.10.19</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The time when the cluster expired. The time is in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// <remarks>
            /// <para> Pay-as-you-go clusters never expire. If the cluster is a pay-as-you-go cluster, an empty string is returned for this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-11T16:00:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The extended storage space. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("ExtStorageSize")]
            [Validation(Required=false)]
            public int? ExtStorageSize { get; set; }

            /// <summary>
            /// <para>The extended storage type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CloudESSD</b>: The cluster uses an enhanced SSD (ESSD) of performance level (PL) 1.</description></item>
            /// <item><description><b>CloudESSD_PL2</b>: The cluster uses an ESSD of PL 2.</description></item>
            /// <item><description><b>CloudESSD_PL3</b>: The cluster uses an ESSD of PL 3.</description></item>
            /// <item><description><b>CloudEfficiency</b>: The cluster uses an ultra disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CloudESSD</para>
            /// </summary>
            [NameInMap("ExtStorageType")]
            [Validation(Required=false)]
            public string ExtStorageType { get; set; }

            /// <summary>
            /// <para>Indicates whether the cluster has expired. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsExpired")]
            [Validation(Required=false)]
            public string IsExpired { get; set; }

            /// <summary>
            /// <para>The lock mode of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Unlock</b>: The cluster is not locked.</description></item>
            /// <item><description><b>ManualLock</b>: The cluster is manually locked.</description></item>
            /// <item><description><b>LockByExpiration</b>: The cluster is automatically locked due to cluster expiration.</description></item>
            /// <item><description><b>LockByRestoration</b>: The cluster is automatically locked because the cluster is about to be rolled back.</description></item>
            /// <item><description><b>LockByDiskQuota</b>: The cluster is automatically locked because the disk space is exhausted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Unlock</para>
            /// </summary>
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// <para>The cause why the cluster was locked.</para>
            /// <remarks>
            /// <para> If the value of the LockMode parameter is Unlock, an empty string is returned for this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>DISK_FULL</para>
            /// </summary>
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            /// <summary>
            /// <para>The update type. If the value of the parameter is <b>false</b>, it indicates a manual update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("MaintainAutoType")]
            [Validation(Required=false)]
            public bool? MaintainAutoType { get; set; }

            /// <summary>
            /// <para>The maintenance window of the cluster. The value is in the HH:mmZ-HH:mmZ format. The time is displayed in UTC.</para>
            /// <para>For example, if you set the maintenance window to 00:00Z-01:00Z, the cluster can be maintained from 08:00 (UTC+8) to 09:00 (UTC+8).</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00Z-01:00Z</para>
            /// </summary>
            [NameInMap("MaintainTime")]
            [Validation(Required=false)]
            public string MaintainTime { get; set; }

            /// <summary>
            /// <para>The billing method of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Postpaid</b>: indicates the pay-as-you-go billing method.</description></item>
            /// <item><description><b>Prepaid</b>: indicates the subscription billing method.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Prepaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The HTTP port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8123</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The public endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-bp1199ya710s7****.public.clickhouse.ads.aliyuncs.com</para>
            /// </summary>
            [NameInMap("PublicConnectionString")]
            [Validation(Required=false)]
            public string PublicConnectionString { get; set; }

            /// <summary>
            /// <para>The IP address that is used to connect to the cluster over the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121.40.xx.xx</para>
            /// </summary>
            [NameInMap("PublicIpAddr")]
            [Validation(Required=false)]
            public string PublicIpAddr { get; set; }

            /// <summary>
            /// <para>The TCP port number in the public endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("PublicPort")]
            [Validation(Required=false)]
            public string PublicPort { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmyf65je6****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The status of the data migration task.</para>
            /// </summary>
            [NameInMap("ScaleOutStatus")]
            [Validation(Required=false)]
            public DescribeDBClusterAttributeResponseBodyDBClusterScaleOutStatus ScaleOutStatus { get; set; }
            public class DescribeDBClusterAttributeResponseBodyDBClusterScaleOutStatus : TeaModel {
                /// <summary>
                /// <para>The progress of the data migration task in percentage.</para>
                /// <remarks>
                /// <para> This parameter is returned only when the cluster is in the SCALING_OUT state.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <para>The progress of the data migration task. This value is displayed in the following format: Data volume that has been migrated/Total data volume.</para>
                /// <remarks>
                /// <para> This parameter is returned only when the cluster is in the SCALING_OUT state.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0MB/60469MB</para>
                /// </summary>
                [NameInMap("Ratio")]
                [Validation(Required=false)]
                public string Ratio { get; set; }

            }

            /// <summary>
            /// <para>The storage type of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CloudESSD</b>: The cluster uses an enhanced SSD (ESSD) of performance level (PL) 1.</description></item>
            /// <item><description><b>CloudESSD_PL2</b>: The cluster uses an ESSD of PL 2.</description></item>
            /// <item><description><b>CloudESSD_PL3</b>: The cluster uses an ESSD of PL 3.</description></item>
            /// <item><description><b>CloudEfficiency</b>: The cluster uses an ultra disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CloudESSD</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>Indicates whether data backup is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Data backup is supported.</description></item>
            /// <item><description><b>2</b>: Data backup is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SupportBackup")]
            [Validation(Required=false)]
            public int? SupportBackup { get; set; }

            /// <summary>
            /// <para>Indicates whether HTTPS ports are supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SupportHttpsPort")]
            [Validation(Required=false)]
            public bool? SupportHttpsPort { get; set; }

            /// <summary>
            /// <para>Indicates whether the cluster supports a MySQL port. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: A MySQL port is supported.</description></item>
            /// <item><description><b>false</b>: A MySQL port is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SupportMysqlPort")]
            [Validation(Required=false)]
            public bool? SupportMysqlPort { get; set; }

            /// <summary>
            /// <para>Indicates whether tiered storage of hot data and cold data is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Tiered storage of hot data and cold data is supported.</description></item>
            /// <item><description><b>2</b>: Tiered storage of hot data and cold data is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SupportOss")]
            [Validation(Required=false)]
            public int? SupportOss { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public DescribeDBClusterAttributeResponseBodyDBClusterTags Tags { get; set; }
            public class DescribeDBClusterAttributeResponseBodyDBClusterTags : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<DescribeDBClusterAttributeResponseBodyDBClusterTagsTag> Tag { get; set; }
                public class DescribeDBClusterAttributeResponseBodyDBClusterTagsTag : TeaModel {
                    /// <summary>
                    /// <para>The tag name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>department</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>it</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1n874li1t5y57wi****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the VPC in which the cluster is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp10tr8k9qasioaty****</para>
            /// </summary>
            [NameInMap("VpcCloudInstanceId")]
            [Validation(Required=false)]
            public string VpcCloudInstanceId { get; set; }

            /// <summary>
            /// <para>The virtual private cloud (VPC) ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp10tr8k9qasioaty****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The IP address that is used to connect to the cluster over the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.xx.xx</para>
            /// </summary>
            [NameInMap("VpcIpAddr")]
            [Validation(Required=false)]
            public string VpcIpAddr { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            /// <summary>
            /// <para>The list of vSwitch IDs in multi-zone clusters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-f: vsw-zm0n42d5vvuo****</para>
            /// </summary>
            [NameInMap("ZoneIdVswitchMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> ZoneIdVswitchMap { get; set; }

            /// <summary>
            /// <para>The ZooKeeper specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4 Core 8 GB</para>
            /// </summary>
            [NameInMap("ZookeeperClass")]
            [Validation(Required=false)]
            public string ZookeeperClass { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05321590-BB65-4720-8CB6-8218E041CDD0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
