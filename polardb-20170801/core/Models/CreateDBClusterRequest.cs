// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateDBClusterRequest : TeaModel {
        [NameInMap("AgenticDbClusterDescription")]
        [Validation(Required=false)]
        public string AgenticDbClusterDescription { get; set; }

        [NameInMap("AgenticDbClusterId")]
        [Validation(Required=false)]
        public string AgenticDbClusterId { get; set; }

        [NameInMap("AgenticDbType")]
        [Validation(Required=false)]
        public string AgenticDbType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable No-activity Suspension. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled. This is the default value.</para>
        /// <remarks>
        /// <para>Only serverless clusters support this parameter.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowShutDown")]
        [Validation(Required=false)]
        public string AllowShutDown { get; set; }

        /// <summary>
        /// <para>The CPU architecture. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>X86</description></item>
        /// <item><description>ARM</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>X86</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Auto-renewal is enabled.</description></item>
        /// <item><description><b>false</b>: Auto-renewal is disabled.</description></item>
        /// </list>
        /// <para>Default value: <b>false</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>PayType</b> is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically use coupons. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): Coupons are used.</description></item>
        /// <item><description>false: Coupons are not used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The data retention policy applied when the cluster is deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALL</b>: All backups are retained for long-term retention (LTR).</description></item>
        /// <item><description><b>LATEST</b>: The last backup is retained for long-term retention (LTR). An automatic backup is performed before deletion.</description></item>
        /// <item><description><b>NONE</b>: No backups are retained when the cluster is deleted.</description></item>
        /// </list>
        /// <para>Default value: <b>NONE</b>, which means no backups are retained when the cluster is deleted.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when <b>DBType</b> is set to <b>MySQL</b>.</description></item>
        /// <item><description>Serverless clusters do not support this parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public string BackupRetentionPolicyOnClusterDeletion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable I/O performance burst for the ESSD AutoPL cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only when StorageType is set to ESSDAUTOPL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public string BurstingEnabled { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. The value is generated by the client and must be unique among different requests. It is case-sensitive and cannot exceed 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f5********************</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The point in time at which data is cloned. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>LATEST</b>: The latest point in time.</description></item>
        /// <item><description><b>BackupID</b>: A historical backup set ID. Specify the actual backup set ID.</description></item>
        /// <item><description><b>Timestamp</b>: A historical point in time. Specify the actual time in the <c>YYYY-MM-DDThh:mm:ssZ</c> format (UTC).</description></item>
        /// </list>
        /// <para> Default value: <b>LATEST</b>.</para>
        /// <remarks>
        /// <para>If <b>CreationOption</b> is set to <b>CloneFromRDS</b>, this parameter can only be set to <b>LATEST</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>LATEST</para>
        /// </summary>
        [NameInMap("CloneDataPoint")]
        [Validation(Required=false)]
        public string CloneDataPoint { get; set; }

        /// <summary>
        /// <para>The cloud service provider of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENS</para>
        /// </summary>
        [NameInMap("CloudProvider")]
        [Validation(Required=false)]
        public string CloudProvider { get; set; }

        /// <summary>
        /// <para>The network type of the cluster. Only Virtual Private Cloud (VPC) is supported. Set the value to <b>VPC</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("ClusterNetworkType")]
        [Validation(Required=false)]
        public string ClusterNetworkType { get; set; }

        /// <summary>
        /// <para>The edition of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: Cluster Edition. This is the default value.</description></item>
        /// <item><description><b>Basic</b>: Single Node Edition.</description></item>
        /// <item><description><b>ArchiveNormal</b>: X-Engine Edition.</description></item>
        /// <item><description><b>NormalMultimaster</b>: Multi-master Cluster Edition.</description></item>
        /// <item><description><b>SENormal</b>: Standard Edition.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b> <b>5.6</b>, <b>5.7</b>, <b>8.0</b>, <b>PostgreSQL</b> <b>14</b>, and <b>Oracle syntax-compatible 2.0</b> support <b>Basic</b>.</description></item>
        /// <item><description><b>MySQL</b> <b>8.0</b> supports <b>ArchiveNormal</b> and <b>NormalMultimaster</b>.</description></item>
        /// <item><description><b>MySQL</b> <b>5.6</b>, <b>5.7</b>, <b>8.0</b>, and <b>PostgreSQL</b> <b>14</b> support <b>SENormal</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <para>For more information about editions, see <a href="https://help.aliyun.com/document_detail/183258.html">Product editions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("CreationCategory")]
        [Validation(Required=false)]
        public string CreationCategory { get; set; }

        /// <summary>
        /// <para>The method used to create the cluster. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: Creates a new PolarDB cluster. For console operations, see the following topics:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/58769.html">Create a PolarDB for MySQL database cluster</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/118063.html">Create a PolarDB for PostgreSQL database cluster</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/118182.html">Create a PolarDB for PostgreSQL (Compatible with Oracle) database cluster</a></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>CloneFromPolarDB</b>: Clones data from an existing PolarDB cluster to a new PolarDB cluster. For console operations, see the following topics:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/87966.html">Clone a PolarDB for MySQL cluster</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/118108.html">Clone a PolarDB for PostgreSQL cluster</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/118221.html">Clone a PolarDB for PostgreSQL (Compatible with Oracle) cluster</a></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>RecoverFromRecyclebin</b>: Recovers data from a released PolarDB cluster to a new PolarDB cluster. For console operations, see the following topics:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/164880.html">Restore a released PolarDB for MySQL cluster</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/432844.html">Restore a released PolarDB for PostgreSQL cluster</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/424632.html">Restore a released PolarDB for PostgreSQL (Compatible with Oracle) cluster</a></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>CloneFromRDS</b>: Clones data from an existing ApsaraDB RDS instance to a new PolarDB cluster. For console operations, see <a href="https://help.aliyun.com/document_detail/121812.html">Clone an ApsaraDB RDS for MySQL instance to a PolarDB for MySQL cluster</a>.</para>
        /// </description></item>
        /// <item><description><para><b>MigrationFromRDS</b>: Migrates data from an existing ApsaraDB RDS instance to a new PolarDB cluster. The created PolarDB cluster is in read-only pattern and has binary logging enabled by default. For console operations, see <a href="https://help.aliyun.com/document_detail/121582.html">Upgrade an ApsaraDB RDS for MySQL instance to a PolarDB for MySQL cluster</a>.</para>
        /// </description></item>
        /// <item><description><para><b>CreateGdnStandby</b>: Creates a secondary cluster. For console operations, see <a href="https://help.aliyun.com/document_detail/160381.html">Add a secondary cluster</a>.</para>
        /// </description></item>
        /// <item><description><para><b>UpgradeFromPolarDB</b>: Performs instance migration from PolarDB. For console operations, see <a href="https://help.aliyun.com/document_detail/459712.html">Major engine version upgrade</a>.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>Normal</b>.</para>
        /// <remarks>
        /// <para>When <b>DBType</b> is set to <b>MySQL</b> and <b>DBVersion</b> is set to <b>8.0</b>, you can set this parameter to <b>CreateGdnStandby</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("CreationOption")]
        [Validation(Required=false)]
        public string CreationOption { get; set; }

        /// <summary>
        /// <para>The name of the cluster. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>It cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>It must be 2 to 256 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// <para>The minor engine version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>8.0.2</b></para>
        /// </description></item>
        /// <item><description><para><b>8.0.1</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>DBType</b> is set to <b>MySQL</b> and <b>DBVersion</b> is set to <b>8.0</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8.0.1</para>
        /// </summary>
        [NameInMap("DBMinorVersion")]
        [Validation(Required=false)]
        public string DBMinorVersion { get; set; }

        /// <summary>
        /// <para>The node specification. For more information, see the following topics:</para>
        /// <list type="bullet">
        /// <item><description>PolarDB for MySQL: <a href="https://help.aliyun.com/document_detail/102542.html">Compute node specifications</a>.</description></item>
        /// <item><description>PolarDB for PostgreSQL (Compatible with Oracle): <a href="https://help.aliyun.com/document_detail/207921.html">Compute node specifications</a>.</description></item>
        /// <item><description>PolarDB for PostgreSQL: <a href="https://help.aliyun.com/document_detail/209380.html">Compute node specifications</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>To create a serverless cluster for PolarDB for MySQL Cluster Edition, set this parameter to <b>polar.mysql.sl.small</b>.</description></item>
        /// <item><description>To create a serverless cluster for PolarDB for MySQL Standard Edition, set this parameter to <b>polar.mysql.sl.small.c</b>.</description></item>
        /// <item><description>To create a serverless cluster for PolarDB for PostgreSQL Cluster Edition, set this parameter to <b>polar.pg.sl.small</b>.</description></item>
        /// <item><description>To create a serverless cluster for PolarDB for PostgreSQL Standard Edition, set this parameter to <b>polar.pg.sl.small.c</b>.</description></item>
        /// <item><description>To create a serverless cluster for PolarDB for PostgreSQL (Compatible with Oracle), set this parameter to <b>polar.o.sl.small</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>polar.mysql.x4.medium</para>
        /// </summary>
        [NameInMap("DBNodeClass")]
        [Validation(Required=false)]
        public string DBNodeClass { get; set; }

        /// <summary>
        /// <para>The number of nodes for Standard Edition and Enterprise Edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard Edition: 1 to 8 (supports 1 read/write node and 7 read-only nodes).</description></item>
        /// <item><description>Enterprise Edition: 1 to 16 (supports 1 read/write node and 15 read-only nodes).<remarks>
        /// <list type="bullet">
        /// <item><description>Enterprise Edition has 2 nodes by default. Standard Edition has 1 node by default.</description></item>
        /// <item><description>Only PolarDB for MySQL supports this parameter.</description></item>
        /// <item><description>Changing the number of nodes for Multi-master Cluster Edition clusters is not supported.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DBNodeNum")]
        [Validation(Required=false)]
        public int? DBNodeNum { get; set; }

        /// <summary>
        /// <para>The database engine type. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// <item><description><b>Oracle</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The database engine version.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values for MySQL: </para>
        /// <list type="bullet">
        /// <item><description><b>5.6</b></description></item>
        /// <item><description><b>5.7</b></description></item>
        /// <item><description><b>8.0</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid values for PostgreSQL:</para>
        /// <list type="bullet">
        /// <item><description><para><b>11</b></para>
        /// </description></item>
        /// <item><description><para><b>14</b></para>
        /// </description></item>
        /// <item><description><para><b>15</b>
        ///   &lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>To create a serverless cluster for PolarDB for PostgreSQL, only version 14 is supported.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid values for Oracle:</para>
        /// <list type="bullet">
        /// <item><description><b>11</b></description></item>
        /// <item><description><b>14</b></description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.6</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>The default time zone of the cluster (UTC). The value can be any time frame within the range of <b>-12:00 to +13:00</b>, such as <b>00:00</b>. Default value: <b>SYSTEM</b>, which indicates that the default time zone is the same as the time zone of the region.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>DBType</b> is set to <b>MySQL</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM</para>
        /// </summary>
        [NameInMap("DefaultTimeZone")]
        [Validation(Required=false)]
        public string DefaultTimeZone { get; set; }

        /// <summary>
        /// <para>The ENS node ID required when creating an ENS database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vn-hanoi-3</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the global database network (GDN).</para>
        /// <remarks>
        /// <para>This parameter is required when <b>CreationOption</b> is set to <b>CreateGdnStandby</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gdn-***********</para>
        /// </summary>
        [NameInMap("GDNId")]
        [Validation(Required=false)]
        public string GDNId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the hot standby cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ON</b> (default): Enables the hot standby storage cluster.</description></item>
        /// <item><description><b>OFF</b>: Disables the hot standby cluster.</description></item>
        /// <item><description><b>STANDBY</b>: Enables the hot standby cluster.</description></item>
        /// <item><description><b>EQUAL</b>: Enables both the hot standby storage cluster and the hot standby compute cluster.</description></item>
        /// <item><description><b>3AZ</b>: Enables multi-zone strong data consistency.<remarks>
        /// <para><b>STANDBY</b> takes effect only for PolarDB for PostgreSQL.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("HotStandbyCluster")]
        [Validation(Required=false)]
        public string HotStandbyCluster { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the binary logging feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ON</b>: Binary logging is enabled for the cluster.</description></item>
        /// <item><description><b>OFF</b>: Binary logging is disabled for the cluster.<remarks>
        /// <para>This parameter takes effect only when <b>DBType</b> is set to <b>MySQL</b>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("LoosePolarLogBin")]
        [Validation(Required=false)]
        public string LoosePolarLogBin { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the X-Engine storage engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ON</b>: The X-Engine engine is enabled for the cluster.</description></item>
        /// <item><description><b>OFF</b>: The X-Engine engine is disabled for the cluster.<remarks>
        /// <para>This parameter takes effect only when <b>CreationOption</b> is not set to <b>CreateGdnStandby</b>, <b>DBType</b> is set to <b>MySQL</b>, and <b>DBVersion</b> is set to <b>8.0</b>. The memory specification of nodes with X-Engine enabled must be 8 GB or more.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("LooseXEngine")]
        [Validation(Required=false)]
        public string LooseXEngine { get; set; }

        /// <summary>
        /// <para>The percentage of memory allocated to the X-Engine storage engine. Valid values: integers from 10 to 90.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>LooseXEngine</b> is set to <b>ON</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("LooseXEngineUseMemoryPct")]
        [Validation(Required=false)]
        public string LooseXEngineUseMemoryPct { get; set; }

        /// <summary>
        /// <para>Specifies whether table names are case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Table names are case-insensitive.</description></item>
        /// <item><description><b>0</b>: Table names are case-sensitive.</description></item>
        /// </list>
        /// <para>Default value: <b>1</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>DBType</b> is set to <b>MySQL</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LowerCaseTableNames")]
        [Validation(Required=false)]
        public string LowerCaseTableNames { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the parameter template.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/207178.html">DescribeParameterGroups</a> operation to query the parameter template list in the specified region, including the parameter template ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pcpg-**************</para>
        /// </summary>
        [NameInMap("ParameterGroupId")]
        [Validation(Required=false)]
        public string ParameterGroupId { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>This parameter is required when <b>PayType</b> is set to <b>Prepaid</b>. Pass this parameter to specify whether the upfront cluster uses a yearly or monthly billing cycle. </para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: The subscription period is measured in years.</description></item>
        /// <item><description><b>Month</b>: The subscription period is measured in months.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The coupon code. If not specified, the default coupon is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>727xxxxxx934</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <p id="p_wyg_t4a_glm" props="china" icmsditafragmentmagic=1>The provisioned read/write IOPS of the ESSD AutoPL cloud disk. Valid values: 0 to min{50,000, 1000 × capacity - baseline performance}.</para>
        /// <p id="p_6de_jxy_k2g" props="china" icmsditafragmentmagic=1>Baseline performance = min{1,800 + 50 × capacity, 50,000}.</para>
        /// <note id="note_7kj_j0o_rgs" props="china" icmsditafragmentmagic=1>This parameter is supported only when StorageType is set to ESSDAUTOPL.</note>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        /// <summary>
        /// <para>The specification of the database proxy for Standard Edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>polar.maxscale.g2.medium.c</b>: 2 cores.</description></item>
        /// <item><description><b>polar.maxscale.g2.large.c</b>: 4 cores.</description></item>
        /// <item><description><b>polar.maxscale.g2.xlarge.c</b>: 8 cores.</description></item>
        /// <item><description><b>polar.maxscale.g2.2xlarge.c</b>: 16 cores.</description></item>
        /// <item><description><b>polar.maxscale.g2.3xlarge.c</b>: 24 cores.</description></item>
        /// <item><description><b>polar.maxscale.g2.4xlarge.c</b>: 32 cores.</description></item>
        /// <item><description><b>polar.maxscale.g2.8xlarge.c</b>: 64 cores.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>polar.maxscale.g2.medium.c</para>
        /// </summary>
        [NameInMap("ProxyClass")]
        [Validation(Required=false)]
        public string ProxyClass { get; set; }

        /// <summary>
        /// <para>The type of the database proxy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>EXCLUSIVE</b>: Dedicated Enterprise Edition.</description></item>
        /// <item><description><b>GENERAL</b>: Standard Enterprise Edition.<remarks>
        /// <para>The proxy type must match the type that corresponds to the node specifications of the cluster:</para>
        /// <list type="bullet">
        /// <item><description>If the node specifications are General-purpose, set the proxy type to Standard Enterprise Edition.</description></item>
        /// <item><description>If the node specifications are Dedicated, set the proxy type to Dedicated Enterprise Edition.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Exclusive</para>
        /// </summary>
        [NameInMap("ProxyType")]
        [Validation(Required=false)]
        public string ProxyType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query available regions.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
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
        /// <para>rg-************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The maximum scaling limit for a single node. Valid values: 1 PCU to 32 PCU.</para>
        /// <remarks>
        /// <para>Only serverless clusters support this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ScaleMax")]
        [Validation(Required=false)]
        public string ScaleMax { get; set; }

        /// <summary>
        /// <para>The minimum scaling limit for a single node. Valid values: 1 PCU to 31 PCU.</para>
        /// <remarks>
        /// <para>Only serverless clusters support this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScaleMin")]
        [Validation(Required=false)]
        public string ScaleMin { get; set; }

        /// <summary>
        /// <para>The maximum number of read-only nodes for scaling. Valid values: 0 to 15.</para>
        /// <remarks>
        /// <para>Only serverless clusters support this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ScaleRoNumMax")]
        [Validation(Required=false)]
        public string ScaleRoNumMax { get; set; }

        /// <summary>
        /// <para>The minimum number of read-only nodes for scaling. Valid values: 0 to 15.</para>
        /// <remarks>
        /// <para>Only serverless clusters support this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ScaleRoNumMin")]
        [Validation(Required=false)]
        public string ScaleRoNumMin { get; set; }

        /// <summary>
        /// <para>The IP addresses in the whitelist of the PolarDB cluster.</para>
        /// <remarks>
        /// <para>You can specify multiple IP addresses. Separate multiple IP addresses with commas (,).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10.<em><b>.</b></em>.***</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// <para>The serverless type. Set the value to <b>AgileServerless</b> (agile).</para>
        /// <remarks>
        /// <para>Only serverless clusters support this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AgileServerless</para>
        /// </summary>
        [NameInMap("ServerlessType")]
        [Validation(Required=false)]
        public string ServerlessType { get; set; }

        /// <summary>
        /// <para>Instance ID of the source ApsaraDB RDS instance or the source PolarDB cluster. This parameter is required only when <b>CreationOption</b> is set to <b>MigrationFromRDS</b>, <b>CloneFromRDS</b>, <b>CloneFromPolarDB</b>, or <b>RecoverFromRecyclebin</b>.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>CreationOption</b> is set to <b>MigrationFromRDS</b> or <b>CloneFromRDS</b>, set this parameter to instance ID of the source ApsaraDB RDS instance. The source ApsaraDB RDS instance must run RDS MySQL 5.6, 5.7, or 8.0 on RDS High-availability Edition.</para>
        /// </description></item>
        /// <item><description><para>If <b>CreationOption</b> is set to <b>CloneFromPolarDB</b>, set this parameter to instance ID of the source PolarDB cluster. The cloned cluster and the source cluster have the same DBType by default. For example, if the source cluster runs MySQL 8.0, set <b>DBType</b> to <b>MySQL</b> and <b>DBVersion</b> to <b>8.0</b> for the cloned cluster.</para>
        /// </description></item>
        /// <item><description><para>If <b>CreationOption</b> is set to <b>RecoverFromRecyclebin</b>, set this parameter to instance ID of the released source PolarDB cluster. The recovered cluster and the source cluster must have the same DBType. For example, if the source cluster runs MySQL 8.0, set <b>DBType</b> to <b>MySQL</b> and <b>DBVersion</b> to <b>8.0</b> for the recovered cluster.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rm-*************</para>
        /// </summary>
        [NameInMap("SourceResourceId")]
        [Validation(Required=false)]
        public string SourceResourceId { get; set; }

        /// <summary>
        /// <para>The UID of the account that owns the source backup set in cross-account backup restoration scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1022xxxxxxxx</para>
        /// </summary>
        [NameInMap("SourceUid")]
        [Validation(Required=false)]
        public long? SourceUid { get; set; }

        /// <summary>
        /// <para>The zone of the hot standby cluster.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the hot standby cluster or multi-zone strong data consistency is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("StandbyAZ")]
        [Validation(Required=false)]
        public string StandbyAZ { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic storage scaling for Standard Edition clusters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enable: Automatic storage scaling is enabled.</description></item>
        /// <item><description>Disable: Automatic storage scaling is shutdown.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("StorageAutoScale")]
        [Validation(Required=false)]
        public string StorageAutoScale { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable cloud disk encryption. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Cloud disk encryption is enabled.</description></item>
        /// <item><description><b>false</b>: Cloud disk encryption is disabled. This is the default value.<remarks>
        /// <para>This parameter takes effect only when <b>DBType</b> is set to <b>MySQL</b>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>StorageType</b> is set to a Standard Edition storage type.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("StorageEncryption")]
        [Validation(Required=false)]
        public bool? StorageEncryption { get; set; }

        /// <summary>
        /// <para>The ID of the custom encryption key for cloud disk encryption in the same region as the instance. Specifying this parameter automatically enables cloud disk encryption, which cannot be disabled after it is enabled. Leave this parameter empty to use the default service key for cloud disk encryption.</para>
        /// <para>You can view the key ID in the Key Management Service (KMS) console or create a new key.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>DBType</b> is set to <b>MySQL</b>.</para>
        /// </remarks>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>StorageType</b> is set to a Standard Edition storage type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1022xxxxxxxx</para>
        /// </summary>
        [NameInMap("StorageEncryptionKey")]
        [Validation(Required=false)]
        public string StorageEncryptionKey { get; set; }

        /// <summary>
        /// <para>The billing type for storage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Postpaid: pay-by-capacity (pay-as-you-go).</description></item>
        /// <item><description>Prepaid: pay-by-space (subscription).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("StoragePayType")]
        [Validation(Required=false)]
        public string StoragePayType { get; set; }

        /// <summary>
        /// <para>The storage space for subscription billing (pay-by-space). Unit: GB.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Valid values for PolarDB for MySQL Enterprise Edition: 10 to 50000.</description></item>
        /// <item><description>Valid values for PolarDB for MySQL Standard Edition: 20 to 64000.</description></item>
        /// <item><description>When the Standard Edition storage type is ESSDAUTOPL, valid values are 40 to 64000 with a minimum step of 10. Only values such as 40, 50, 60, and so on are accepted.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("StorageSpace")]
        [Validation(Required=false)]
        public long? StorageSpace { get; set; }

        /// <summary>
        /// <para>Valid values for Enterprise Edition storage type:</para>
        /// <list type="bullet">
        /// <item><description><b>PSL5</b></description></item>
        /// <item><description><b>PSL4</b></description></item>
        /// </list>
        /// <para>Valid values for Standard Edition storage type:</para>
        /// <list type="bullet">
        /// <item><description><b>ESSDPL0</b></description></item>
        /// <item><description><b>ESSDPL1</b></description></item>
        /// <item><description><b>ESSDPL2</b></description></item>
        /// <item><description><b>ESSDPL3</b></description></item>
        /// <item><description><b>ESSDAUTOPL</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PSL4</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>Sets the upper limit for automatic storage scaling of Standard Edition clusters. Unit: GB.</para>
        /// <remarks>
        /// <para>The maximum value is 32000.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("StorageUpperBound")]
        [Validation(Required=false)]
        public long? StorageUpperBound { get; set; }

        /// <summary>
        /// <para>Specifies whether multi-zone strong data consistency is enabled for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ON</b>: Multi-zone strong data consistency is enabled. This value applies to the Standard Edition 3AZ scenario.</para>
        /// </description></item>
        /// <item><description><para><b>OFF</b>: Multi-zone strong data consistency is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("StrictConsistency")]
        [Validation(Required=false)]
        public string StrictConsistency { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Transparent Data Encryption (TDE). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: TDE is enabled.</description></item>
        /// <item><description><b>false</b>: TDE is disabled. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when <b>DBType</b> is set to <b>PostgreSQL</b> or <b>Oracle</b>.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/167982.html">ModifyDBClusterTDE</a> operation to enable TDE for a PolarDB for MySQL cluster.</description></item>
        /// <item><description>TDE cannot be disabled after it is enabled.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TDEStatus")]
        [Validation(Required=false)]
        public bool? TDEStatus { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDBClusterRequestTag> Tag { get; set; }
        public class CreateDBClusterRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. To add multiple tags to the cluster at a time, click <b>Add</b> to add tag keys.</para>
            /// <remarks>
            /// <para>You can add up to 20 tag pairs at a time. <c>Tag.N.Key</c> corresponds to <c>Tag.N.Value</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>type</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. To add multiple tags to the cluster at a time, click <b>Add</b> to add tag values.</para>
            /// <remarks>
            /// <para>You can add up to 20 tag pairs at a time. <c>Tag.N.Value</c> corresponds to <c>Tag.N.Key</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The target minor engine version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0.1.1.54</para>
        /// </summary>
        [NameInMap("TargetMinorVersion")]
        [Validation(Required=false)]
        public string TargetMinorVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required when <b>PayType</b> is set to <b>Prepaid</b>.</para>
        /// <list type="bullet">
        /// <item><description>When <b>Period</b> is set to <b>Month</b>, the valid values of <b>UsedTime</b> are integers in the range of <c>[1-9]</c>.</description></item>
        /// <item><description>When <b>Period</b> is set to <b>Year</b>, the valid values of <b>UsedTime</b> are integers in the range of <c>[1-3]</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-**********</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <remarks>
        /// <para>If you specify VPCId, you must also specify VSwitchId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-**********</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query available zones.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
