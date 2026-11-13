// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceConfigRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can use the client to generate the token, but you must ensure that it is unique among different requests. The token can contain a maximum of 64 ASCII characters and cannot contain non-ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the configuration item to be modified. This parameter must be used together with the ConfigValue parameter.</para>
        /// <details>
        /// <summary>Configuration items for ApsaraDB RDS for PostgreSQL</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><b>pgbouncer</b>: modifies the PgBouncer feature.</description></item>
        /// <item><description><b>encryptionKey</b>: modifies the cloud disk encryption feature.</description></item>
        /// <item><description><b>duckdb_create_databases</b>: configures databases on the primary instance as DuckDB column store databases in batches.</description></item>
        /// <item><description><b>duckdb_prepare_dependency</b>: configures the primary instance with one click so that its parameters and minor engine version meet the <a href="https://help.aliyun.com/document_detail/2977241.html">prerequisites</a> for creating a DuckDB-based analytical instance. If read-only instances have been created for the primary instance, the read-only instances are also modified in synchronization.</description></item>
        /// <item><description><b>enable_db_visible_by_connect_rls</b>: enables CONNECT RLS to control database visibility for the instance.</description></item>
        /// <item><description><b>set_db_visible_by_connect_rls</b>: enables CONNECT RLS to control database visibility for databases. This parameter can be invoked only after CONNECT RLS is enabled for the instance.</description></item>
        /// </list>
        /// </details>
        /// 
        /// <details>
        /// <summary>Configuration items for ApsaraDB RDS for SQL Server</summary>
        /// 
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>clear_errorlog</b>: clears error logs.</description></item>
        /// <item><description><b>encryptionKey</b>: modifies the cloud disk encryption feature. This feature is not supported for serverless instances and instances of the shared instance type.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>backup_recovery_model</b>: enables the simple recovery model. Only Basic Edition instances support this feature. <b>This feature cannot be disabled after it is enabled</b>.</description></item>
        /// <item><description><b>clear_errorlog</b>: clears error logs.</description></item>
        /// <item><description><b>encryptionKey</b>: modifies the cloud disk encryption feature. This feature is not supported for serverless instances and instances of the shared instance type.</description></item>
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
        /// <para>The value of the configuration item to be modified. This parameter must be used together with the ConfigName parameter.</para>
        /// <details>
        /// <summary>Values of configuration items for ApsaraDB RDS for PostgreSQL</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>PgBouncer feature: <b>true</b> (enable) or <b>false</b> (disable).</description></item>
        /// <item><description>Cloud disk encryption feature:<list type="bullet">
        /// <item><description><b>ServiceKey</b>: uses an automatically generated key from Alibaba Cloud, which is the RDS-managed service key (Default Service CMK), to enable cloud disk encryption.</description></item>
        /// <item><description><b><Key></b>: uses a custom key to enable cloud disk encryption or replace the current key. Example: <c>494c98ce-f2b5-48ab-96ab-36c986b6****</c>.</description></item>
        /// <item><description><b>disabled</b>: disables cloud disk encryption.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>One-click repair of prerequisites for creating a DuckDB-based analytical instance: <b>duckdb_prepare_dependency</b>.</description></item>
        /// <item><description>Batch configuration of databases on the primary instance as DuckDB column store databases. The value is a JSON string. Example: <c>{&quot;dbNames&quot;: &quot;db1,db2,db3&quot;, &quot;accountName&quot;: &quot;yourSuperAccountName&quot;}</c>, where:<list type="bullet">
        /// <item><description><b>dbNames</b>: the names of the databases to be converted to DuckDB column store databases. Separate multiple database names with commas (,).</description></item>
        /// <item><description><b>accountName</b>: the privileged account. You only need to configure one privileged account.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Enable CONNECT RLS to control database visibility for the instance: <b>true</b> (enable).</description></item>
        /// <item><description>Enable CONNECT RLS to control database visibility for databases: the <b>names of the databases</b> managed by CONNECT RLS. Separate multiple database names with commas (,). Example: <b>testdb1,testdb2</b>. When a client connects to a database with CONNECT RLS enabled, the database list is correctly displayed based on whether the client has the CONNECT permission on other databases.</details>
        /// <details>
        /// <summary>Values of configuration items for ApsaraDB RDS for SQL Server</summary></description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Error log cleanup feature: <b>1</b> (confirm cleanup).</description></item>
        /// <item><description>Cloud disk encryption feature (<b>this feature cannot be disabled after it is enabled</b>):<list type="bullet">
        /// <item><description><b>serviceKey</b>: uses an automatically generated key from Alibaba Cloud, which is the RDS-managed service key (Default Service CMK), to enable cloud disk encryption.</description></item>
        /// <item><description><b><Key></b>: uses a custom key to enable cloud disk encryption or replace the current key. Example: <c>494c98ce-f2b5-48ab-96ab-36c986b6****</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Simple recovery feature: <b>simple</b> (enable simple recovery).</description></item>
        /// <item><description>Error log cleanup feature: <b>1</b> (confirm cleanup).</description></item>
        /// <item><description>Cloud disk encryption feature (<b>this feature cannot be disabled after it is enabled</b>):<list type="bullet">
        /// <item><description><b>serviceKey</b>: uses an automatically generated key from Alibaba Cloud, which is the RDS-managed service key (Default Service CMK), to enable cloud disk encryption.</description></item>
        /// <item><description><b><Key></b>: uses a custom key to enable cloud disk encryption or replace the current key. Example: <c>494c98ce-f2b5-48ab-96ab-36c986b6****</c>.</description></item>
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
        /// <para>Instance ID of the instance. You can call the DescribeDBInstances operation to query instance ID.</para>
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
        /// <para>The ID of the resource group. You can call the DescribeDBInstanceAttribute operation to query the ID.</para>
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
        /// <para>The time when the modification is executed. Perform the modification during off-peak hours. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05-06T09:24:00Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>The time when the modification takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b>: takes effect immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: takes effect within the maintenance window. You can call the ModifyDBInstanceMaintainTime operation to modify the maintenance window.</description></item>
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
