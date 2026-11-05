// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AddAgenticDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>The name of the ADB MySQL Spark resource group. This parameter takes effect only when DbType is set to ADB_MYSQL_SPARK. You must specify a resource group for this connection type. This parameter is independent of Schema (database name) and they cannot replace each other.</para>
        /// 
        /// <b>Example:</b>
        /// <para>resourceGroup1</para>
        /// </summary>
        [NameInMap("AdbSparkResourceGroup")]
        [Validation(Required=false)]
        public string AdbSparkResourceGroup { get; set; }

        /// <summary>
        /// <para>The display name of the data source. If you do not specify this parameter, the server generates a name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_mysql</para>
        /// </summary>
        [NameInMap("Alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <para>The logon username. You can leave this parameter empty if the authentication method does not require a username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db_user</para>
        /// </summary>
        [NameInMap("AuthAccount")]
        [Validation(Required=false)]
        public string AuthAccount { get; set; }

        /// <summary>
        /// <para>The logon password. This is sensitive information. Do not record or disclose it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>P@ss****</para>
        /// </summary>
        [NameInMap("AuthPassword")]
        [Validation(Required=false)]
        public string AuthPassword { get; set; }

        /// <summary>
        /// <para>Optional. The authentication type. Valid values: -1: no authentication required, 0: username and password, 1: password only, and 2: password-free.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public int? AuthType { get; set; }

        /// <summary>
        /// <para>The name of the metadata catalog. If you do not specify this parameter, the name is automatically generated. The name can be up to 128 characters in length. It must start with a letter, Chinese character, or underscore, and can contain digits and hyphens. It cannot contain only digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_catalog</para>
        /// </summary>
        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        /// <summary>
        /// <para>The entry method. Valid values: INSTANCE_ID: select an existing cloud instance, and HOST_PORT: enter an endpoint and port. If you do not specify this parameter, HOST_PORT is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HOST_PORT</para>
        /// </summary>
        [NameInMap("CreateMode")]
        [Validation(Required=false)]
        public string CreateMode { get; set; }

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
        /// <para>The environment type. Valid values: product, pre, dev, test, sit, uat, pet, and stag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>product</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>Optional. The domain name or IP address of the database. Do not include the protocol, path, or port. You can leave this parameter empty if you select an existing cloud instance and the address is automatically populated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.example.com</para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>The ID of the cloud resource instance. This parameter is required when you select an existing cloud instance. You can leave this parameter empty when you enter an endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1234567890</para>
        /// </summary>
        [NameInMap("InstanceResourceId")]
        [Validation(Required=false)]
        public string InstanceResourceId { get; set; }

        /// <summary>
        /// <para>The source of the data source. Valid values: RDS: ApsaraDB instance, PUBLIC_OWN: self-managed database connected over the Internet, ECS_OWN: self-managed database hosted on an ECS instance, GATEWAY: database connected through Database Gateway, and VPC_IDC: database connected through a VPC or IDC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("InstanceSource")]
        [Validation(Required=false)]
        public string InstanceSource { get; set; }

        /// <summary>
        /// <para>The name of the credential. Specify this parameter when you use Key Management Service (KMS) to manage database credentials. Leave this parameter empty in other scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>datasource-secret</para>
        /// </summary>
        [NameInMap("KmsSecret")]
        [Validation(Required=false)]
        public string KmsSecret { get; set; }

        /// <summary>
        /// <para>Optional. The ID of the data access security policy. This policy is used to control access and protection rules for the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-usr-example</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>Optional. The service port of the database. You can leave this parameter empty if you select an existing cloud instance and the port is automatically populated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The complete ARN of the Resource Access Management (RAM) role. Specify this parameter when you use a RAM role to access the data source. Leave this parameter empty in other scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:role/DataSourceRole</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>Optional. For ADB_POSTGRESQL, DRDS, POSTGRESQL, and POLARDB_POSTGRESQL, enter the database name. For ORACLE, enter the SID or service name, and prefix the service name with a forward slash (/). For POLARDB_ORACLE, enter the SID. For MAXCOMPUTE, enter the project name. Leave this parameter empty for other types.</para>
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
        /// <para>Specifies whether to use the cloud instance name as the data source name. Valid values: 1: yes, and 0: no. This parameter takes effect only when you select a cloud database instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SyncAlias")]
        [Validation(Required=false)]
        public int? SyncAlias { get; set; }

        /// <summary>
        /// <para>Specifies whether to use SSL. Valid values: 1: enabled, 0: disabled, and -1: default settings. Only ADB_MYSQL, CLICKHOUSE, MARIADB, MYSQL, OCEANBASEX, POLARDB, SELECTDB, and STARROCKS support SSL. Leave this parameter empty for other types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UseSsl")]
        [Validation(Required=false)]
        public int? UseSsl { get; set; }

        /// <summary>
        /// <para>The ID of the destination vSwitch. Specify this parameter when you access MaxCompute through a VPC. Leave this parameter empty in other scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1234567890</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the destination VPC. Specify this parameter when you access MaxCompute through a VPC. Leave this parameter empty in other scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1234567890</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the destination zone. Specify this parameter when you access MaxCompute through a VPC. Leave this parameter empty in other scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
