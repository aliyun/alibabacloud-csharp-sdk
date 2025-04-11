// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyDtsJobEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account (primary account) to which the database instance belongs.</para>
        /// <remarks>
        /// <para> Passing this parameter indicates that cross-Alibaba Cloud account data synchronization will be performed, and you also need to pass the <b>RoleName</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>150780020300****</para>
        /// </summary>
        [NameInMap("AliyunUid")]
        [Validation(Required=false)]
        public string AliyunUid { get; set; }

        /// <summary>
        /// <para>When the database type is <b>PostgreSQL</b>, <b>PolarDB for PostgreSQL</b>, or <b>AnalyticDB PostgreSQL</b>, it represents the database name; when the database type is <b>MongoDB</b>, it represents the authentication database name.</para>
        /// <remarks>
        /// <para>This parameter is only available and must be provided when the database type is <b>PostgreSQL</b>, <b>PolarDB for PostgreSQL</b>, <b>AnalyticDB PostgreSQL</b>, or <b>MongoDB</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a precheck. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes. After the precheck is passed, the database is not changed.</description></item>
        /// <item><description><b>false</b> (default): No. After the precheck is passed, the system changes the original database of the DTS task and runs the task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the DTS instance. If this parameter is not provided, <b>DtsJobId</b> must be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsaw012y2g15q****</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>DTS job ID, which can be queried by calling <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a>.</para>
        /// <remarks>
        /// <para>If this parameter is not provided, <b>DtsInstanceId</b> must be filled in.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>m4312mab158****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The database instance to be modified, with values:</para>
        /// <list type="bullet">
        /// <item><description><b>src</b>: Source database instance. - <b>dest</b>: Target database instance.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>src</para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>ID of the database instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp10k50h8374w****</para>
        /// </summary>
        [NameInMap("EndpointInstanceId")]
        [Validation(Required=false)]
        public string EndpointInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>rds</b>: ApsaraDB RDS for MySQL instance, ApsaraDB RDS for SQL Server instance, or ApsaraDB RDS for PostgreSQL instance.</description></item>
        /// <item><description><b>polardb</b>: PolarDB for MySQL cluster or PolarDB for PostgreSQL cluster.</description></item>
        /// <item><description><b>mongodb</b>: ApsaraDB for MongoDB replica set instance.</description></item>
        /// <item><description><b>distributed_mongodb</b>: ApsaraDB for MongoDB sharded cluster instance.</description></item>
        /// <item><description><b>greenplum</b>: AnalyticDB for PostgreSQL instance.</description></item>
        /// <item><description><b>kafka</b>: ApsaraMQ for Kafka instance.</description></item>
        /// <item><description><b>ecs</b>: self-managed database that is hosted on an Elastic Compute Service (ECS) instance. If you set this parameter to ecs, the database must be the supported one.</description></item>
        /// <item><description><b>express</b>: database that is connected over Express Connect. If you set this parameter to express, the database must be the supported one.</description></item>
        /// <item><description><b>other</b>: database that is connected over Internet. If you set this parameter to other, the database must be the supported one.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The following types of databases are supported: <b>MySQL</b>, <b>PolarDB for MySQL</b>, <b>PostgreSQL</b>, <b>PolarDB for PostgreSQL</b>, <b>MongoDB</b>, <b>SQL Server</b>, <b>Kafka</b>, and <b>AnalyticDB for PostgreSQL</b>.</para>
        /// </description></item>
        /// <item><description><para>If the original database is an ApsaraDB for MongoDB sharded cluster instance, the new database must have the same number of shards as the original database.</para>
        /// </description></item>
        /// <item><description><para>If the database that you want to change is a source <b>PostgreSQL</b> database, you must make sure that the latency of the DTS instance is less than 30 seconds and no data is written to the source database during the change. Otherwise, data inconsistency may occur.</para>
        /// </description></item>
        /// <item><description><para>The value of this parameter is case-insensitive.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("EndpointInstanceType")]
        [Validation(Required=false)]
        public string EndpointInstanceType { get; set; }

        /// <summary>
        /// <para>The IP of the database instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.168.XX.XXX</para>
        /// </summary>
        [NameInMap("EndpointIp")]
        [Validation(Required=false)]
        public string EndpointIp { get; set; }

        /// <summary>
        /// <para>port of the database instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("EndpointPort")]
        [Validation(Required=false)]
        public string EndpointPort { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the database resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("EndpointRegionId")]
        [Validation(Required=false)]
        public string EndpointRegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to change the password of the database account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ModifyAccount")]
        [Validation(Required=false)]
        public bool? ModifyAccount { get; set; }

        /// <summary>
        /// <para>The password of the database account.</para>
        /// <remarks>
        /// <para> This parameter is valid only if <b>ModifyAccount</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DTStest****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the DTS instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Cross Alibaba Cloud account role name. When performing data synchronization across Alibaba Cloud accounts, this parameter must be passed. For the required permissions and authorization methods for this role, please refer to <a href="https://help.aliyun.com/document_detail/48468.html">How to Configure RAM Authorization for Cross-Account Data Migration or Synchronization</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ram-for-dts</para>
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// <para>The account password of the shard of the ApsaraDB for MongoDB sharded cluster instance.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is valid and required only if the source database is an ApsaraDB for MongoDB sharded cluster instance.</para>
        /// </description></item>
        /// <item><description><para>This parameter is valid only if <b>ModifyAccount</b> is set to <b>true</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DTStest****</para>
        /// </summary>
        [NameInMap("ShardPassword")]
        [Validation(Required=false)]
        public string ShardPassword { get; set; }

        /// <summary>
        /// <para>The account username of the shard of the ApsaraDB for MongoDB sharded cluster instance.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is valid and required only if the source database is an ApsaraDB for MongoDB sharded cluster instance.</para>
        /// </description></item>
        /// <item><description><para>This parameter is valid only if <b>ModifyAccount</b> is set to <b>true</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>shard</para>
        /// </summary>
        [NameInMap("ShardUsername")]
        [Validation(Required=false)]
        public string ShardUsername { get; set; }

        /// <summary>
        /// <para>Synchronization direction, with values:</para>
        /// <list type="bullet">
        /// <item><description><b>Forward</b> (default): Forward. - <b>Reverse</b>: Reverse.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        /// <summary>
        /// <para>The database account.</para>
        /// <remarks>
        /// <para> This parameter is valid only if <b>ModifyAccount</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtstest</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        [NameInMap("ZeroEtlJob")]
        [Validation(Required=false)]
        public bool? ZeroEtlJob { get; set; }

    }

}
