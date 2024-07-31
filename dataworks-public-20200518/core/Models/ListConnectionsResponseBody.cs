// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListConnectionsResponseBody : TeaModel {
        /// <summary>
        /// The query results for data sources that are returned on multiple pages.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListConnectionsResponseBodyData Data { get; set; }
        public class ListConnectionsResponseBodyData : TeaModel {
            /// <summary>
            /// The data sources.
            /// </summary>
            [NameInMap("Connections")]
            [Validation(Required=false)]
            public List<ListConnectionsResponseBodyDataConnections> Connections { get; set; }
            public class ListConnectionsResponseBodyDataConnections : TeaModel {
                /// <summary>
                /// The ID of the compute engine with which the data source is associated.
                /// </summary>
                [NameInMap("BindingCalcEngineId")]
                [Validation(Required=false)]
                public int? BindingCalcEngineId { get; set; }

                /// <summary>
                /// The status of the data source. Valid values:
                /// 
                /// *   1: The data source is normal.
                /// *   2: The data source is disabled.
                /// </summary>
                [NameInMap("ConnectStatus")]
                [Validation(Required=false)]
                public int? ConnectStatus { get; set; }

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
                [NameInMap("ConnectionType")]
                [Validation(Required=false)]
                public string ConnectionType { get; set; }

                /// <summary>
                /// The details of the data source. Examples of details of some common data sources:
                /// 
                /// *   odps
                /// 
                /// <!---->
                /// 
                ///     {
                ///       "accessId": "xssssss",
                ///       "accessKey": "xsaxsaxsa",
                ///       "authType": 2,
                ///       "endpoint": "http://service.odps.aliyun.com/api",
                ///       "project": "xsaxsax",
                ///       "tag": "public"
                ///     }
                /// 
                /// *   mysql
                /// 
                /// <!---->
                /// 
                ///     {
                ///       "database": "xsaxsa",
                ///       "instanceName": "rm-xsaxsa",
                ///       "password": "xsaxsa",
                ///       "rdsOwnerId": "xasxsa",
                ///       "regionId": "cn-shanghai",
                ///       "tag": "rds",
                ///       "username": "xsaxsa"
                ///     }
                /// 
                /// *   rds
                /// 
                /// <!---->
                /// 
                ///     {
                ///       "configType": 1,
                ///       "tag": "rds",
                ///       "database": "xsaxsa",
                ///       "username": "xsaxsa",
                ///       "password": "xssaxsa$32050",
                ///       "instanceName": "rm-xsaxs",
                ///       "rdsOwnerId": "11111111"
                ///     }
                /// 
                /// *   oss
                /// 
                /// <!---->
                /// 
                ///     {
                ///       "accessId": "sssssxx",
                ///       "accessKey": "xsaxaxsaxs",
                ///       "bucket": "xsa-xs-xs",
                ///       "endpoint": "http://oss-cn-shanghai.aliyuncs.com",
                ///       "tag": "public"
                ///     }
                /// 
                /// *   sqlserver
                /// 
                /// <!---->
                /// 
                ///     {
                ///       "jdbcUrl": "jdbc:sqlserver://xsaxsa-xsaxsa.database.xxx.cn:123;DatabaseName=xsxs-xsxs",
                ///       "password": "sdasda$fs",
                ///       "tag": "public",
                ///       "username": "sxaxacdacdd"
                ///     }
                /// 
                /// *   polardb
                /// 
                /// <!---->
                /// 
                ///     {
                ///       "clusterId": "pc-sdadsadsa",
                ///       "database": "dsadsadsa",
                ///       "ownerId": "121212122",
                ///       "password": "sdasdafssa",
                ///       "region": "cn-shanghai",
                ///       "tag": "polardb",
                ///       "username": "asdadsads"
                ///     }
                /// 
                /// *   oracle
                /// 
                /// <!---->
                /// 
                ///     {
                ///       "jdbcUrl": "jdbc:oracle:saaa:@xxxxx:1521:PROD",
                ///       "password": "sxasaxsa",
                ///       "tag": "public",
                ///       "username": "sasfadfa"
                ///     }
                /// 
                /// *   mongodb
                /// 
                /// <!---->
                /// 
                ///     {
                ///       "address": "[\\"xsaxxsa.mongodb.rds.aliyuncs.com:3717\\"]",
                ///       "database": "admin",
                ///       "password": "sadsda@",
                ///       "tag": "public",
                ///       "username": "dsadsadas"
                ///     }
                /// 
                /// *   emr
                /// 
                /// <!---->
                /// 
                ///     {
                ///       "accessId": "xsaxsa",
                ///       "emrClusterId": "C-dsads",
                ///       "emrResourceQueueName": "default",
                ///       "emrEndpoint": "emr.aliyuncs.com",
                ///       "accessKey": "dsadsad",
                ///       "emrUserId": "224833315798889783",
                ///       "name": "sasdsadsa",
                ///       "emrAccessMode": "simple",
                ///       "region": "cn-shanghai",
                ///       "authType": "2",
                ///       "emrProjectId": "FP-sdadsad"
                ///     }
                /// 
                /// *   postgresql
                /// 
                /// <!---->
                /// 
                ///     {
                ///       "jdbcUrl": "jdbc:postgresql://xxxx:1921/ssss",
                ///       "password": "sdadsads",
                ///       "tag": "public",
                ///       "username": "sdsasda"
                ///     }
                /// 
                /// *   analyticdb_for_mysql
                /// 
                /// <!---->
                /// 
                ///     {
                ///       "instanceId": "am-sadsada",
                ///       "database": "xsxsx",
                ///       "username": "xsxsa",
                ///       "password": "asdadsa",
                ///       "connectionString": "am-xssxsxs.ads.aliyuncs.com:3306"
                ///     }
                /// 
                /// *   hybriddb_for_postgresql
                /// 
                /// <!---->
                /// 
                ///     {
                ///       "connectionString": "gp-xsaxsaxa-master.gpdbmaster.rds.aliyuncs.com",
                ///       "database": "xsaxsaxas",
                ///       "password": "xsaxsaxsa@11",
                ///       "instanceId": "gp-xsaxsaxsa",
                ///       "port": "541132",
                ///       "ownerId": "xsaxsaxsas",
                ///       "username": "sadsad"
                ///     }
                /// 
                /// *   holo
                /// 
                /// <!---->
                /// 
                ///     {
                ///       "accessId": "xsaxsaxs",
                ///       "accessKey": "xsaxsaxsa",
                ///       "database": "xsaxsaxsa",
                ///       "instanceId": "xsaxa",
                ///       "tag": "aliyun"
                ///     }
                /// 
                /// *   kafka
                /// 
                /// <!---->
                /// 
                ///     {
                ///       "instanceId": "xsax-cn-xsaxsa",
                ///       "regionId": "cn-shanghai",
                ///       "tag": "aliyun",
                ///       "ownerId": "1212121212112"
                ///     }
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

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
                public int? Id { get; set; }

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
                /// The ID of the workspace with which the data source is associated.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public int? ProjectId { get; set; }

                /// <summary>
                /// The field that is used to sort data sources. Data sources are sorted in descending order based on the value of this parameter.
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
                /// *   1: The data source is normal.
                /// *   2: The data source is disabled.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The subtype of the data source. This parameter is used in scenarios where a type includes subtypes. The following type and subtypes are supported:
                /// 
                /// *   Type: `rds`
                /// *   Subtypes: `mysql`, `sqlserver`, and `postgresql`.
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
            /// The number of entries per page. Default value: 10. Maximum value: 100.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of data sources returned.
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
