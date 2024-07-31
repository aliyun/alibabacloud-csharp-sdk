// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// The query result returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataSourcesResponseBodyData Data { get; set; }
        public class ListDataSourcesResponseBodyData : TeaModel {
            /// <summary>
            /// The data sources.
            /// </summary>
            [NameInMap("DataSources")]
            [Validation(Required=false)]
            public List<ListDataSourcesResponseBodyDataDataSources> DataSources { get; set; }
            public class ListDataSourcesResponseBodyDataDataSources : TeaModel {
                /// <summary>
                /// The ID of the compute engine with which the data source is associated.
                /// </summary>
                [NameInMap("BindingCalcEngineId")]
                [Validation(Required=false)]
                public long? BindingCalcEngineId { get; set; }

                /// <summary>
                /// The status of the data source. Valid values:
                /// 
                /// *   1: The data source is accessible.
                /// *   2: The data source is inaccessible.
                /// </summary>
                [NameInMap("ConnectStatus")]
                [Validation(Required=false)]
                public int? ConnectStatus { get; set; }

                /// <summary>
                /// The data connection string. The value of this parameter is in the JSON format. Examples of connection strings of common data sources:
                /// 
                /// *   MaxCompute
                /// 
                ///         {
                ///           "pubEndpoint": "http://service.cn.maxcompute.aliyun.com/api",
                ///           "accessId": "xxxxxxx",
                ///           "securityToken": null,
                ///           "endpoint": "http://service.cn.maxcompute.aliyun-inc.com/api",
                ///           "accessKey": "***",
                ///           "name": "PRE_PROJECT_A_engine",
                ///           "project": "PRE_PROJECT_A",
                ///           "vpcEndpoint": "http://service.cn.maxcompute.aliyun-inc.com/api",
                ///           "region": "cn-shanghai",
                ///           "authType": "2"
                ///         }
                /// 
                /// *   MySQL
                /// 
                ///         {
                ///           "configType": "1",
                ///           "database": "mysql_d111b",
                ///           "instanceName": "rm-xxxxxx",
                ///           "password": "***",
                ///           "rdsOwnerId": "12133xxxxxx",
                ///           "tag": "rds",
                ///           "username": "mysql_db111"
                ///         }
                /// 
                /// *   ApsaraDB RDS for SQL Server
                /// 
                ///         {
                ///           "configType": "1",
                ///           "jdbcUrl": "jdbc:sqlserver://rm-xxxxx.sqlserver.rds.aliyuncs.com:1433;DatabaseName=sqlserver_db1",
                ///           "password": "***",
                ///           "tag": "public",
                ///           "username": "sqlserver_db111"
                ///         }
                /// 
                /// *   Object Storage Service (OSS)
                /// 
                ///         {
                ///           "accessId": "LTAINbR9Uxxxx",
                ///           "accessKey": "***",
                ///           "bucket": "bigxxx1223",
                ///           "configType": "1",
                ///           "endpoint": "http://oss-cn-hangzhou.aliyuncs.com",
                ///           "tag": "public"
                ///         }
                /// 
                /// *   ApsaraDB RDS for PostgreSQL
                /// 
                ///         {
                ///           "configType": "1",
                ///           "database": "cdp_xxx",
                ///           "instanceName": "rm-xxxx",
                ///           "password": "***",
                ///           "rdsOwnerId": "121xxxxx",
                ///           "tag": "rds",
                ///           "username": "cdp_xxx"
                ///         }
                /// 
                /// *   AnalyticDB for MySQL
                /// 
                ///         {
                ///           "configType": "1",
                ///           "password": "***",
                ///           "schema": "ads_demo",
                ///           "tag": "public",
                ///           "url": "ads-xxx-xxxx.cn-hangzhou-1.ads.aliyuncs.com:3029",
                ///           "username": "lslslsls"
                ///         }
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The type of the data source. Valid values:
                /// 
                /// *   odps
                /// *   mysql
                /// *   rds
                /// *   oss
                /// *   sqlserver
                /// *   polardb
                /// *   oracle
                /// *   mongodb
                /// *   emr
                /// *   postgresql
                /// *   analyticdb_for_mysql
                /// *   hybriddb_for_postgresql
                /// *   holo
                /// </summary>
                [NameInMap("DataSourceType")]
                [Validation(Required=false)]
                public string DataSourceType { get; set; }

                /// <summary>
                /// Indicates whether the compute engine that is associated with the data source is the default compute engine used by data sources of the same type.
                /// </summary>
                [NameInMap("DefaultEngine")]
                [Validation(Required=false)]
                public bool? DefaultEngine { get; set; }

                /// <summary>
                /// The description of the data source.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The environment in which the data source is used. Valid values:
                /// 
                /// *   0: development environment
                /// *   1: production environment
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public int? EnvType { get; set; }

                /// <summary>
                /// The time when the data source was created. Example: Mar 17, 2021 4:09:32 PM.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The time when the data source was last modified. Example: Mar 17, 2021 4:09:32 PM.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The data source ID.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The name of the data source.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account that is used to last modify the data source.
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// The ID of the workspace to which the data source belongs.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public int? ProjectId { get; set; }

                /// <summary>
                /// The sequence number of the data source. Data sources are sorted in descending order based on the value of this parameter.
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public int? Sequence { get; set; }

                /// <summary>
                /// Indicates whether the data source is a shared data source.
                /// </summary>
                [NameInMap("Shared")]
                [Validation(Required=false)]
                public bool? Shared { get; set; }

                /// <summary>
                /// The status of the data source. Valid values:
                /// 
                /// *   1: The data source is accessible.
                /// *   2: The data source is inaccessible.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The subtype of the data source. This parameter takes effect only when the DataSourceType parameter is set to rds.
                /// </summary>
                [NameInMap("SubType")]
                [Validation(Required=false)]
                public string SubType { get; set; }

                /// <summary>
                /// The tenant ID.
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

            }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of data sources.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
