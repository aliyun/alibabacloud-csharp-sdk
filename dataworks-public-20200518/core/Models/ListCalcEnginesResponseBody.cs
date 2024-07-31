// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListCalcEnginesResponseBody : TeaModel {
        /// <summary>
        /// The query results for compute engines that are returned on multiple pages.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCalcEnginesResponseBodyData Data { get; set; }
        public class ListCalcEnginesResponseBodyData : TeaModel {
            /// <summary>
            /// The compute engines.
            /// </summary>
            [NameInMap("CalcEngines")]
            [Validation(Required=false)]
            public List<ListCalcEnginesResponseBodyDataCalcEngines> CalcEngines { get; set; }
            public class ListCalcEnginesResponseBodyDataCalcEngines : TeaModel {
                /// <summary>
                /// The ID of the workspace with which the compute engine is associated.
                /// </summary>
                [NameInMap("BindingProjectId")]
                [Validation(Required=false)]
                public int? BindingProjectId { get; set; }

                /// <summary>
                /// The name of the workspace with which the compute engine is associated.
                /// </summary>
                [NameInMap("BindingProjectName")]
                [Validation(Required=false)]
                public string BindingProjectName { get; set; }

                /// <summary>
                /// The type of the compute engine.
                /// </summary>
                [NameInMap("CalcEngineType")]
                [Validation(Required=false)]
                public string CalcEngineType { get; set; }

                /// <summary>
                /// The region where the DataWorks workspace with which the compute engine is associated resides.
                /// </summary>
                [NameInMap("DwRegion")]
                [Validation(Required=false)]
                public string DwRegion { get; set; }

                /// <summary>
                /// The compute engine ID.
                /// </summary>
                [NameInMap("EngineId")]
                [Validation(Required=false)]
                public int? EngineId { get; set; }

                /// <summary>
                /// The details of the compute engine.
                /// 
                /// *   ODPS
                /// 
                ///         {
                ///           "pubEndpoint": "service.cn.maxcompute.aliyun.com/api",
                ///           "endpoint": "service.cn.maxcompute.aliyun-inc.com/api",
                ///           "initProperties": " 
                ///           {\\"odpsTypeMode\\":\\"STANDARD\\",\\"openPai\\":false,\\"openPaiGpu\\":false}",
                ///           "resourceGroupType": "ODPS",
                ///           "resourceGroupId": "361826516****",
                ///           "vpcEndpoint": "service.cn.maxcompute.aliyun-inc.com/api",
                ///           "projectName": "onefall_test_zjk",
                ///           "taskSameAsOwner": "true"
                ///         }
                /// 
                /// *   EMR
                /// 
                ///         {
                ///           "emrClusterId": "C-xxx",
                ///           "specs": "{\\"emrClusterId\\":\\"C-xxx\\",\\"emrAccessMode\\":\\"simple\\",\\"emrResourceQueueName\\":\\"default\\",\\"emrProjectId\\":\\"FP-xxx\\"}",
                ///           "endpoint": "emr.aliyuncs.com",
                ///           "emrResourceQueueName": "default",
                ///           "emrAccessMode": "simple",
                ///           "resourceGroupType": "DW",
                ///           "projectName": "xx-xxxx",
                ///           "emrProjectId": "FP-xxxx",
                ///           "taskSameAsOwner": "false"
                ///         }   
                /// 
                /// *   BLINK
                /// 
                ///         {
                ///           "bayesProjectId": "xxxx",
                ///           "bayesProjectName": "xc_blxxixxxnk_1",
                ///           "cluster": "xxxssxsx",
                ///           "endpoint": "https://stream.console.aliyun.com",
                ///           "engineType": "BLINK",
                ///           "name": "xsxsxxxxx",
                ///           "projectName": "xc_blxxxsxink_1",
                ///           "queue": "root.xc_blxsxxxxxxink_1",
                ///           "resourceGroupType": "DW",
                ///           "specs": "{\\"cluster\\":\\"xxxxxx\\",\\"bayesProjectName\\":\\"xc_blxxixxxnk_1\\",\\"bayesProjectId\\":\\"ssxxxsa\\",\\"name\\":\\"sxsxsxxx\\",\\"queue\\":\\"root.sxxsxxsx\\"}",
                ///           "taskSameAsOwner": false
                ///         }
                /// 
                /// *   HOLO
                /// 
                ///         {
                ///           "endpoint": "hgprecn-cn-xsxssxsx-cn-shanghai-internal.hologres.aliyuncs.com:80",
                ///           "engineType": "ODPS",
                ///           "odpsEndpoint": "hgprecn-cn-xsxssxxs-cn-shanghai-internal.hologres.aliyuncs.com:80",
                ///           "odpsProjectName": "xsxssxsxsx",
                ///           "projectName": "xsxssxsxsx",
                ///           "resourceGroupType": "DW",
                ///           "specs": "{\\"pubEndpoint\\":\\"hgprecn-cn-xsxssxsxs-cn-shanghai.hologres.aliyuncs.com:80\\",\\"commonBuyInstanceId\\":\\"hgprecn-cn-xsxsxsxs\\",\\"project\\":\\"holo_upxsxgrade1\\",\\"common_buy_instance_id\\":\\"hgprecn-cn-xsxsxs\\",\\"endpoint\\":\\"hgprecn-cn-xsxxsxs-cn-shanghai-internal.hologres.aliyuncs.com:80\\",\\"port\\":\\"80\\",\\"host\\":\\"hgprecn-cn-xsxsxsxs-cn-shanghai-internal.hologres.aliyuncs.com\\",\\"vpcEndpoint\\":\\"hgprecn-cn-xsxsxsxs-cn-shanghai-vpc.hologres.aliyuncs.com:80\\",\\"authType\\":2,\\"region\\":\\"cn-shanghai\\"}",
                ///           "taskSameAsOwner": false
                ///         }
                /// 
                /// *   MaxGraph
                /// 
                ///         {
                ///           "endpoint": "http://pre-graphcompute.aliyuncs.com",
                ///           "engineType": "ODPS",
                ///           "odpsEndpoint": "http://pre-graphcompute.aliyuncs.com",
                ///           "odpsProjectName": "xsxsxsxs",
                ///           "projectName": "xsxsxsxs",
                ///           "resourceGroupType": "DW",
                ///           "taskSameAsOwner": false
                ///         }
                /// 
                /// *   HYBRIDDB_FOR_POSTGRESQL
                /// 
                ///         {
                ///           "endpoint": "hybriddb_for_postgresql_mo12121ck_endpoint",
                ///           "engineType": "ODPS",
                ///           "odpsEndpoint": "hybriddb_for_postgresql_m121212ock_endpoint",
                ///           "odpsProjectName": "sxasaxsaxaxas",
                ///           "projectName": "sxasaxsaxaxas",
                ///           "resourceGroupType": "DW",
                ///           "specs": "{\\"connectionString\\":\\"gp-xsxsxsxxs.gpdb.rds.aliyuncs.com\\",\\"database\\":\\"xsxsxxsxs\\",\\"password\\":\\"xxxxxxx\\",\\"instanceId\\":\\"gp-cdcdacdacda\\",\\"port\\":\\"3432\\",\\"ownerId\\":\\"12121212\\",\\"username\\":\\"sdasaddsa\\"}",
                ///           "taskSameAsOwner": false
                ///         }
                /// 
                /// *   ADB_MYSQL
                /// 
                ///         {
                ///           "endpoint": "adb_mysql_mock_endpoint",
                ///           "engineType": "ODPS",
                ///           "odpsEndpoint": "adb_mysql_mock_endpoint",
                ///           "odpsProjectName": "am-xsaxaxa",
                ///           "projectName": "am-xsxsaxa",
                ///           "resourceGroupType": "DW",
                ///           "specs": "{\\"connectionString\\":\\"am-xsaxsa.ads.aliyuncs.com:3306\\",\\"database\\":\\"xsaxsaxa\\",\\"password\\":\\"xsaxsaxassxsa\\",\\"instanceId\\":\\"am-xsaxsasx\\",\\"username\\":\\"xsaxsadsd\\"}",
                ///           "taskSameAsOwner": false
                ///         }
                /// 
                /// *   HADOOP_CDH
                /// 
                ///         {
                ///           "bindingBaseId": "xsaxsaxs",
                ///           "endpoint": "xsaaaaa",
                ///           "engineType": "ODPS",
                ///           "odpsEndpoint": "axsxaxssxs",
                ///           "odpsProjectName": "ssxxax",
                ///           "projectName": "xsaxsaxsa",
                ///           "resourceGroupId": 45208xxxxxx,
                ///           "resourceGroupType": "GATEWAY",
                ///           "specs": "{\\"cluster\\":{\\"hive\\":{\\"hiveServer2Url\\":\\"jdbc:hive2://xxxxxxer-1-cn-shanghai-pre-kerberos-1:10000\\",\\"hiveMetastore\\":\\"thrift://xxxxxxxr-1-cn-shanghai-pre-kerberos-1:9083\\",\\"version\\":\\"2.1.1\\"},\\"configFiles\\":{\\"coreSite\\":\\"4534574xxxxxx\\",\\"hdfsSite\\":\\"453457919xxxxxxx\\",\\"mapredSite\\":\\"45345750xxxxxx\\",\\"yarnSite\\":\\"4534575xxxxx\\",\\"krb5Conf\\":\\"4534576xxxxx1\\",\\"hiveSite\\":\\"453457xxxxx20\\"},\\"spark\\":{\\"version\\":\\"2.4.0\\"},\\"cdh\\":{\\"version\\":\\"6.3.2\\"},\\"hdfs\\":{\\"version\\":\\"3.0.0\\"},\\"impala\\":{\\"impalaUrl\\":\\"jdbc:impala://cdh-xsxssxxsx-1-cn-shanghai-pre-kerberos-1:21050\\",\\"version\\":\\"3.2.0\\"},\\"yarn\\":{\\"YarnUrl\\":\\"http://cdh-xsxsxsxsxs-1-cn-shanghai-pre-kerberos-1:8032\\",\\"webUrl\\":\\"http://cdh-xsxsxssxxssx-1-cn-shanghai-pre-kerberos-1:8088\\",\\"version\\":\\"3.0.0\\"},\\"presto\\":{\\"prestoUrl\\":\\"jdbc:presto://cdh-xssxsxxsxsxs-1-cn-shanghai-pre-kerberos-1:8080/hive/default\\",\\"version\\":\\"0.244.1\\"}},\\"instanceId\\":161sdads733,\\"authDetail\\":{\\"principal\\":\\"hive@HADOOP.COM\\",\\"keytabFileId\\":\\"45345815xsxsxs3\\",\\"type\\":\\"kerberos\\",\\"username\\":\\"xsxsxsxsa@HADOOP.COM\\"},\\"resGroupStatus\\":\\"\\",\\"hadoopAuthType\\":\\"kerberos\\",\\"clusterIdentifier\\":\\"xssxsxsxsx\\",\\"clusterId\\":xsxsx,\\"resGroupId\\":4520870619xsxssxxs,\\"accessMode\\":\\"security\\",\\"authType\\":2}",
                ///           "taskSameAsOwner": false
                ///         }
                /// </summary>
                [NameInMap("EngineInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> EngineInfo { get; set; }

                /// <summary>
                /// The environment in which the compute engine is used. Valid values:
                /// 
                /// *   **DEV**
                /// *   **PRD**
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// The time when the compute engine was created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// Indicates whether the compute engine is the default engine of the current type.
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// The display name of the compute engine.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The region where the compute engine resides.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The identity that is used to access the compute engine. Valid values:
                /// 
                /// *   **USER**: the current user
                /// *   **PROJECT**: the workspace executor
                /// *   **SUBACCOUNT**: a RAM user
                /// *   **STS_ROLE**: the Security Token Service (STS) role
                /// </summary>
                [NameInMap("TaskAuthType")]
                [Validation(Required=false)]
                public string TaskAuthType { get; set; }

                /// <summary>
                /// The tenant ID.
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

            }

            /// <summary>
            /// The page number of the returned page.
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
            /// The total number of compute engine instances.
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
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
