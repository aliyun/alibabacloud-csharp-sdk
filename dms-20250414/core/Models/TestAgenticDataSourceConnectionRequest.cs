// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class TestAgenticDataSourceConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The alias. You can leave this parameter empty when testing a connection. This parameter does not create or modify a data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_mysql</para>
        /// </summary>
        [NameInMap("Alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <para>The logon username. You can leave this parameter empty for authentication methods that do not require a username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db_user</para>
        /// </summary>
        [NameInMap("AuthAccount")]
        [Validation(Required=false)]
        public string AuthAccount { get; set; }

        /// <summary>
        /// <para>The logon password. When testing an existing data source, you can leave this parameter empty to reuse the saved password. If a new value is passed, the new value takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>P@ss****</para>
        /// </summary>
        [NameInMap("AuthPassword")]
        [Validation(Required=false)]
        public string AuthPassword { get; set; }

        /// <summary>
        /// <para>The authentication type. This parameter is optional. Valid values: -1 (no authentication required), 0 (username and password), 1 (password only), and 2 (password-free).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public int? AuthType { get; set; }

        /// <summary>
        /// <para>The catalog name. You can leave this parameter empty when testing a connection. This parameter does not create a metadata catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_catalog</para>
        /// </summary>
        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        /// <summary>
        /// <para>The UUID of the data source. This parameter is required when testing an existing data source. If no new password is passed, the saved password is reused. Leave this parameter empty when testing a new data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou_a1b2c3d4e5f6</para>
        /// </summary>
        [NameInMap("DataSourceUuid")]
        [Validation(Required=false)]
        public string DataSourceUuid { get; set; }

        /// <summary>
        /// <para>The type of the data source. Use uppercase letters. Do not pass numbers. Valid values: MYSQL, POSTGRESQL, ORACLE, SQLSERVER, MARIADB, POLARDB, POLARDB_POSTGRESQL, POLARDB_ORACLE, OCEANBASEX, DRDS, ADB_MYSQL, ADB_POSTGRESQL, CLICKHOUSE, SELECTDB, STARROCKS, HOLOGRES, MAXCOMPUTE, ES_REST, and TRINO.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MYSQL</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The environment type. This parameter is optional when testing a connection. Valid values: product, pre, dev, test, sit, uat, pet, and stag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>product</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The domain name or IP address of the database. Do not include the protocol, path, or port. This parameter is optional. You can leave this parameter empty when you select an existing cloud instance and the endpoint is automatically populated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.example.com</para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>The ID of the cloud resource instance. This parameter is required when you select an existing cloud instance. You can leave this parameter empty when you enter a connection endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1234567890</para>
        /// </summary>
        [NameInMap("InstanceResourceId")]
        [Validation(Required=false)]
        public string InstanceResourceId { get; set; }

        /// <summary>
        /// <para>The source of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RDS: ApsaraDB instance.</description></item>
        /// <item><description>PUBLIC_OWN: self-managed database connected over the Internet.</description></item>
        /// <item><description>ECS_OWN: self-managed database hosted on an ECS instance.</description></item>
        /// <item><description>GATEWAY: database connected through Database Gateway.</description></item>
        /// <item><description>VPC_IDC: database connected over a VPC or data center.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("InstanceSource")]
        [Validation(Required=false)]
        public string InstanceSource { get; set; }

        /// <summary>
        /// <para>The name of the KMS secret. This parameter is required when you use KMS to manage database credentials. Leave this parameter empty in other scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>datasource-secret</para>
        /// </summary>
        [NameInMap("KmsSecret")]
        [Validation(Required=false)]
        public string KmsSecret { get; set; }

        /// <summary>
        /// <para>The service port of the database. This parameter is optional. You can leave this parameter empty when you select an existing cloud instance and the port is automatically populated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The complete ARN of the RAM role. This parameter is required when you use an Alibaba Cloud RAM role to access the data source. Leave this parameter empty in other scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:role/DataSourceRole</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The schema name. This parameter is optional. For ADB_POSTGRESQL, DRDS, POSTGRESQL, and POLARDB_POSTGRESQL, enter the database name. For ORACLE, enter the SID or service name, and prefix the service name with a forward slash (/). For POLARDB_ORACLE, enter the SID. For MAXCOMPUTE, enter the project name. Leave this parameter empty for other types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>postgres</para>
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        /// <summary>
        /// <para>The name of the Snowflake role. This parameter takes effect only when DbType is set to SNOWFLAKE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ROLE</para>
        /// </summary>
        [NameInMap("SnowflakeRole")]
        [Validation(Required=false)]
        public string SnowflakeRole { get; set; }

        /// <summary>
        /// <para>The name of the Snowflake compute warehouse. This parameter takes effect only when DbType is set to SNOWFLAKE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WAREHOUSE</para>
        /// </summary>
        [NameInMap("SnowflakeWarehouse")]
        [Validation(Required=false)]
        public string SnowflakeWarehouse { get; set; }

        /// <summary>
        /// <para>Specifies whether to synchronize the alias. This parameter is optional when testing a connection. This parameter does not modify the data source name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SyncAlias")]
        [Validation(Required=false)]
        public int? SyncAlias { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable SSL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Enable.</description></item>
        /// <item><description>0: Disable.</description></item>
        /// <item><description>-1: Use the default setting.
        /// SSL is supported only for ADB_MYSQL, CLICKHOUSE, MARIADB, MYSQL, OCEANBASEX, POLARDB, SELECTDB, and STARROCKS. Leave this parameter empty for other types.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UseSsl")]
        [Validation(Required=false)]
        public int? UseSsl { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch. This parameter is required when you access MaxCompute over a VPC. Leave this parameter empty in other scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1234567890</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC. This parameter is required when you access MaxCompute over a VPC. Leave this parameter empty in other scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1234567890</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID. This parameter is required when you access MaxCompute over a VPC. Leave this parameter empty in other scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
