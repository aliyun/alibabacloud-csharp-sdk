// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable pause on inactivity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables pause on inactivity.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): disables pause on inactivity.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only for serverless clusters.</para>
        /// </remarks>
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
        /// <item><description><para>X86</para>
        /// </description></item>
        /// <item><description><para>ARM</para>
        /// </description></item>
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
        /// <item><description><para><b>true</b>: enables auto-renewal.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables auto-renewal.</para>
        /// </description></item>
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
        /// <para>Specifies whether to automatically use a coupon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true (default): Automatically uses a coupon.</para>
        /// </description></item>
        /// <item><description><para>false: does not use a coupon.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The backup retention policy to apply when the cluster is deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ALL</b>: retains all backup sets.</para>
        /// </description></item>
        /// <item><description><para><b>LATEST</b>: retains only the last backup set. An automatic backup is performed before the cluster is deleted.</para>
        /// </description></item>
        /// <item><description><para><b>NONE</b>: does not retain backup sets.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>NONE</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is valid only if <b>DBType</b> is set to <b>MySQL</b>.</para>
        /// </description></item>
        /// <item><description><para>Serverless clusters do not support this parameter.</para>
        /// </description></item>
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
        /// <para>Specifies whether to enable the performance burst feature for the ESSD AutoPL cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables the performance burst feature.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): disables the performance burst feature.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only when <b>StorageType</b> is set to ESSDAUTOPL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public string BurstingEnabled { get; set; }

        /// <summary>
        /// <para>A client-generated token that ensures the idempotence of the request. This token must be unique across all requests and is case-sensitive. It can contain up to 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f5********************</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The point in time for the clone. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>LATEST</b>: The latest point in time.</para>
        /// </description></item>
        /// <item><description><para><b>BackupID</b>: The ID of a historical backup set.</para>
        /// </description></item>
        /// <item><description><para><b>Timestamp</b>: A specific point in time in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>LATEST</b>.</para>
        /// <remarks>
        /// <para>If you set <b>CreationOption</b> to <b>CloneFromRDS</b>, you can set this parameter only to <b>LATEST</b>.</para>
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
        /// <para>The network type of the cluster. Only <b>VPC</b> is supported.</para>
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
        /// <item><description><para><b>Normal</b>: Cluster Edition (default)</para>
        /// </description></item>
        /// <item><description><para><b>Basic</b>: Single-node Edition</para>
        /// </description></item>
        /// <item><description><para><b>ArchiveNormal</b>: X-Engine Edition</para>
        /// </description></item>
        /// <item><description><para><b>NormalMultimaster</b>: Multi-master Cluster Edition</para>
        /// </description></item>
        /// <item><description><para><b>SENormal</b>: Standard Edition</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The <b>Basic</b> edition is supported for PolarDB for MySQL <b>5.6</b>, <b>5.7</b>, and <b>8.0</b>; PolarDB for PostgreSQL <b>14</b>; and PolarDB for PostgreSQL (compatible with Oracle) <b>2.0</b>.</para>
        /// </description></item>
        /// <item><description><para>The <b>ArchiveNormal</b> and <b>NormalMultimaster</b> editions are supported for PolarDB for MySQL <b>8.0</b>.</para>
        /// </description></item>
        /// <item><description><para>The <b>SENormal</b> edition is supported for PolarDB for MySQL <b>5.6</b>, <b>5.7</b>, and <b>8.0</b> and PolarDB for PostgreSQL <b>14</b>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>For more information about product editions, see <a href="https://help.aliyun.com/document_detail/183258.html">Editions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("CreationCategory")]
        [Validation(Required=false)]
        public string CreationCategory { get; set; }

        /// <summary>
        /// <para>The method to create the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: Creates a new PolarDB cluster. For more information, see the following topics:</para>
        /// <list type="bullet">
        /// <item><description><para><a href="https://help.aliyun.com/document_detail/58769.html">Create a PolarDB for MySQL cluster</a></para>
        /// </description></item>
        /// <item><description><para><a href="https://help.aliyun.com/document_detail/118063.html">Create a PolarDB for PostgreSQL cluster</a></para>
        /// </description></item>
        /// <item><description><para><a href="https://help.aliyun.com/document_detail/118182.html">Create a PolarDB for PostgreSQL (compatible with Oracle) cluster</a></para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>CloneFromPolarDB</b>: Clones data from an existing PolarDB cluster. For more information, see the following topics:</para>
        /// <list type="bullet">
        /// <item><description><para><a href="https://help.aliyun.com/document_detail/87966.html">Clone a PolarDB for MySQL cluster</a></para>
        /// </description></item>
        /// <item><description><para><a href="https://help.aliyun.com/document_detail/118108.html">Clone a PolarDB for PostgreSQL cluster</a></para>
        /// </description></item>
        /// <item><description><para><a href="https://help.aliyun.com/document_detail/118221.html">Clone a PolarDB for PostgreSQL (compatible with Oracle) cluster</a></para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>RecoverFromRecyclebin</b>: Restores a PolarDB cluster from the recycle bin. For more information, see the following topics:</para>
        /// <list type="bullet">
        /// <item><description><para><a href="https://help.aliyun.com/document_detail/164880.html">Restore a released PolarDB for MySQL cluster</a></para>
        /// </description></item>
        /// <item><description><para><a href="https://help.aliyun.com/document_detail/432844.html">Restore a released PolarDB for PostgreSQL cluster</a></para>
        /// </description></item>
        /// <item><description><para><a href="https://help.aliyun.com/document_detail/424632.html">Restore a released PolarDB for PostgreSQL (compatible with Oracle) cluster</a></para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>CloneFromRDS</b>: Clones data from an existing ApsaraDB RDS instance to a new PolarDB cluster. For more information, see <a href="https://help.aliyun.com/document_detail/121812.html">One-click cloning from ApsaraDB RDS for MySQL to PolarDB for MySQL</a>.</para>
        /// </description></item>
        /// <item><description><para><b>MigrationFromRDS</b>: Migrates data from an existing ApsaraDB RDS instance. The created PolarDB cluster is in read-only mode and has binary logging enabled by default. For more information, see <a href="https://help.aliyun.com/document_detail/121582.html">One-click upgrade from ApsaraDB RDS for MySQL to PolarDB for MySQL</a>.</para>
        /// </description></item>
        /// <item><description><para><b>CreateGdnStandby</b>: Creates a secondary cluster in a Global Database Network (GDN). For more information, see <a href="https://help.aliyun.com/document_detail/160381.html">Add a secondary cluster</a>.</para>
        /// </description></item>
        /// <item><description><para><b>UpgradeFromPolarDB</b>: Upgrades the major version of a PolarDB cluster. For more information, see <a href="https://help.aliyun.com/document_detail/459712.html">Perform a major version upgrade</a>.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>Normal</b>.</para>
        /// <remarks>
        /// <para>If <b>DBType</b> is set to <b>MySQL</b> and <b>DBVersion</b> is set to <b>8.0</b>, you can set this parameter to <b>CreateGdnStandby</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("CreationOption")]
        [Validation(Required=false)]
        public string CreationOption { get; set; }

        /// <summary>
        /// <para>The description of the cluster. The description must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </description></item>
        /// <item><description><para>It must be 2 to 256 characters in length.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// <para>The minor version of the database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>8.0.2</b></para>
        /// </description></item>
        /// <item><description><para><b>8.0.1</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only if <b>DBType</b> is set to <b>MySQL</b> and <b>DBVersion</b> is set to <b>8.0</b>.</para>
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
        /// <item><description><para>PolarDB for MySQL: <a href="https://help.aliyun.com/document_detail/102542.html">Compute node specifications</a></para>
        /// </description></item>
        /// <item><description><para>PolarDB for PostgreSQL (compatible with Oracle): <a href="https://help.aliyun.com/document_detail/207921.html">Compute node specifications</a></para>
        /// </description></item>
        /// <item><description><para>PolarDB for PostgreSQL: <a href="https://help.aliyun.com/document_detail/209380.html">Compute node specifications</a></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>To create a PolarDB for MySQL Cluster Edition serverless cluster, set this parameter to <b>polar.mysql.sl.small</b>.</para>
        /// </description></item>
        /// <item><description><para>To create a PolarDB for MySQL Standard Edition serverless cluster, set this parameter to <b>polar.mysql.sl.small.c</b>.</para>
        /// </description></item>
        /// <item><description><para>To create a PolarDB for PostgreSQL Cluster Edition serverless cluster, set this parameter to <b>polar.pg.sl.small</b>.</para>
        /// </description></item>
        /// <item><description><para>To create a PolarDB for PostgreSQL Standard Edition serverless cluster, set this parameter to <b>polar.pg.sl.small.c</b>.</para>
        /// </description></item>
        /// <item><description><para>To create a PolarDB for PostgreSQL (compatible with Oracle) serverless cluster, set this parameter to <b>polar.o.sl.small</b>.</para>
        /// </description></item>
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
        /// <para>The number of nodes for a Standard Edition or Enterprise Edition cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Standard Edition: 1 to 8. A cluster of this edition includes one read/write node and up to seven read-only nodes.</para>
        /// </description></item>
        /// <item><description><para>Enterprise Edition: 1 to 16. A cluster of this edition includes one read/write node and up to 15 read-only nodes.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>By default, an Enterprise Edition cluster has two nodes and a Standard Edition cluster has one node.</para>
        /// </description></item>
        /// <item><description><para>This parameter is supported only for PolarDB for MySQL.</para>
        /// </description></item>
        /// <item><description><para>You cannot change the number of nodes in a Multi-master Cluster Edition cluster.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DBNodeNum")]
        [Validation(Required=false)]
        public int? DBNodeNum { get; set; }

        /// <summary>
        /// <para>The database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MySQL</b></para>
        /// </description></item>
        /// <item><description><para><b>PostgreSQL</b></para>
        /// </description></item>
        /// <item><description><para><b>Oracle</b></para>
        /// </description></item>
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
        /// <para>The version of the database engine.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values for MySQL:</para>
        /// <list type="bullet">
        /// <item><description><para><b>5.6</b></para>
        /// </description></item>
        /// <item><description><para><b>5.7</b></para>
        /// </description></item>
        /// <item><description><para><b>8.0</b></para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid values for PostgreSQL:</para>
        /// <list type="bullet">
        /// <item><description><para><b>11</b></para>
        /// </description></item>
        /// <item><description><para><b>14</b></para>
        /// </description></item>
        /// <item><description><para><b>15</b>&lt;props=&quot;china&quot;&gt;</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you create a serverless cluster for PolarDB for PostgreSQL, you must set this parameter to <c>14</c>.</para>
        /// </remarks>
        /// <para>\* Valid values for Oracle:
        /// \* <b>11</b>
        /// \* <b>14</b></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.6</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>Cluster time zone (UTC). The value can be any full-hour offset from <b>-12:00 to +13:00</b>, such as <b>00:00</b>. The default value is <b>SYSTEM</b>, which uses the region\&quot;s time zone.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>DBType</b> is <b>MySQL</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM</para>
        /// </summary>
        [NameInMap("DefaultTimeZone")]
        [Validation(Required=false)]
        public string DefaultTimeZone { get; set; }

        /// <summary>
        /// <para>The ID of the Edge Node Service (ENS) node. This parameter is required if you want to create an ENS database instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vn-hanoi-3</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the Global Database Network (GDN).</para>
        /// <remarks>
        /// <para>This parameter is required if <b>CreationOption</b> is set to <b>CreateGdnStandby</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gdn-***********</para>
        /// </summary>
        [NameInMap("GDNId")]
        [Validation(Required=false)]
        public string GDNId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the hot standby cluster feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ON</b> (default): enables a hot standby storage cluster.</para>
        /// </description></item>
        /// <item><description><para><b>OFF</b>: disables the hot standby cluster feature.</para>
        /// </description></item>
        /// <item><description><para><b>STANDBY</b>: enables a hot standby cluster.</para>
        /// </description></item>
        /// <item><description><para><b>EQUAL</b>: enables hot standby for both storage and computing resources.</para>
        /// </description></item>
        /// <item><description><para><b>3AZ</b>: enables multi-AZ strong consistency.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The value <b>STANDBY</b> is valid only for PolarDB for PostgreSQL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("HotStandbyCluster")]
        [Validation(Required=false)]
        public string HotStandbyCluster { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable binary logging. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ON</b>: enables binary logging.</para>
        /// </description></item>
        /// <item><description><para><b>OFF</b>: disables binary logging.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only if <b>DBType</b> is set to <b>MySQL</b>.</para>
        /// </remarks>
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
        /// <item><description><para><b>ON</b>: enables the X-Engine storage engine.</para>
        /// </description></item>
        /// <item><description><para><b>OFF</b>: disables the X-Engine storage engine.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only if the <b>CreationOption</b> parameter is not set to <b>CreateGdnStandby</b>, <b>DBType</b> is set to <b>MySQL</b>, and <b>DBVersion</b> is set to <b>8.0</b>. To enable the X-Engine storage engine, the node must have at least 8 GB of memory.</para>
        /// </remarks>
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
        /// <para>This parameter is valid only if <b>LooseXEngine</b> is set to <b>ON</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("LooseXEngineUseMemoryPct")]
        [Validation(Required=false)]
        public string LooseXEngineUseMemoryPct { get; set; }

        /// <summary>
        /// <para>The time zone of the cluster. The value must be a UTC offset in the <c>±HH:mm</c> format. Valid values: from <b>-12:00</b> to <b>+13:00</b> on the hour. For example, <b>00:00</b>. The default value <b>SYSTEM</b> indicates that the cluster uses the time zone of its region.</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Case-insensitive</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Case-sensitive</para>
        /// </description></item>
        /// </list>
        /// <para>The default value is <b>1</b>.</para>
        /// <remarks>
        /// <para>This parameter is valid only if <b>DBType</b> is set to <b>MySQL</b>.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/207178.html">DescribeParameterGroups</a> operation to query the parameter templates in a specific region, including the IDs of the parameter templates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pcpg-**************</para>
        /// </summary>
        [NameInMap("ParameterGroupId")]
        [Validation(Required=false)]
        public string ParameterGroupId { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Postpaid</b>: pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para><b>Prepaid</b>: subscription.</para>
        /// </description></item>
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
        /// <para>The unit of the subscription duration. This parameter is required if you set the <b>PayType</b> parameter to <b>Prepaid</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Year</b>: The subscription duration is measured in years.</para>
        /// </description></item>
        /// <item><description><para><b>Month</b>: The subscription duration is measured in months.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The promotion code. If you do not specify this parameter, the default coupon is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>727xxxxxx934</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The provisioned read/write IOPS of the ESSD AutoPL cloud disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is supported only when <b>StorageType</b> is set to ESSDAUTOPL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        /// <summary>
        /// <para>The specification of the database proxy for a Standard Edition cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>polar.maxscale.g2.medium.c</b>: 2 cores</para>
        /// </description></item>
        /// <item><description><para><b>polar.maxscale.g2.large.c</b>: 4 cores</para>
        /// </description></item>
        /// <item><description><para><b>polar.maxscale.g2.xlarge.c</b>: 8 cores</para>
        /// </description></item>
        /// <item><description><para><b>polar.maxscale.g2.2xlarge.c</b>: 16 cores</para>
        /// </description></item>
        /// <item><description><para><b>polar.maxscale.g2.3xlarge.c</b>: 24 cores</para>
        /// </description></item>
        /// <item><description><para><b>polar.maxscale.g2.4xlarge.c</b>: 32 cores</para>
        /// </description></item>
        /// <item><description><para><b>polar.maxscale.g2.8xlarge.c</b>: 64 cores</para>
        /// </description></item>
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
        /// <item><description><para><b>EXCLUSIVE</b>: Enterprise Dedicated</para>
        /// </description></item>
        /// <item><description><para><b>GENERAL</b>: Enterprise General-purpose</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The proxy type must be consistent with the type that corresponds to the node specification of the cluster:</para>
        /// <list type="bullet">
        /// <item><description><para>If the node specification is general-purpose, the proxy type must be Enterprise General-purpose.</para>
        /// </description></item>
        /// <item><description><para>If the node specification is dedicated, the proxy type must be Enterprise Dedicated.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
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
        /// <para>The ID of the resource group.</para>
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
        /// <para>The maximum number of PCUs for a single-node serverless cluster to scale up to. Valid values: 1 to 32.</para>
        /// <remarks>
        /// <para>This parameter is supported only for serverless clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ScaleMax")]
        [Validation(Required=false)]
        public string ScaleMax { get; set; }

        /// <summary>
        /// <para>The minimum number of PolarDB compute units (PCUs) for a single-node serverless cluster to scale down to. Valid values: 1 to 31.</para>
        /// <remarks>
        /// <para>This parameter is supported only for serverless clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScaleMin")]
        [Validation(Required=false)]
        public string ScaleMin { get; set; }

        /// <summary>
        /// <para>The maximum number of read-only nodes that the serverless cluster scales up to. Valid values: 0 to 15.</para>
        /// <remarks>
        /// <para>This parameter is supported only for serverless clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ScaleRoNumMax")]
        [Validation(Required=false)]
        public string ScaleRoNumMax { get; set; }

        /// <summary>
        /// <para>The minimum number of read-only nodes that the serverless cluster scales down to. Valid values: 0 to 15.</para>
        /// <remarks>
        /// <para>This parameter is supported only for serverless clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ScaleRoNumMin")]
        [Validation(Required=false)]
        public string ScaleRoNumMin { get; set; }

        /// <summary>
        /// <para>The IP whitelist of the PolarDB cluster.</para>
        /// <remarks>
        /// <para>You can specify multiple IP addresses in the IP whitelist. Separate the IP addresses with commas (,).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10.<em><b>.</b></em>.***</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// <para>The type of the serverless cluster. Set the value to <b>AgileServerless</b>.</para>
        /// <remarks>
        /// <para>This parameter is supported only for serverless clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AgileServerless</para>
        /// </summary>
        [NameInMap("ServerlessType")]
        [Validation(Required=false)]
        public string ServerlessType { get; set; }

        /// <summary>
        /// <para>The ID of the source ApsaraDB RDS instance or source PolarDB cluster. This parameter is required only if <b>CreationOption</b> is set to <b>MigrationFromRDS</b>, <b>CloneFromRDS</b>, <b>CloneFromPolarDB</b>, or <b>RecoverFromRecyclebin</b>.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>CreationOption</b> is set to <b>MigrationFromRDS</b> or <b>CloneFromRDS</b>, specify the ID of the source ApsaraDB RDS instance. The source ApsaraDB RDS instance must be ApsaraDB RDS for MySQL 5.6, 5.7, or 8.0 High-availability Edition.</para>
        /// </description></item>
        /// <item><description><para>If <b>CreationOption</b> is set to <b>CloneFromPolarDB</b>, specify the ID of the source PolarDB cluster. The new cluster must use the same database engine as the source cluster. For example, if the source cluster runs MySQL 8.0, you must set <b>DBType</b> to <b>MySQL</b> and <b>DBVersion</b> to <b>8.0</b> for the new cluster.</para>
        /// </description></item>
        /// <item><description><para>If <b>CreationOption</b> is set to <b>RecoverFromRecyclebin</b>, specify the ID of the released source PolarDB cluster. The restored cluster must use the same database engine as the source cluster. For example, if the source cluster runs MySQL 8.0, you must set <b>DBType</b> to <b>MySQL</b> and <b>DBVersion</b> to <b>8.0</b> for the restored cluster.</para>
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
        /// <para>The UID of the source backup set owner in cross-account backup and restoration scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1022xxxxxxxx</para>
        /// </summary>
        [NameInMap("SourceUid")]
        [Validation(Required=false)]
        public long? SourceUid { get; set; }

        /// <summary>
        /// <para>The zone for the hot standby cluster.</para>
        /// <remarks>
        /// <para>This parameter is valid only when the hot standby cluster feature or multi-AZ strong consistency is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("StandbyAZ")]
        [Validation(Required=false)]
        public string StandbyAZ { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic storage scaling for a Standard Edition cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Enable: enables automatic storage scaling.</para>
        /// </description></item>
        /// <item><description><para>Disable: disables automatic storage scaling.</para>
        /// </description></item>
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
        /// <item><description><para><b>true</b>: enables cloud disk encryption.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): disables cloud disk encryption.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only if <b>DBType</b> is set to <b>MySQL</b>.</para>
        /// </remarks>
        /// <remarks>
        /// <para>This parameter is valid only if <b>StorageType</b> is set to a Standard Edition storage type.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("StorageEncryption")]
        [Validation(Required=false)]
        public bool? StorageEncryption { get; set; }

        /// <summary>
        /// <para>The ID of a custom key from Key Management Service (KMS) for cloud disk encryption. The key must be in the same region as the cluster. If you specify this parameter, cloud disk encryption is automatically enabled and cannot be disabled. If this parameter is empty, the default service key is used.</para>
        /// <para>You can view the key ID or create a new key in the Key Management Service (KMS) console.</para>
        /// <remarks>
        /// <para>This parameter is valid only if <b>DBType</b> is set to <b>MySQL</b>.</para>
        /// </remarks>
        /// <remarks>
        /// <para>This parameter is valid only if <b>StorageType</b> is set to a Standard Edition storage type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1022xxxxxxxx</para>
        /// </summary>
        [NameInMap("StorageEncryptionKey")]
        [Validation(Required=false)]
        public string StorageEncryptionKey { get; set; }

        /// <summary>
        /// <para>The billing method for storage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Postpaid: pay-by-capacity (a pay-as-you-go method).</para>
        /// </description></item>
        /// <item><description><para>Prepaid: pay-by-space (a subscription method).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("StoragePayType")]
        [Validation(Required=false)]
        public string StoragePayType { get; set; }

        /// <summary>
        /// <para>The storage space for a pay-by-space (subscription) cluster. Unit: GB.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Valid values for a PolarDB for MySQL Enterprise Edition cluster: 10 to 50000.</para>
        /// </description></item>
        /// <item><description><para>Valid values for a PolarDB for MySQL Standard Edition cluster: 20 to 64000.</para>
        /// </description></item>
        /// <item><description><para>If the storage type of a Standard Edition cluster is ESSD AutoPL, the storage space must be a multiple of 10 between 40 and 64000.</para>
        /// </description></item>
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
        /// <para>Valid values for Enterprise Edition:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PSL5</b></para>
        /// </description></item>
        /// <item><description><para><b>PSL4</b></para>
        /// </description></item>
        /// </list>
        /// <para>Valid values for Standard Edition:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ESSDPL0</b></para>
        /// </description></item>
        /// <item><description><para><b>ESSDPL1</b></para>
        /// </description></item>
        /// <item><description><para><b>ESSDPL2</b></para>
        /// </description></item>
        /// <item><description><para><b>ESSDPL3</b></para>
        /// </description></item>
        /// <item><description><para><b>ESSDAUTOPL</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PSL4</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The maximum storage capacity for a Standard Edition cluster when automatic storage scaling is enabled. Unit: GB.</para>
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
        /// <para>Specifies whether to enable multi-AZ strong consistency for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ON</b>: enables multi-AZ strong consistency. This feature is applicable to Standard Edition clusters that are deployed across three zones.</para>
        /// </description></item>
        /// <item><description><para><b>OFF</b>: disables multi-AZ strong consistency.</para>
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
        /// <para>Specifies whether to enable transparent data encryption (TDE). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables TDE.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): disables TDE.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is valid only when <b>DBType</b> is set to <b>PostgreSQL</b> or <b>Oracle</b>.</para>
        /// </description></item>
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/167982.html">ModifyDBClusterTDE</a> operation to enable TDE for a PolarDB for MySQL cluster.</para>
        /// </description></item>
        /// <item><description><para>TDE cannot be disabled after it is enabled.</para>
        /// </description></item>
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
        /// <para>The tags to add to the cluster.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDBClusterRequestTag> Tag { get; set; }
        public class CreateDBClusterRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// <remarks>
            /// <para>You can add up to 20 tags at a time. The Nth tag is a key-value pair, where <c>Tag.N.Key</c> is the key and <c>Tag.N.Value</c> is the value.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>type</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// <remarks>
            /// <para>You can add up to 20 tags at a time. The Nth tag is a key-value pair, where <c>Tag.N.Key</c> is the key and <c>Tag.N.Value</c> is the value.</para>
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
        /// <para>The subscription duration. This parameter is required if you set the <b>PayType</b> parameter to <b>Prepaid</b>.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>Period</b> is set to <b>Month</b>, <b>UsedTime</b> must be an integer from <c>[1-9]</c>.</para>
        /// </description></item>
        /// <item><description><para>If <b>Period</b> is set to <b>Year</b>, <b>UsedTime</b> must be an integer from <c>[1-3]</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-**********</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The ID of the VSwitch.</para>
        /// <remarks>
        /// <para>If you specify the VPCId parameter, you must also specify this parameter.</para>
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
