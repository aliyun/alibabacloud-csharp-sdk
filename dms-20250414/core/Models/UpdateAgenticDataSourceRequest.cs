// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class UpdateAgenticDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>The new display name of the data source. If this parameter is not specified, the value is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_mysql</para>
        /// </summary>
        [NameInMap("Alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <para>The new logon username. If this parameter is not specified, the value is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db_user</para>
        /// </summary>
        [NameInMap("AuthAccount")]
        [Validation(Required=false)]
        public string AuthAccount { get; set; }

        /// <summary>
        /// <para>The new logon password. If this parameter is not specified, the value is not updated. This is sensitive information. Do not record or disclose it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>P@ss****</para>
        /// </summary>
        [NameInMap("AuthPassword")]
        [Validation(Required=false)]
        public string AuthPassword { get; set; }

        /// <summary>
        /// <para>Optional. The authentication type. Valid values: -1: No authentication required. 0: Username and password. 1: Password only. 2: Password-free. If this parameter is not specified, the value is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public int? AuthType { get; set; }

        /// <summary>
        /// <para>The new metadata catalog name. If this parameter is not specified, the value is not updated. The name can be up to 128 characters in length. It must start with a Chinese character, a letter, or an underscore, and can contain digits and hyphens. It cannot contain only digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_catalog</para>
        /// </summary>
        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        /// <summary>
        /// <para>The registration method. Valid values: INSTANCE_ID: Select an existing cloud instance. HOST_PORT: Register by endpoint and port. If this parameter is not specified, the value is not updated.</para>
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
        /// <para>The environment type. Valid values: product, pre, dev, test, sit, uat, pet, and stag. If this parameter is not specified, the value is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>product</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>Optional. The new database domain name or IP address. Do not include the protocol, path, or port. If this parameter is not specified, the value is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.example.com</para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>The new cloud resource instance ID. If this parameter is not specified, the value is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1234567890</para>
        /// </summary>
        [NameInMap("InstanceResourceId")]
        [Validation(Required=false)]
        public string InstanceResourceId { get; set; }

        /// <summary>
        /// <para>The new KMS managed credential name. If this parameter is not specified, the value is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>datasource-secret</para>
        /// </summary>
        [NameInMap("KmsSecret")]
        [Validation(Required=false)]
        public string KmsSecret { get; set; }

        /// <summary>
        /// <para>Optional. The new data access security policy ID. If this parameter is not specified, the value is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-usr-example</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>Optional. The new database service port. If this parameter is not specified, the value is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The new Alibaba Cloud RAM role ARN. If this parameter is not specified, the value is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:role/DataSourceRole</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>Optional. For ADB_POSTGRESQL, DRDS, POSTGRESQL, and POLARDB_POSTGRESQL, specify the database name. For ORACLE, specify the SID or service name, and prefix the service name with a forward slash (/). For POLARDB_ORACLE, specify the SID. For MAXCOMPUTE, specify the project name. For other types, leave this parameter empty. If this parameter is not specified, the value is not updated.</para>
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
        /// <para>Specifies whether to use the cloud instance name as the data source name. Valid values: 1: Yes. 0: No. If this parameter is not specified, the value is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SyncAlias")]
        [Validation(Required=false)]
        public int? SyncAlias { get; set; }

        /// <summary>
        /// <para>The new SSL setting. Valid values: 1: Enable. 0: Disable. -1: Use the default setting. If this parameter is not specified, the value is not updated. SSL is supported only for ADB_MYSQL, CLICKHOUSE, MARIADB, MYSQL, OCEANBASEX, POLARDB, SELECTDB, and STARROCKS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UseSsl")]
        [Validation(Required=false)]
        public int? UseSsl { get; set; }

    }

}
