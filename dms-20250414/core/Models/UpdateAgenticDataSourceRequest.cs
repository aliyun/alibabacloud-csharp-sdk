// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class UpdateAgenticDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>The new display name of the data source. If you do not specify this parameter, the alias is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_mysql</para>
        /// </summary>
        [NameInMap("Alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <para>The new logon username. If you do not specify this parameter, the authentication account is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db_user</para>
        /// </summary>
        [NameInMap("AuthAccount")]
        [Validation(Required=false)]
        public string AuthAccount { get; set; }

        /// <summary>
        /// <para>The new logon password. If you do not specify this parameter, the authentication password is not updated. This is sensitive information. Do not record or disclose it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>P@ss****</para>
        /// </summary>
        [NameInMap("AuthPassword")]
        [Validation(Required=false)]
        public string AuthPassword { get; set; }

        /// <summary>
        /// <para>Optional. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>-1: No authentication required.</description></item>
        /// <item><description>0: Username and password.</description></item>
        /// <item><description>1: Password only.</description></item>
        /// <item><description>2: Password-free.
        /// If you do not specify this parameter, the authentication type is not updated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public int? AuthType { get; set; }

        /// <summary>
        /// <para>The new name of the metadata catalog. If you do not specify this parameter, the catalog name is not updated. The name can be up to 128 characters in length. It must start with a Chinese character, a letter, or an underscore, and can contain digits and hyphens. It cannot contain only digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_catalog</para>
        /// </summary>
        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        /// <summary>
        /// <para>The registration method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>INSTANCE_ID: Select an existing cloud instance.</description></item>
        /// <item><description>HOST_PORT: Register by endpoint and port.
        /// If you do not specify this parameter, the creation mode is not updated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HOST_PORT</para>
        /// </summary>
        [NameInMap("CreateMode")]
        [Validation(Required=false)]
        public string CreateMode { get; set; }

        /// <summary>
        /// <para>The UUID of the data source to be updated.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou_a1b2c3d4e5f6</para>
        /// </summary>
        [NameInMap("DataSourceUuid")]
        [Validation(Required=false)]
        public string DataSourceUuid { get; set; }

        /// <summary>
        /// <para>Modifying the data source type is not supported. Do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MYSQL</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The environment type. Valid values: product, pre, dev, test, sit, uat, pet, and stag. If you do not specify this parameter, the environment type is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>product</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>Optional. The new domain name or IP address of the database. Do not include the protocol, path, or port. If you do not specify this parameter, the host is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.example.com</para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>The new ID of the cloud resource instance. If you do not specify this parameter, the instance resource ID is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1234567890</para>
        /// </summary>
        [NameInMap("InstanceResourceId")]
        [Validation(Required=false)]
        public string InstanceResourceId { get; set; }

        /// <summary>
        /// <para>The new name of the KMS-managed credential. If you do not specify this parameter, the KMS secret is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>datasource-secret</para>
        /// </summary>
        [NameInMap("KmsSecret")]
        [Validation(Required=false)]
        public string KmsSecret { get; set; }

        /// <summary>
        /// <para>Optional. The new ID of the data access security policy. If you do not specify this parameter, the policy ID is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-usr-example</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>Optional. The new service port of the database. If you do not specify this parameter, the service port is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The new ARN of the Alibaba Cloud RAM role. If you do not specify this parameter, the role ARN is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:role/DataSourceRole</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>Optional. For ADB_POSTGRESQL, DRDS, POSTGRESQL, and POLARDB_POSTGRESQL, specify the database name. For ORACLE, specify the SID or service name, and prefix the service name with a forward slash (/). For POLARDB_ORACLE, specify the SID. For MAXCOMPUTE, specify the project name. For other types, leave this parameter empty. If you do not specify this parameter, the schema is not updated.</para>
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
        /// <para>Specifies whether to use the cloud instance name as the data source name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Yes.</description></item>
        /// <item><description>0: No.
        /// If you do not specify this parameter, the sync alias setting is not updated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SyncAlias")]
        [Validation(Required=false)]
        public int? SyncAlias { get; set; }

        /// <summary>
        /// <para>The new SSL setting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Enable.</description></item>
        /// <item><description>0: Disable.</description></item>
        /// <item><description>-1: Use default settings.
        /// If you do not specify this parameter, the SSL setting is not updated. SSL is supported only for ADB_MYSQL, CLICKHOUSE, MARIADB, MYSQL, OCEANBASEX, POLARDB, SELECTDB, and STARROCKS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UseSsl")]
        [Validation(Required=false)]
        public int? UseSsl { get; set; }

    }

}
