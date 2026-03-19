// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class ModifyBackupSourceEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The backup gateway ID. Call <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> to get this value.</para>
        /// <remarks>
        /// <para>You must specify this parameter when <b>SourceEndpointInstanceType</b> is Agent.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>21321323213</para>
        /// </summary>
        [NameInMap("BackupGatewayId")]
        [Validation(Required=false)]
        public long? BackupGatewayId { get; set; }

        /// <summary>
        /// <para>The backup objects. This parameter is optional when SourceEndpointInstanceType is Agent. For all other cases, you must specify it. Call <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> to get this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{  &quot;DBName&quot;:&quot;待备份库名&quot;, &quot;SchemaName&quot;:&quot;待备份 Schema 名&quot;, &quot;TableIncludes&quot;:[{ &quot;TableName&quot;:&quot;待备份表表名&quot; }],  &quot;TableExcludes&quot;:[{&quot;TableName&quot;:&quot;待备份库名不需要备份表的表名&quot; }] } ]</para>
        /// </summary>
        [NameInMap("BackupObjects")]
        [Validation(Required=false)]
        public string BackupObjects { get; set; }

        /// <summary>
        /// <para>The backup plan ID. Call <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> to get this value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbs1h****usfa</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>A unique string that ensures idempotence and prevents duplicate requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account used for cross-account backup. Call <a href="https://help.aliyun.com/document_detail/2869838.html">DescribeRestoreTaskList</a> to get this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2xxx7778xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("CrossAliyunId")]
        [Validation(Required=false)]
        public string CrossAliyunId { get; set; }

        /// <summary>
        /// <para>The RAM role name used for cross-account backup. Call <a href="https://help.aliyun.com/document_detail/2869838.html">DescribeRestoreTaskList</a> to get this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("CrossRoleName")]
        [Validation(Required=false)]
        public string CrossRoleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSourceEndpointSsl")]
        [Validation(Required=false)]
        public string EnableSourceEndpointSsl { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// <list type="bullet">
        /// <item><description><para>You must specify this parameter for PostgreSQL or MongoDB databases.</para>
        /// </description></item>
        /// <item><description><para>You must specify this parameter for Microsoft SQL Server databases connected through a backup gateway.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SourceEndpointDatabaseName")]
        [Validation(Required=false)]
        public string SourceEndpointDatabaseName { get; set; }

        /// <summary>
        /// <para>The database endpoint. Call <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> to get this value.</para>
        /// <remarks>
        /// <para>You must specify this parameter when <b>SourceEndpointInstanceType</b> is Express, Agent, or Other.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100.<em>.</em>.10:3306</para>
        /// </summary>
        [NameInMap("SourceEndpointIP")]
        [Validation(Required=false)]
        public string SourceEndpointIP { get; set; }

        /// <summary>
        /// <para>The database instance ID. Call <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> to get this value.</para>
        /// <remarks>
        /// <para>You must specify this parameter when <b>SourceEndpointInstanceType</b> is RDS, ECS, DDS, or Express.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1p8c29479jv****</para>
        /// </summary>
        [NameInMap("SourceEndpointInstanceID")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceID { get; set; }

        /// <summary>
        /// <para>The location of the database. Call <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> to get this value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RDS</b></para>
        /// </description></item>
        /// <item><description><para><b>ECS</b></para>
        /// </description></item>
        /// <item><description><para><b>Express</b>: A database connected through a leased line, VPN Gateway, or Smart Access Gateway</para>
        /// </description></item>
        /// <item><description><para><b>Agent</b>: A database connected through a backup gateway</para>
        /// </description></item>
        /// <item><description><para><b>DDS</b>: A MongoDB instance on Alibaba Cloud</para>
        /// </description></item>
        /// <item><description><para><b>Other</b>: A database connected directly using an IP address and port</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("SourceEndpointInstanceType")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/home/test</para>
        /// </summary>
        [NameInMap("SourceEndpointOracleHome")]
        [Validation(Required=false)]
        public string SourceEndpointOracleHome { get; set; }

        /// <summary>
        /// <para>The Oracle system ID (SID). You must specify this parameter for Oracle databases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SourceEndpointOracleSID")]
        [Validation(Required=false)]
        public string SourceEndpointOracleSID { get; set; }

        /// <summary>
        /// <para>The password.</para>
        /// <para>This parameter is optional for Redis databases or for Microsoft SQL Server databases connected through a backup gateway. For all other cases, you must specify it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SourceEndpointPassword")]
        [Validation(Required=false)]
        public string SourceEndpointPassword { get; set; }

        /// <summary>
        /// <para>The database port. Call <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> to get this value.</para>
        /// <remarks>
        /// <para>You must specify this parameter when <b>SourceEndpointInstanceType</b> is Express, Agent, Other, or ECS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("SourceEndpointPort")]
        [Validation(Required=false)]
        public int? SourceEndpointPort { get; set; }

        /// <summary>
        /// <para>The region where the database is located. Call <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> to get this value.</para>
        /// <remarks>
        /// <para>You must specify this parameter when <b>SourceEndpointInstanceType</b> is RDS, ECS, DDS, Express, or Agent.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SourceEndpointRegion")]
        [Validation(Required=false)]
        public string SourceEndpointRegion { get; set; }

        /// <summary>
        /// <para>The database account. Call <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> to get this value.</para>
        /// <para>This parameter is optional for Redis databases or for Microsoft SQL Server databases connected through a backup gateway. For all other cases, you must specify it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SourceEndpointUserName")]
        [Validation(Required=false)]
        public string SourceEndpointUserName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE----- ... -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("SslCaPem")]
        [Validation(Required=false)]
        public string SslCaPem { get; set; }

    }

}
