// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceConfigRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the configuration item to modify. This parameter is used together with ConfigValue.</para>
        /// <details>
        /// <summary>ApsaraDB RDS for PostgreSQL configuration items</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><b>pgbouncer</b>: Modifies the PgBouncer feature.</description></item>
        /// <item><description><b>encryptionKey</b>: Modifies the cloud disk encryption feature.</description></item>
        /// <item><description><b>duckdb_create_databases</b>: Configures databases of the primary instance as DuckDB column store databases in batches.</description></item>
        /// <item><description><b>duckdb_prepare_dependency</b>: Configures the primary instance with one click so that its parameters and minor engine version meet the <a href="https://help.aliyun.com/document_detail/2977241.html">prerequisites</a> for creating a DuckDB-based analytical instance. If the primary instance already has read-only instances, the read-only instances are also updated.</description></item>
        /// <item><description><b>enable_db_visible_by_connect_rls</b>: Enables CONNECT RLS on the instance to control database visibility.</description></item>
        /// <item><description><b>set_db_visible_by_connect_rls</b>: Enables CONNECT RLS on a database to control database visibility. This can be called only after CONNECT RLS is enabled on the instance.</description></item>
        /// </list>
        /// </details>
        /// 
        /// <details>
        /// <summary>ApsaraDB RDS for SQL Server configuration items</summary>
        /// 
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>clear_errorlog</b>: Clears error logs.</description></item>
        /// <item><description><b>encryptionKey</b>: Modifies the cloud disk encryption feature. Serverless instances and shared instance types do not support this feature.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>backup_recovery_model</b>: Enables the simple recovery model feature. Only Basic Edition instances support this feature. <b>This feature cannot be disabled after it is enabled</b>.</description></item>
        /// <item><description><b>clear_errorlog</b>: Clears error logs.</description></item>
        /// <item><description><b>encryptionKey</b>: Modifies the cloud disk encryption feature. Serverless instances and shared instance types do not support this feature.</description></item>
        /// </list>
        /// </details>
        /// 
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgbouncer</para>
        /// </summary>
        [NameInMap("ConfigName")]
        [Validation(Required=false)]
        public string ConfigName { get; set; }

        /// <summary>
        /// <para>The value of the configuration item to modify. This parameter is used together with ConfigName.</para>
        /// <details>
        /// <summary>ApsaraDB RDS for PostgreSQL configuration item values</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>PgBouncer feature: <b>true</b> (enable) or <b>false</b> (disable).</description></item>
        /// <item><description>Cloud disk encryption feature:<list type="bullet">
        /// <item><description><b>ServiceKey</b>: Uses an automatically generated key from Alibaba Cloud, which is the RDS-managed service key (Default Service CMK), to enable cloud disk encryption.</description></item>
        /// <item><description><b><Key></b>: Uses a custom key to enable cloud disk encryption or replaces the current key. Example: <c>494c98ce-f2b5-48ab-96ab-36c986b6****</c>.</description></item>
        /// <item><description><b>disabled</b>: Disables cloud disk encryption.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>One-click fix for prerequisites to create a DuckDB-based analytical instance: <b>duckdb_prepare_dependency</b></description></item>
        /// <item><description>Configure databases of the primary instance as DuckDB column store databases in batches. The value is a JSON string. Example: <c>{&quot;dbNames&quot;: &quot;db1,db2,db3&quot;, &quot;accountName&quot;: &quot;yourSuperAccountName&quot;}</c>, where:<list type="bullet">
        /// <item><description><b>dbNames</b>: The names of databases to convert to DuckDB column store databases. Separate multiple database names with commas (,).</description></item>
        /// <item><description><b>accountName</b>: The privileged user. Specify only one privileged user.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Enable CONNECT RLS on the instance to control database visibility: <b>true</b> to enable.</description></item>
        /// <item><description>Enable CONNECT RLS on a database to control database visibility: The <b>database names</b> managed by CONNECT RLS. Separate multiple database names with commas (,). Example: <b>testdb1,testdb2</b>. When a client connects to a database with CONNECT RLS enabled, the database list is displayed based on whether the client has CONNECT permissions on other databases.</details>
        /// <details>
        /// <summary>ApsaraDB RDS for SQL Server configuration item values</summary></description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Error log cleanup feature: <b>1</b> (confirm cleanup).</description></item>
        /// <item><description>Cloud disk encryption feature (<b>this feature cannot be disabled after it is enabled</b>):<list type="bullet">
        /// <item><description><b>serviceKey</b>: Uses an automatically generated key from Alibaba Cloud, which is the RDS-managed service key (Default Service CMK), to enable cloud disk encryption.</description></item>
        /// <item><description><b><Key></b>: Uses a custom key to enable cloud disk encryption or replaces the current key. Example: <c>494c98ce-f2b5-48ab-96ab-36c986b6****</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Simple recovery feature: <b>simple</b> (enable simple recovery).</description></item>
        /// <item><description>Error log cleanup feature: <b>1</b> (confirm cleanup).</description></item>
        /// <item><description>Cloud disk encryption feature (<b>this feature cannot be disabled after it is enabled</b>):<list type="bullet">
        /// <item><description><b>serviceKey</b>: Uses an automatically generated key from Alibaba Cloud, which is the RDS-managed service key (Default Service CMK), to enable cloud disk encryption.</description></item>
        /// <item><description><b><Key></b>: Uses a custom key to enable cloud disk encryption or replaces the current key. Example: <c>494c98ce-f2b5-48ab-96ab-36c986b6****</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </details>
        /// 
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ConfigValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-2ze****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The resource group ID. You can call DescribeDBInstanceAttribute to obtain the resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
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
        /// <para>The time at which the modification takes effect. We recommend that you perform specification changes during off-peak hours. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05-06T09:24:00Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>The switchover time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b>: The modification takes effect immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: The modification takes effect during the maintenance window. You can call ModifyDBInstanceMaintainTime to modify the maintenance window.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Immediate</para>
        /// </summary>
        [NameInMap("SwitchTimeMode")]
        [Validation(Required=false)]
        public string SwitchTimeMode { get; set; }

    }

}
