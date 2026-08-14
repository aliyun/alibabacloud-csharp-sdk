// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyDtsJobEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that owns the database instance.</para>
        /// <remarks>
        /// <para>Specifying this parameter indicates cross-account data synchronization. You must also specify the <b>RoleName</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>150780020300****</para>
        /// </summary>
        [NameInMap("AliyunUid")]
        [Validation(Required=false)]
        public string AliyunUid { get; set; }

        /// <summary>
        /// <para>The database name when the database type is <b>PostgreSQL</b>, <b>PolarDB for PostgreSQL</b>, or <b>AnalyticDB PostgreSQL</b>. The authentication database name when the database type is <b>MongoDB</b>.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when the database type is <b>PostgreSQL</b>, <b>PolarDB for PostgreSQL</b>, <b>AnalyticDB PostgreSQL</b>, or <b>MongoDB</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. If the dry run succeeds, the instance is not modified.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and then modifies the database instance of the DTS task if the dry run succeeds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the DTS instance.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, you must specify <b>DtsJobId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtsaw012y2g15q****</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The DTS task ID. You can call <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> to query the task ID.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, you must specify <b>DtsInstanceId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>m4312mab158****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The database instance to modify. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>src</b>: source instance.</description></item>
        /// <item><description><b>dest</b>: destination instance.</description></item>
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
        /// <para>The ID of the database instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp10k50h8374w****</para>
        /// </summary>
        [NameInMap("EndpointInstanceId")]
        [Validation(Required=false)]
        public string EndpointInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the database instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>rds</b>: ApsaraDB RDS for MySQL or ApsaraDB RDS for PostgreSQL.</description></item>
        /// <item><description><b>polardb</b>: PolarDB for MySQL or PolarDB for PostgreSQL.</description></item>
        /// <item><description><b>mongodb</b>: when used as the source, ApsaraDB for MongoDB (replica set architecture). When used as the destination, ApsaraDB for MongoDB (replica set or sharded cluster architecture).</description></item>
        /// <item><description><b>distributed_mongodb</b>: supported only as the source of a distributed instance. Indicates ApsaraDB for MongoDB (sharded cluster architecture).</description></item>
        /// </list>
        /// <remarks>
        /// <para>The incremental node of a distributed instance must obtain data changes from the source through Oplog.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>greenplum</b>: cloud-native data warehouse AnalyticDB for PostgreSQL.</description></item>
        /// <item><description><b>kafka</b>: ApsaraMQ for Kafka.</description></item>
        /// <item><description><b>ecs</b>: a self-managed database hosted on an ECS instance (only supported database types).</description></item>
        /// <item><description><b>express</b>: a database connected over Express Connect (only supported database types).</description></item>
        /// <item><description><b>other</b>: a database connected over the Internet (only supported database types).</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Currently supported database types include <b>MySQL</b>, <b>PolarDB for MySQL</b>, <b>PostgreSQL</b>, <b>PolarDB for PostgreSQL</b>, <b>MongoDB</b>, <b>Kafka</b>, and <b>AnalyticDB PostgreSQL</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the database is MongoDB (sharded cluster), the number of shards in the new database must be the same as that in the original MongoDB (sharded cluster).</description></item>
        /// <item><description>If you want to modify the source instance and the database type is <b>PostgreSQL</b>, make sure that the latency of the DTS instance is less than 30 seconds and stop writing data to the source. Otherwise, data inconsistency may occur.</description></item>
        /// <item><description>The parameter values are case-insensitive.</description></item>
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
        /// <para>The IP address of the database instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.168.XX.XXX</para>
        /// </summary>
        [NameInMap("EndpointIp")]
        [Validation(Required=false)]
        public string EndpointIp { get; set; }

        /// <summary>
        /// <para>The port of the database instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("EndpointPort")]
        [Validation(Required=false)]
        public string EndpointPort { get; set; }

        /// <summary>
        /// <para>The region to which the database instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("EndpointRegionId")]
        [Validation(Required=false)]
        public string EndpointRegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to modify the account and password. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes.</description></item>
        /// <item><description><b>false</b> (default): no.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ModifyAccount")]
        [Validation(Required=false)]
        public bool? ModifyAccount { get; set; }

        /// <summary>
        /// <para>The database password.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>ModifyAccount</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DTStest****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The region to which the DTS instance belongs.</para>
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
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the RAM role for cross-account access.</para>
        /// <remarks>
        /// <para>This parameter is required when you perform cross-account data synchronization. For the permissions required by this role and how to grant them, see <a href="https://help.aliyun.com/document_detail/48468.html">Configure RAM authorization for cross-account data migration or synchronization</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ram-for-dts</para>
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// <para>The password of the shard in the MongoDB sharded cluster instance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available and required only when the source database instance is ApsaraDB for MongoDB (sharded cluster architecture).</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when <b>ModifyAccount</b> is set to <b>true</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DTStest****</para>
        /// </summary>
        [NameInMap("ShardPassword")]
        [Validation(Required=false)]
        public string ShardPassword { get; set; }

        /// <summary>
        /// <para>The account of the shard in the MongoDB sharded cluster instance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available and required only when the source database instance is ApsaraDB for MongoDB (sharded cluster architecture).</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when <b>ModifyAccount</b> is set to <b>true</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>shard</para>
        /// </summary>
        [NameInMap("ShardUsername")]
        [Validation(Required=false)]
        public string ShardUsername { get; set; }

        /// <summary>
        /// <para>The synchronization direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Forward</b> (default): forward.</description></item>
        /// <item><description><b>Reverse</b>: reverse.</description></item>
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
        /// <para>This parameter takes effect only when <b>ModifyAccount</b> is set to <b>true</b>.</para>
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
