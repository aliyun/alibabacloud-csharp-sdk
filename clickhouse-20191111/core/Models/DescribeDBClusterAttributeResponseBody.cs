// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeDBClusterAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the cluster.</para>
        /// </summary>
        [NameInMap("DBCluster")]
        [Validation(Required=false)]
        public DescribeDBClusterAttributeResponseBodyDBCluster DBCluster { get; set; }
        public class DescribeDBClusterAttributeResponseBodyDBCluster : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>140692647406****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>Specifies whether to stop write operations during a primary/secondary switchover. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Write operations are stopped for the instance during the switchover.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Write operations are not stopped for the instance during the switchover.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AppointmentElectZookeeperDisableWrite")]
            [Validation(Required=false)]
            public bool? AppointmentElectZookeeperDisableWrite { get; set; }

            /// <summary>
            /// <para>The scheduled time for a primary/secondary switchover. The time is in the <c>YYYY-MM-DDThh:mm:ssZ</c> format and is in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-06T12:00:00Z</para>
            /// </summary>
            [NameInMap("AppointmentElectZookeeperTime")]
            [Validation(Required=false)]
            public string AppointmentElectZookeeperTime { get; set; }

            /// <summary>
            /// <para>A list of nodes that are scheduled for a restart.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ck-k1a976p3n********-<b><b>-clickhouse-s-0-r-0,ck-k1a976p3n</b></b><b><b>-</b></b>-clickhouse-s-0-r-1</para>
            /// </summary>
            [NameInMap("AppointmentRestartNodeList")]
            [Validation(Required=false)]
            public string AppointmentRestartNodeList { get; set; }

            /// <summary>
            /// <para>The scheduled time to restart specific nodes. The time is in the <c>YYYY-MM-DDThh:mm:ssZ</c> format and is in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-06T12:00:00Z</para>
            /// </summary>
            [NameInMap("AppointmentRestartNodeTime")]
            [Validation(Required=false)]
            public string AppointmentRestartNodeTime { get; set; }

            /// <summary>
            /// <para>The scheduled restart time. The time is in the <c>YYYY-MM-DDThh:mm:ssZ</c> format and is in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-06T12:00:00Z</para>
            /// </summary>
            [NameInMap("AppointmentRestartTime")]
            [Validation(Required=false)]
            public string AppointmentRestartTime { get; set; }

            /// <summary>
            /// <para>The available major versions to which the cluster can be upgraded, and their latest minor versions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;MajorVersion&quot;:&quot;MinorVersion&quot;}</para>
            /// </summary>
            [NameInMap("AvailableUpgradeMajorVersion")]
            [Validation(Required=false)]
            public Dictionary<string, object> AvailableUpgradeMajorVersion { get; set; }

            /// <summary>
            /// <para>The site ID. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>26842</c>: China site (aliyun.com).</para>
            /// </description></item>
            /// <item><description><para><c>26888</c>: international site (alibabacloud.com).</para>
            /// </description></item>
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
            /// <item><description><para><c>Basic</c>: single-replica edition.</para>
            /// </description></item>
            /// <item><description><para><c>HighAvailability</c>: dual-replica edition.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HighAvailability</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The commodity code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>clickhouse_go_public_cn</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The VPC endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-bp1qx68m06981****.ads.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            /// <summary>
            /// <para>The version of the backend management system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>v1</c></para>
            /// </description></item>
            /// <item><description><para><c>v2</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("ControlVersion")]
            [Validation(Required=false)]
            public string ControlVersion { get; set; }

            /// <summary>
            /// <para>The creation time of the cluster, in <c>yyyy-MM-ddTHH:mm:ssZ</c> format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-13T11:33:11Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The cluster description.</para>
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
            /// <para>The network type. Only VPC is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc</para>
            /// </summary>
            [NameInMap("DBClusterNetworkType")]
            [Validation(Required=false)]
            public string DBClusterNetworkType { get; set; }

            /// <summary>
            /// <para>The cluster status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Preparing</c>: The cluster is being prepared.</para>
            /// </description></item>
            /// <item><description><para><c>Creating</c>: The cluster is being created.</para>
            /// </description></item>
            /// <item><description><para><c>Running</c>: The cluster is running.</para>
            /// </description></item>
            /// <item><description><para><c>Deleting</c>: The cluster is being deleted.</para>
            /// </description></item>
            /// <item><description><para><c>SCALING_OUT</c>: The cluster is being scaled out.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DBClusterStatus")]
            [Validation(Required=false)]
            public string DBClusterStatus { get; set; }

            /// <summary>
            /// <para>The cluster type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Common</c>: a standard cluster.</para>
            /// </description></item>
            /// <item><description><para><c>Readonly</c>: a read-only cluster.</para>
            /// </description></item>
            /// <item><description><para><c>Guard</c>: a disaster recovery cluster.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Common</para>
            /// </summary>
            [NameInMap("DBClusterType")]
            [Validation(Required=false)]
            public string DBClusterType { get; set; }

            /// <summary>
            /// <para>The instance type of the cluster nodes.</para>
            /// <list type="bullet">
            /// <item><description><para>Valid values for a single-replica edition:</para>
            /// <list type="bullet">
            /// <item><description><para><c>S4-NEW</c></para>
            /// </description></item>
            /// <item><description><para><c>S8</c></para>
            /// </description></item>
            /// <item><description><para><c>S16</c></para>
            /// </description></item>
            /// <item><description><para><c>S32</c></para>
            /// </description></item>
            /// <item><description><para><c>S64</c></para>
            /// </description></item>
            /// <item><description><para><c>S104</c></para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Valid values for a dual-replica edition:</para>
            /// <list type="bullet">
            /// <item><description><para><c>C4-NEW</c></para>
            /// </description></item>
            /// <item><description><para><c>C8</c></para>
            /// </description></item>
            /// <item><description><para><c>C16</c></para>
            /// </description></item>
            /// <item><description><para><c>C32</c></para>
            /// </description></item>
            /// <item><description><para><c>C64</c></para>
            /// </description></item>
            /// <item><description><para><c>C104</c></para>
            /// </description></item>
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
            /// <para>The number of nodes in the cluster.</para>
            /// <list type="bullet">
            /// <item><description><para>For a single-replica edition, the value range is 1 to 48.</para>
            /// </description></item>
            /// <item><description><para>For a dual-replica edition, the value range is 1 to 24.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DBNodeCount")]
            [Validation(Required=false)]
            public long? DBNodeCount { get; set; }

            /// <summary>
            /// <para>The storage capacity per node, in GB.</para>
            /// <para>The value can range from 100 to 32000.</para>
            /// <remarks>
            /// <para>The value must be a multiple of 100.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DBNodeStorage")]
            [Validation(Required=false)]
            public long? DBNodeStorage { get; set; }

            /// <summary>
            /// <para>The Key Management Service (KMS) key ID.</para>
            /// <remarks>
            /// <para>This parameter is empty if <c>EncryptionType</c> is set to <c>off</c>.</para>
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
            /// <item><description><para><c>CloudDisk</c>: disk encryption.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: Encryption is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CloudDisk</para>
            /// </summary>
            [NameInMap("EncryptionType")]
            [Validation(Required=false)]
            public string EncryptionType { get; set; }

            /// <summary>
            /// <para>The database engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ClickHouse</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The latest minor version to which the cluster can be upgraded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.34.0</para>
            /// </summary>
            [NameInMap("EngineLatestMinorVersion")]
            [Validation(Required=false)]
            public string EngineLatestMinorVersion { get; set; }

            /// <summary>
            /// <para>The engine\&quot;s current minor version.</para>
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
            /// <para>The expiration time of the cluster, in <c>yyyy-MM-ddTHH:mm:ssZ</c> format (UTC).</para>
            /// <remarks>
            /// <para>This parameter is empty for pay-as-you-go clusters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-11T16:00:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The extended storage capacity, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("ExtStorageSize")]
            [Validation(Required=false)]
            public int? ExtStorageSize { get; set; }

            /// <summary>
            /// <para>The extended storage type. Valid values:</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description><para><c>CloudESSD_PL0</c>: ESSD PL0 disk.</para>
            /// </description></item>
            /// <item><description><para><c>CloudESSD</c>: ESSD PL1 disk.</para>
            /// </description></item>
            /// <item><description><para><c>CloudESSD_PL2</c>: ESSD PL2 disk.</para>
            /// </description></item>
            /// <item><description><para><c>CloudESSD_PL3</c>: ESSD PL3 disk.</para>
            /// </description></item>
            /// <item><description><para><c>CloudEfficiency</c>: Ultra disk.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CloudESSD</para>
            /// </summary>
            [NameInMap("ExtStorageType")]
            [Validation(Required=false)]
            public string ExtStorageType { get; set; }

            /// <summary>
            /// <para>Whether the cluster has expired. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: The cluster has expired.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: The cluster has not expired.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsExpired")]
            [Validation(Required=false)]
            public string IsExpired { get; set; }

            /// <summary>
            /// <para>The type of the load balancer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>clb</para>
            /// </summary>
            [NameInMap("LbKind")]
            [Validation(Required=false)]
            public string LbKind { get; set; }

            /// <summary>
            /// <para>The lock mode of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Unlock</c>: The cluster is not locked.</para>
            /// </description></item>
            /// <item><description><para><c>ManualLock</c>: The cluster is manually locked.</para>
            /// </description></item>
            /// <item><description><para><c>LockByExpiration</c>: The cluster is automatically locked upon expiration.</para>
            /// </description></item>
            /// <item><description><para><c>LockByRestoration</c>: The cluster is automatically locked before a rollback.</para>
            /// </description></item>
            /// <item><description><para><c>LockByDiskQuota</c>: The cluster is automatically locked because the storage is full.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Unlock</para>
            /// </summary>
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// <para>The reason the cluster was locked.</para>
            /// <remarks>
            /// <para>This parameter is empty if <c>LockMode</c> is set to <c>Unlock</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>DISK_FULL</para>
            /// </summary>
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            /// <summary>
            /// <para>The upgrade method. A value of <c>false</c> indicates that upgrades must be performed manually.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("MaintainAutoType")]
            [Validation(Required=false)]
            public bool? MaintainAutoType { get; set; }

            /// <summary>
            /// <para>The maintenance window of the cluster. The time is in the <c>HH:mmZ-HH:mmZ</c> format and is in UTC.</para>
            /// <para>For example, <c>00:00Z-01:00Z</c> indicates that the maintenance window is from 00:00 to 01:00 (UTC), which corresponds to 08:00 to 09:00 in Beijing time (UTC+8).</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00Z-01:00Z</para>
            /// </summary>
            [NameInMap("MaintainTime")]
            [Validation(Required=false)]
            public string MaintainTime { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Postpaid</c>: pay-as-you-go.</para>
            /// </description></item>
            /// <item><description><para><c>Prepaid</c>: subscription.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Prepaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The HTTP port.</para>
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
            /// <para>The IP address of the public endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121.40.xx.xx</para>
            /// </summary>
            [NameInMap("PublicIpAddr")]
            [Validation(Required=false)]
            public string PublicIpAddr { get; set; }

            /// <summary>
            /// <para>The public TCP port.</para>
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
            /// <para>The data migration status.</para>
            /// </summary>
            [NameInMap("ScaleOutStatus")]
            [Validation(Required=false)]
            public DescribeDBClusterAttributeResponseBodyDBClusterScaleOutStatus ScaleOutStatus { get; set; }
            public class DescribeDBClusterAttributeResponseBodyDBClusterScaleOutStatus : TeaModel {
                /// <summary>
                /// <para>The data migration progress, as a percentage.</para>
                /// <remarks>
                /// <para>This parameter is returned only when the cluster is in the <c>SCALING_OUT</c> state.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <para>The data migration progress, displayed as <c>Amount of data migrated/Total data amount</c>.</para>
                /// <remarks>
                /// <para>This parameter is returned only when the cluster is in the <c>SCALING_OUT</c> state.</para>
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
            /// <para>The storage type. Valid values:</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description><para><c>CloudESSD_PL0</c>: ESSD PL0 disk.</para>
            /// </description></item>
            /// <item><description><para><c>CloudESSD</c>: ESSD PL1 disk.</para>
            /// </description></item>
            /// <item><description><para><c>CloudESSD_PL2</c>: ESSD PL2 disk.</para>
            /// </description></item>
            /// <item><description><para><c>CloudESSD_PL3</c>: ESSD PL3 disk.</para>
            /// </description></item>
            /// <item><description><para><c>CloudEfficiency</c>: Ultra disk.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CloudESSD</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>Whether the cluster supports data backup. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>1</c>: Supported.</para>
            /// </description></item>
            /// <item><description><para><c>2</c>: Not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SupportBackup")]
            [Validation(Required=false)]
            public int? SupportBackup { get; set; }

            /// <summary>
            /// <para>Whether the HTTPS port is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Supported.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SupportHttpsPort")]
            [Validation(Required=false)]
            public bool? SupportHttpsPort { get; set; }

            /// <summary>
            /// <para>Whether the MySQL port is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Supported.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SupportMysqlPort")]
            [Validation(Required=false)]
            public bool? SupportMysqlPort { get; set; }

            /// <summary>
            /// <para>Whether the cluster supports tiered storage for hot and cold data. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>1</c>: Supported.</para>
            /// </description></item>
            /// <item><description><para><c>2</c>: Not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SupportOss")]
            [Validation(Required=false)]
            public int? SupportOss { get; set; }

            /// <summary>
            /// <para>The tags of the cluster.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public DescribeDBClusterAttributeResponseBodyDBClusterTags Tags { get; set; }
            public class DescribeDBClusterAttributeResponseBodyDBClusterTags : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<DescribeDBClusterAttributeResponseBodyDBClusterTagsTag> Tag { get; set; }
                public class DescribeDBClusterAttributeResponseBodyDBClusterTagsTag : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

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
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp10tr8k9qasioaty****</para>
            /// </summary>
            [NameInMap("VpcCloudInstanceId")]
            [Validation(Required=false)]
            public string VpcCloudInstanceId { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp10tr8k9qasioaty****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The IP address of the VPC endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.xx.xx</para>
            /// </summary>
            [NameInMap("VpcIpAddr")]
            [Validation(Required=false)]
            public string VpcIpAddr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("WebUISnatStatus")]
            [Validation(Required=false)]
            public string WebUISnatStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("WebUIStatus")]
            [Validation(Required=false)]
            public string WebUIStatus { get; set; }

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
            /// <para>A map of zone IDs to vSwitch IDs for a multi-zone cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-f: vsw-zm0n42d5vvuo****</para>
            /// </summary>
            [NameInMap("ZoneIdVswitchMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> ZoneIdVswitchMap { get; set; }

            /// <summary>
            /// <para>The specifications of the ZooKeeper nodes.</para>
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
