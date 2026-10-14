// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListAgenticDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The data sources on the current page.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAgenticDataSourcesResponseBodyData> Data { get; set; }
        public class ListAgenticDataSourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The display name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo_mysql</para>
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The logon username of the data source. This parameter is empty if username authentication is not used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>db_user</para>
            /// </summary>
            [NameInMap("AuthAccount")]
            [Validation(Required=false)]
            public string AuthAccount { get; set; }

            /// <summary>
            /// <para>The masked value of the password or token. The actual value is not returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>P@ss****</para>
            /// </summary>
            [NameInMap("AuthPassword")]
            [Validation(Required=false)]
            public string AuthPassword { get; set; }

            /// <summary>
            /// <para>The authentication method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>-1: no authentication required</description></item>
            /// <item><description>0: username and password</description></item>
            /// <item><description>1: password only</description></item>
            /// <item><description>2: password-free</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public int? AuthType { get; set; }

            /// <summary>
            /// <para>The name of the metadata catalog associated with the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo_catalog</para>
            /// </summary>
            [NameInMap("CatalogName")]
            [Validation(Required=false)]
            public string CatalogName { get; set; }

            /// <summary>
            /// <para>The UUID of the metadata catalog associated with the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mc-ab-0123456789abcdefghijk</para>
            /// </summary>
            [NameInMap("CatalogUuid")]
            [Validation(Required=false)]
            public string CatalogUuid { get; set; }

            /// <summary>
            /// <para>The unique identifier of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou_a1b2c3d4e5f6</para>
            /// </summary>
            [NameInMap("DataSourceUuid")]
            [Validation(Required=false)]
            public string DataSourceUuid { get; set; }

            /// <summary>
            /// <para>The data source type. Valid values: MYSQL, POSTGRESQL, ORACLE, SQLSERVER, MARIADB, POLARDB, POLARDB_POSTGRESQL, POLARDB_ORACLE, OCEANBASEX, DRDS, ADB_MYSQL, ADB_POSTGRESQL, CLICKHOUSE, SELECTDB, STARROCKS, HOLOGRES, MAXCOMPUTE, ES_REST, and TRINO.</para>
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
            /// <para>The time when the data source was created. The time is in the yyyy-MM-dd HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-13 14:30:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the data source was last modified. The time is in the yyyy-MM-dd HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-13 14:35:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The endpoint of the data source. A masked value may be returned in sensitive scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql.example.com</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>The ID of the cloud resource instance. This parameter may be empty for data sources registered by endpoint.</para>
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
            /// <item><description>RDS: ApsaraDB instance</description></item>
            /// <item><description>PUBLIC_OWN: self-managed database on the public network</description></item>
            /// <item><description>ECS_OWN: self-managed database on an ECS instance</description></item>
            /// <item><description>GATEWAY: connected through Database Gateway</description></item>
            /// <item><description>VPC_IDC: connected over a VPC or IDC</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("InstanceSource")]
            [Validation(Required=false)]
            public string InstanceSource { get; set; }

            /// <summary>
            /// <para>The name of the KMS managed credential. This parameter is empty if KMS is not used. This is sensitive information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>datasource-secret</para>
            /// </summary>
            [NameInMap("KmsSecret")]
            [Validation(Required=false)]
            public string KmsSecret { get; set; }

            /// <summary>
            /// <para>The connection port of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The region where the data source resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789012****</para>
            /// </summary>
            [NameInMap("ResourceAccountId")]
            [Validation(Required=false)]
            public string ResourceAccountId { get; set; }

            /// <summary>
            /// <para>The ARN of the RAM role used to access the data source. This parameter is empty if role authorization is not used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::123456789012****:role/DataSourceRole</para>
            /// </summary>
            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <para>The connection target name. For ADB_POSTGRESQL, DRDS, POSTGRESQL, and POLARDB_POSTGRESQL, this parameter indicates the database name. For ORACLE, this parameter indicates the SID or service name. For POLARDB_ORACLE, this parameter indicates the SID. For MAXCOMPUTE, this parameter indicates the project. For other types, this parameter is usually empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>postgres</para>
            /// </summary>
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

            /// <summary>
            /// <para>The status of the data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: normal</description></item>
            /// <item><description>-1: deleted</description></item>
            /// <item><description>-2: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public int? State { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the cloud instance name as the data source name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: yes</description></item>
            /// <item><description>0: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SyncAlias")]
            [Validation(Required=false)]
            public int? SyncAlias { get; set; }

            /// <summary>
            /// <para>The SSL settings. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: enabled</description></item>
            /// <item><description>0: disabled</description></item>
            /// <item><description>-1: default settings</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UseSsl")]
            [Validation(Required=false)]
            public int? UseSsl { get; set; }

        }

        /// <summary>
        /// <para>The error code returned when the call fails. This parameter is empty if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the call fails. This parameter is empty if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The parameter is invalid</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The actual number of entries returned per page in this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The cursor for the next page. An empty value indicates that no more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>page-2-token</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-1234567890</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of data sources that meet the filter conditions. This parameter may be empty in some scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
