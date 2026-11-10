// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class ModifyBackupSourceEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The backup gateway ID. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to get this value.</para>
        /// <remarks>
        /// <para>This parameter is required if the <b>SourceEndpointInstanceType</b> parameter is set to <c>Agent</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>21321323213</para>
        /// </summary>
        [NameInMap("BackupGatewayId")]
        [Validation(Required=false)]
        public long? BackupGatewayId { get; set; }

        /// <summary>
        /// <para>Backup objects: This parameter is optional if the database is located on an agent, but required for all other scenarios. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to obtain the value of this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{  &quot;DBName&quot;:&quot;待备份库名&quot;, &quot;SchemaName&quot;:&quot;待备份 Schema 名&quot;, &quot;TableIncludes&quot;:[{ &quot;TableName&quot;:&quot;待备份表表名&quot; }],  &quot;TableExcludes&quot;:[{&quot;TableName&quot;:&quot;待备份库名不需要备份表的表名&quot; }] } ]</para>
        /// </summary>
        [NameInMap("BackupObjects")]
        [Validation(Required=false)]
        public string BackupObjects { get; set; }

        /// <summary>
        /// <para>The backup plan ID. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to get this value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbs1h****usfa</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>A client-generated token to ensure request idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The UID for cross-account backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2xxx7778xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("CrossAliyunId")]
        [Validation(Required=false)]
        public string CrossAliyunId { get; set; }

        /// <summary>
        /// <para>The RAM role name for cross-account backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("CrossRoleName")]
        [Validation(Required=false)]
        public string CrossRoleName { get; set; }

        /// <summary>
        /// <para>Specifies whether to use an SSL connection to back up the source database.</para>
        /// 
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
        /// <item><description><para>This parameter is required for PostgreSQL and MongoDB databases.</para>
        /// </description></item>
        /// <item><description><para>This parameter is also required for Microsoft SQL Server databases when the <b>SourceEndpointInstanceType</b> parameter is set to \&quot;Agent\&quot;.</para>
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
        /// <para>The IP address of the database. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to get this value.</para>
        /// <remarks>
        /// <para>This parameter is required if the <b>SourceEndpointInstanceType</b> parameter is set to <c>Express</c>, <c>Agent</c>, or <c>Other</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100.<em>.</em>.10:3306</para>
        /// </summary>
        [NameInMap("SourceEndpointIP")]
        [Validation(Required=false)]
        public string SourceEndpointIP { get; set; }

        /// <summary>
        /// <para>The database instance ID. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to get this value.</para>
        /// <remarks>
        /// <para>This parameter is required if the <b>SourceEndpointInstanceType</b> parameter is set to <c>RDS</c>, <c>ECS</c>, <c>DDS</c>, or <c>Express</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1p8c29479jv****</para>
        /// </summary>
        [NameInMap("SourceEndpointInstanceID")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceID { get; set; }

        /// <summary>
        /// <para>The type of the source instance. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to get this value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RDS</b>: an RDS instance</para>
        /// </description></item>
        /// <item><description><para><b>ECS</b>: a self-managed database on an ECS instance</para>
        /// </description></item>
        /// <item><description><para><b>Express</b>: a database connected over a leased line, VPN Gateway, or Smart Access Gateway</para>
        /// </description></item>
        /// <item><description><para><b>Agent</b>: a database connected over a backup gateway</para>
        /// </description></item>
        /// <item><description><para><b>DDS</b>: an ApsaraDB for MongoDB instance</para>
        /// </description></item>
        /// <item><description><para><b>Other</b>: a database connected over an IP address and port</para>
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
        /// <para>The Oracle Home path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home/test</para>
        /// </summary>
        [NameInMap("SourceEndpointOracleHome")]
        [Validation(Required=false)]
        public string SourceEndpointOracleHome { get; set; }

        /// <summary>
        /// <para>The Oracle SID. This parameter is required for Oracle databases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SourceEndpointOracleSID")]
        [Validation(Required=false)]
        public string SourceEndpointOracleSID { get; set; }

        /// <summary>
        /// <para>The password for the database account.</para>
        /// <para>This parameter is required for all database engines except for Redis and Microsoft SQL Server (when the <b>SourceEndpointInstanceType</b> parameter is set to \&quot;Agent\&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SourceEndpointPassword")]
        [Validation(Required=false)]
        public string SourceEndpointPassword { get; set; }

        /// <summary>
        /// <para>The database port. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to get this value.</para>
        /// <remarks>
        /// <para>This parameter is required if the <b>SourceEndpointInstanceType</b> parameter is set to <c>Express</c>, <c>Agent</c>, <c>Other</c>, or <c>ECS</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("SourceEndpointPort")]
        [Validation(Required=false)]
        public int? SourceEndpointPort { get; set; }

        /// <summary>
        /// <para>The database region. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to get this value.</para>
        /// <remarks>
        /// <para>This parameter is required if the <b>SourceEndpointInstanceType</b> parameter is set to <c>RDS</c>, <c>ECS</c>, <c>DDS</c>, <c>Express</c>, or <c>Agent</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SourceEndpointRegion")]
        [Validation(Required=false)]
        public string SourceEndpointRegion { get; set; }

        /// <summary>
        /// <para>The username of the database account. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to get this value.</para>
        /// <para>This parameter is required for all database engines except for Redis and Microsoft SQL Server (when the <b>SourceEndpointInstanceType</b> parameter is set to \&quot;Agent\&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SourceEndpointUserName")]
        [Validation(Required=false)]
        public string SourceEndpointUserName { get; set; }

        /// <summary>
        /// <para>The PEM certificate for the SSL connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE----- ... -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("SslCaPem")]
        [Validation(Required=false)]
        public string SslCaPem { get; set; }

    }

}
