// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the no-activity suspension feature. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only for serverless clusters.</para>
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
        /// <para>Specifies whether to enable automatic renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <para>Default value: <b>false</b>.</para>
        /// <remarks>
        /// <para>This parameter is valid only when the <b>PayType</b> parameter is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The retention policy for the backup sets when you delete the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALL</b>: permanently retains all backups.</description></item>
        /// <item><description><b>LATEST</b>: permanently retains the last backup. A backup is automatically created before you delete the cluster.</description></item>
        /// <item><description><b>NONE</b>: No backup sets are retained after the cluster is deleted.</description></item>
        /// </list>
        /// <para>The default value is <b>NONE</b> after you create a cluster.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is valid only when the <b>DBType</b> parameter is set to <b>MySQL</b>.</para>
        /// </description></item>
        /// <item><description><para>This parameter is invalid for serverless clusters.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public string BackupRetentionPolicyOnClusterDeletion { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length. The token is case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f5********************</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The point in time when you want to clone data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>LATEST</b>: The data of the latest point in time is cloned.</description></item>
        /// <item><description><b>BackupID</b>: You can specify the ID of a backup set. In this case, data is cloned based on the specified backup set.</description></item>
        /// <item><description><b>Timestamp</b>: You can specify a point in time in the past in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</description></item>
        /// </list>
        /// <para>Default value: <b>LATEST</b>.</para>
        /// <remarks>
        /// <para>If the <b>CreationOption</b> parameter is set to <b>CloneFromRDS</b>, the value of this parameter must be <b>LATEST</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>LATEST</para>
        /// </summary>
        [NameInMap("CloneDataPoint")]
        [Validation(Required=false)]
        public string CloneDataPoint { get; set; }

        /// <summary>
        /// <para>The network type of the cluster. Only virtual private clouds (VPCs) are supported. Set the value to <b>VPC</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("ClusterNetworkType")]
        [Validation(Required=false)]
        public string ClusterNetworkType { get; set; }

        /// <summary>
        /// <para>The edition of the cluster. Default value: Normal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: Cluster Edition</description></item>
        /// <item><description><b>Basic</b>: Single Node Edition</description></item>
        /// <item><description><b>ArchiveNormal</b>: X-Engine Edition</description></item>
        /// <item><description><b>NormalMultimaster</b>: Multi-master Cluster Edition</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Only when the <b>DBType</b> parameter is set to <b>MySQL</b> and <b>the DBVersion</b> parameter is set to <b>5.6</b>, <b>5.7</b>, or <b>8.0</b>, you can set this parameter to <b>Basic</b>.</para>
        /// </description></item>
        /// <item><description><para>Only when the <b>DBType</b> parameter is set to <b>MySQL</b> and the <b>DBVersion</b> parameter is set to <b>8.0</b>, you can set this parameter to <b>ArchiveNormal</b> or <b>NormalMultimaster</b>.</para>
        /// </description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/183258.html">Product editions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("CreationCategory")]
        [Validation(Required=false)]
        public string CreationCategory { get; set; }

        /// <summary>
        /// <para>The method that is used to create a cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: creates a PolarDB cluster. For more information about how to perform this operation in the console, see the following topics:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/58769.html">Create a PolarDB for MySQL cluster</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/118063.html">Create a PolarDB for PostgreSQL cluster</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/118182.html">Create a PolarDB for Oracle cluster</a></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>CloneFromPolarDB</b>: clones data from an existing PolarDB cluster to a new PolarDB cluster. For more information about how to perform this operation in the console, see the following topics:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/87966.html">Clone a PolarDB for MySQL cluster</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/118108.html">Clone a PolarDB for PostgreSQL cluster</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/118221.html">Clone a PolarDB for Oracle cluster</a></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>CloneFromRDS</b>: clones data from an existing ApsaraDB RDS for MySQL instance to a new PolarDB for MySQL cluster. For more information about how to perform this operation in the console, see <a href="https://help.aliyun.com/document_detail/121812.html">Create a PolarDB for MySQL cluster by cloning an ApsaraDB RDS for MySQL instance</a>.</para>
        /// </description></item>
        /// <item><description><para><b>MigrationFromRDS</b>: migrates data from an existing ApsaraDB RDS for MySQL instance to a new PolarDB for MySQL cluster. By default, the created PolarDB cluster is in read-only mode, and the binary logging feature is enabled. For more information about how to perform this operation in the console, see <a href="https://help.aliyun.com/document_detail/121582.html">Create a PolarDB for MySQL cluster from an ApsaraDB RDS for MySQL instance</a>.</para>
        /// </description></item>
        /// <item><description><para><b>CreateGdnStandby</b>: creates a secondary cluster. For more information about how to perform this operation in the console, see <a href="https://help.aliyun.com/document_detail/160381.html">Add a secondary cluster</a>.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>Normal</b>.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If the <b>DBType</b> parameter is set to <b>MySQL</b> and the <b>DBVersion</b> parameter is set to <b>5.6</b> or <b>5.7</b>, this parameter can be set to <b>CloneFromRDS</b> or <b>MigrationFromRDS</b>.</para>
        /// </description></item>
        /// <item><description><para>If the <b>DBType</b> parameter is set to <b>MySQL</b> and the <b>DBVersion</b> parameter is set to <b>8.0</b>, this parameter can be set to <b>CreateGdnStandby</b>.</para>
        /// </description></item>
        /// </list>
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
        /// <para>The minor version of the database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>8.0.2</b></description></item>
        /// <item><description><b>8.0.1</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only when the <b>DBType</b> parameter is set to <b>MySQL</b> and the <b>DBVersion</b> parameter is set to <b>8.0</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8.0.1</para>
        /// </summary>
        [NameInMap("DBMinorVersion")]
        [Validation(Required=false)]
        public string DBMinorVersion { get; set; }

        /// <summary>
        /// <para>The specifications of the node.</para>
        /// <list type="bullet">
        /// <item><description>For more information about specifications supported by PolarDB for MySQL, see <a href="https://help.aliyun.com/document_detail/102542.html">Specifications of compute nodes</a>.</description></item>
        /// <item><description>For information about node specifications supported by the Oracle database engine, see <a href="https://help.aliyun.com/document_detail/207921.html">Specifications of compute nodes</a>.</description></item>
        /// <item><description>For information about node specifications supported by the PostgreSQL database engine, see <a href="https://help.aliyun.com/document_detail/209380.html">Specifications of compute nodes</a>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polar.mysql.x2.medium</para>
        /// </summary>
        [NameInMap("DBNodeClass")]
        [Validation(Required=false)]
        public string DBNodeClass { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DBNodeNum")]
        [Validation(Required=false)]
        public int? DBNodeNum { get; set; }

        /// <summary>
        /// <para>The type of the database engine. Valid values:</para>
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
        /// <para>The version of the database engine.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values for the MySQL database engine:</para>
        /// <list type="bullet">
        /// <item><description><b>5.6</b></description></item>
        /// <item><description><b>5.7</b></description></item>
        /// <item><description><b>8.0</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid values for the PostgreSQL database engine:</para>
        /// <list type="bullet">
        /// <item><description><b>11</b></description></item>
        /// <item><description><b>14</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid value for the Oracle database engine: <b>11</b></para>
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
        /// <para>The time zone of the cluster. The time must be in UTC. You can set the parameter to a value that is on the hour from <b>-12:00 to +13:00</b>. Example: 00:00. Default value: <b>SYSTEM</b>, which means that the value is the same as the time zone of the region.</para>
        /// <remarks>
        /// <para>This parameter is valid only when the <b>DBType</b> parameter is set to <b>MySQL</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM</para>
        /// </summary>
        [NameInMap("DefaultTimeZone")]
        [Validation(Required=false)]
        public string DefaultTimeZone { get; set; }

        /// <summary>
        /// <para>The ID of the Global Database Network (GDN).</para>
        /// <remarks>
        /// <para>This parameter is required only when the <b>CreationOption</b> parameter is set to <b>CreateGdnStandby</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gdn-***********</para>
        /// </summary>
        [NameInMap("GDNId")]
        [Validation(Required=false)]
        public string GDNId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("HotStandbyCluster")]
        [Validation(Required=false)]
        public string HotStandbyCluster { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("LoosePolarLogBin")]
        [Validation(Required=false)]
        public string LoosePolarLogBin { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable X-Engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ON</b></description></item>
        /// <item><description><b>OFF</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only if you do not set <b>CreationOption</b> to <b>CreateGdnStandby</b> and you set <b>DBType</b> to <b>MySQL</b> and <b>DBVersion</b> to <b>8.0</b>. To enable X-Engine on a node, make sure that the memory of the node is greater than or equal to 8 GB in size.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("LooseXEngine")]
        [Validation(Required=false)]
        public string LooseXEngine { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("LooseXEngineUseMemoryPct")]
        [Validation(Required=false)]
        public string LooseXEngineUseMemoryPct { get; set; }

        /// <summary>
        /// <para>Specifies whether the table names are case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: The table names are case-insensitive.</description></item>
        /// <item><description><b>0</b>: The table names are case-sensitive.</description></item>
        /// </list>
        /// <para>Default value: <b>1</b>.</para>
        /// <remarks>
        /// <para>This parameter is valid only when the <b>DBType</b> parameter is set to <b>MySQL</b>.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/207178.html">DescribeParameterGroups</a> operation to query the details of all parameter templates of a specified region, such as the ID of a parameter template.</para>
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
        /// <item><description><b>Postpaid</b>: pay-as-you-go</description></item>
        /// <item><description><b>Prepaid</b>: subscription</description></item>
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
        /// <para>The subscription type of the subscription cluster. This parameter is required only when the PayType parameter is set to <b>Prepaid</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: annual subscription. Unit: years.</description></item>
        /// <item><description><b>Month</b>: monthly subscription. Unit: months.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}</para>
        /// <para>Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}</para>
        /// <remarks>
        /// <para> This parameter is available only if the StorageType parameter is set to ESSDAUTOPL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>polar.maxscale.g2.medium.c</para>
        /// </summary>
        [NameInMap("ProxyClass")]
        [Validation(Required=false)]
        public string ProxyClass { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Exclusive</para>
        /// </summary>
        [NameInMap("ProxyType")]
        [Validation(Required=false)]
        public string ProxyType { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster.</para>
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
        /// <para>The maximum number of PCUs per node for scaling. Valid values: 1 PCU to 32 PCUs.</para>
        /// <remarks>
        /// <para>This parameter is valid only for serverless clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ScaleMax")]
        [Validation(Required=false)]
        public string ScaleMax { get; set; }

        /// <summary>
        /// <para>The minimum number of PCUs per node for scaling. Valid values: 1 PCU to 31 PCUs.</para>
        /// <remarks>
        /// <para>This parameter is valid only for serverless clusters.</para>
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
        /// <para>This parameter is valid only for serverless clusters.</para>
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
        /// <para>This parameter is valid only for serverless clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ScaleRoNumMin")]
        [Validation(Required=false)]
        public string ScaleRoNumMin { get; set; }

        /// <summary>
        /// <para>The IP whitelist of the cluster.</para>
        /// <remarks>
        /// <para>The whitelist can contain multiple IP addresses. Separate multiple IP addresses with commas (,).</para>
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
        /// <para>This parameter is valid only for serverless clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AgileServerless</para>
        /// </summary>
        [NameInMap("ServerlessType")]
        [Validation(Required=false)]
        public string ServerlessType { get; set; }

        /// <summary>
        /// <para>The ID of the source ApsaraDB RDS instance or PolarDB cluster. This parameter is required only when the <b>CreationOption</b> parameter is set to <b>MigrationFromRDS</b>, <b>CloneFromRDS</b>, or <b>CloneFromPolarDB</b>.</para>
        /// <list type="bullet">
        /// <item><description>If the <b>CreationOption</b> parameter is set to <b>MigrationFromRDS</b> or <b>CloneFromRDS</b>, you must set this parameter to the ID of the source ApsaraDB RDS instance. The source ApsaraDB RDS instance must use ApsaraDB RDS for MySQL 5.6, 5.7, or 8.0 High-availability Edition.</description></item>
        /// <item><description>If the <b>CreationOption</b> parameter is set to <b>CloneFromPolarDB</b>, you must set this parameter to the ID of the source PolarDB cluster. By default, the value of DBType of the destination cluster must be the same as that of the source cluster. For example, if a MySQL 8.0 cluster is used as the source cluster, you must set the <b>DBType</b> parameter to <b>MySQL</b> and the <b>DBVersion</b> parameter to <b>8.0</b> for the destination cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rm-*************</para>
        /// </summary>
        [NameInMap("SourceResourceId")]
        [Validation(Required=false)]
        public string SourceResourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("StandbyAZ")]
        [Validation(Required=false)]
        public string StandbyAZ { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("StorageAutoScale")]
        [Validation(Required=false)]
        public string StorageAutoScale { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("StoragePayType")]
        [Validation(Required=false)]
        public string StoragePayType { get; set; }

        /// <summary>
        /// <para>The storage space that uses the subscription billing method. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("StorageSpace")]
        [Validation(Required=false)]
        public long? StorageSpace { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values for Enterprise Edition:</para>
        /// <list type="bullet">
        /// <item><description><b>PSL5</b></description></item>
        /// <item><description><b>PSL4</b></description></item>
        /// </list>
        /// <para>Valid values for Standard Edition:</para>
        /// <list type="bullet">
        /// <item><description><b>ESSDPL0</b></description></item>
        /// <item><description><b>ESSDPL1</b></description></item>
        /// <item><description><b>ESSDPL2</b></description></item>
        /// <item><description><b>ESSDPL3</b></description></item>
        /// <item><description><b>ESSDAUTOPL</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is invalid for serverless clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PSL4</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("StorageUpperBound")]
        [Validation(Required=false)]
        public long? StorageUpperBound { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable multi-zone data consistency. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ON</b>: enables multi-zone data consistency. Set this parameter to ON for Standard Edition clusters of Multi-zone Edition.</description></item>
        /// <item><description><b>OFF</b>: disables multi-zone data consistency.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("StrictConsistency")]
        [Validation(Required=false)]
        public string StrictConsistency { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable transparent data encryption (TDE). Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is valid only when the <b>DBType</b> parameter is set to <b>PostgreSQL</b> or <b>Oracle</b>.</para>
        /// </description></item>
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/167982.html">ModifyDBClusterTDE</a> operation to enable TDE for a PolarDB for MySQL cluster.</para>
        /// </description></item>
        /// <item><description><para>TDE cannot be disabled after it is enabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TDEStatus")]
        [Validation(Required=false)]
        public bool? TDEStatus { get; set; }

        /// <summary>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDBClusterRequestTag> Tag { get; set; }
        public class CreateDBClusterRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag that you want to create for the cluster. To create multiple tags for a cluster at a time, click the <b>+</b> icon.</para>
            /// <remarks>
            /// <para>You can create up to 20 key-value pairs of tags at a time. Each value of the <c>Tag.N.Key</c> parameter is paired with a value of the <c>Tag.N.Value</c> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>type</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag that you want to create for the cluster. To create multiple tags for a cluster at a time, click the <b>+</b> icon.</para>
            /// <remarks>
            /// <para>You can create up to 20 key-value pairs of tags at a time. Each value of the <c>Tag.N.Value</c> parameter is paired with a value of the <c>Tag.N.Key</c> parameter.</para>
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
        /// <list type="bullet">
        /// <item><description>If the <b>Period</b> parameter is set to <b>Month</b>, the <b>UsedTime</b> parameter can be set to <c>1, 2, 3, 4, 5, 6, 7, 8, or 9</c>.</description></item>
        /// <item><description>If the <b>Period</b> parameter is set to <b>Year</b>, the <b>UsedTime</b> parameter can be set to <c>1, 2, or 3</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-**********</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the cluster.</para>
        /// <remarks>
        /// <para>If the VPCId parameter is specified, the VSwitchId parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-**********</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query available zones.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
