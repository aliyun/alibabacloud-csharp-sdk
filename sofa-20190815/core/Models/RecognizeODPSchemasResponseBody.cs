// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class RecognizeODPSchemasResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeODPSchemasResponseBodyData Data { get; set; }
        public class RecognizeODPSchemasResponseBodyData : TeaModel {
            [NameInMap("LogicTables")]
            [Validation(Required=false)]
            public List<RecognizeODPSchemasResponseBodyDataLogicTables> LogicTables { get; set; }
            public class RecognizeODPSchemasResponseBodyDataLogicTables : TeaModel {
                public bool? BroadcastTable { get; set; }
                public bool? CreateTableNow { get; set; }
                public string EnvMode { get; set; }
                public string EnvTenant { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public long? GroupCount { get; set; }
                public long? Id { get; set; }
                public string InstanceId { get; set; }
                public long? SchemaGroupType { get; set; }
                public string SchemaName { get; set; }
                public bool? SingleTable { get; set; }
                public string SqlText { get; set; }
                public long? TableCount { get; set; }
                public string TableName { get; set; }
                public string TbSuffix { get; set; }
                public string TbSuffixPadding { get; set; }
                public List<RecognizeODPSchemasResponseBodyDataLogicTablesDbRules> DbRules { get; set; }
                public class RecognizeODPSchemasResponseBodyDataLogicTablesDbRules : TeaModel {
                    public bool? Customized { get; set; }
                    public string Field { get; set; }
                    public string Text { get; set; }
                    public string Value { get; set; }
                }
                public List<RecognizeODPSchemasResponseBodyDataLogicTablesRules> Rules { get; set; }
                public class RecognizeODPSchemasResponseBodyDataLogicTablesRules : TeaModel {
                    public bool? Customized { get; set; }
                    public string Field { get; set; }
                    public string Text { get; set; }
                    public string Value { get; set; }
                }
            }
            [NameInMap("ConnProperties")]
            [Validation(Required=false)]
            public RecognizeODPSchemasResponseBodyDataConnProperties ConnProperties { get; set; }
            public class RecognizeODPSchemasResponseBodyDataConnProperties : TeaModel {
                [NameInMap("AllowMinPoolTimeout")]
                [Validation(Required=false)]
                public bool? AllowMinPoolTimeout { get; set; }

                [NameInMap("BackgroundValidation")]
                [Validation(Required=false)]
                public bool? BackgroundValidation { get; set; }

                [NameInMap("BackgroundValidationMinutes")]
                [Validation(Required=false)]
                public long? BackgroundValidationMinutes { get; set; }

                [NameInMap("BlockingTimeoutMillis")]
                [Validation(Required=false)]
                public long? BlockingTimeoutMillis { get; set; }

                [NameInMap("IdleTimeoutMinutes")]
                [Validation(Required=false)]
                public long? IdleTimeoutMinutes { get; set; }

                [NameInMap("MaxConn")]
                [Validation(Required=false)]
                public long? MaxConn { get; set; }

                [NameInMap("MinConn")]
                [Validation(Required=false)]
                public long? MinConn { get; set; }

                [NameInMap("NewConnectionSql")]
                [Validation(Required=false)]
                public string NewConnectionSql { get; set; }

                [NameInMap("Others")]
                [Validation(Required=false)]
                public string Others { get; set; }

                [NameInMap("Prefill")]
                [Validation(Required=false)]
                public bool? Prefill { get; set; }

                [NameInMap("QueryTimeout")]
                [Validation(Required=false)]
                public long? QueryTimeout { get; set; }

                [NameInMap("TestOnBorrow")]
                [Validation(Required=false)]
                public bool? TestOnBorrow { get; set; }

                [NameInMap("ValidationQuery")]
                [Validation(Required=false)]
                public string ValidationQuery { get; set; }

                [NameInMap("ValidationQueryTimeout")]
                [Validation(Required=false)]
                public long? ValidationQueryTimeout { get; set; }

            }
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public RecognizeODPSchemasResponseBodyDataSchema Schema { get; set; }
            public class RecognizeODPSchemasResponseBodyDataSchema : TeaModel {
                [NameInMap("AppDsName")]
                [Validation(Required=false)]
                public string AppDsName { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("AutoCreateSchema")]
                [Validation(Required=false)]
                public bool? AutoCreateSchema { get; set; }

                [NameInMap("AutoUpdateVersion")]
                [Validation(Required=false)]
                public bool? AutoUpdateVersion { get; set; }

                [NameInMap("Charset")]
                [Validation(Required=false)]
                public string Charset { get; set; }

                [NameInMap("Collation")]
                [Validation(Required=false)]
                public string Collation { get; set; }

                [NameInMap("DbNum")]
                [Validation(Required=false)]
                public long? DbNum { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EnableDtx")]
                [Validation(Required=false)]
                public bool? EnableDtx { get; set; }

                [NameInMap("EnvMode")]
                [Validation(Required=false)]
                public string EnvMode { get; set; }

                [NameInMap("EnvTenant")]
                [Validation(Required=false)]
                public string EnvTenant { get; set; }

                [NameInMap("ExpansionJobId")]
                [Validation(Required=false)]
                public string ExpansionJobId { get; set; }

                [NameInMap("ExpansionStatus")]
                [Validation(Required=false)]
                public string ExpansionStatus { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("GmtValid")]
                [Validation(Required=false)]
                public string GmtValid { get; set; }

                [NameInMap("GroupCount")]
                [Validation(Required=false)]
                public long? GroupCount { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("LatestVersion")]
                [Validation(Required=false)]
                public string LatestVersion { get; set; }

                [NameInMap("LogicTableCount")]
                [Validation(Required=false)]
                public string LogicTableCount { get; set; }

                [NameInMap("OpenReadAndWriteSeparation")]
                [Validation(Required=false)]
                public bool? OpenReadAndWriteSeparation { get; set; }

                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("ParserDbType")]
                [Validation(Required=false)]
                public string ParserDbType { get; set; }

                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                [NameInMap("PhysicalSchemaCount")]
                [Validation(Required=false)]
                public long? PhysicalSchemaCount { get; set; }

                [NameInMap("SchemaGroupType")]
                [Validation(Required=false)]
                public long? SchemaGroupType { get; set; }

                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UpdateStatus")]
                [Validation(Required=false)]
                public string UpdateStatus { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                [NameInMap("NodeSchemaMappings")]
                [Validation(Required=false)]
                public List<RecognizeODPSchemasResponseBodyDataSchemaNodeSchemaMappings> NodeSchemaMappings { get; set; }
                public class RecognizeODPSchemasResponseBodyDataSchemaNodeSchemaMappings : TeaModel {
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    [NameInMap("PhysicalPassword")]
                    [Validation(Required=false)]
                    public string PhysicalPassword { get; set; }

                    [NameInMap("PhysicalUsername")]
                    [Validation(Required=false)]
                    public string PhysicalUsername { get; set; }

                    [NameInMap("PowerfulPassword")]
                    [Validation(Required=false)]
                    public string PowerfulPassword { get; set; }

                    [NameInMap("PowerfulUsername")]
                    [Validation(Required=false)]
                    public string PowerfulUsername { get; set; }

                    [NameInMap("SchemaCount")]
                    [Validation(Required=false)]
                    public long? SchemaCount { get; set; }

                    [NameInMap("SchemaPattern")]
                    [Validation(Required=false)]
                    public string SchemaPattern { get; set; }

                }

                [NameInMap("ServerProps")]
                [Validation(Required=false)]
                public RecognizeODPSchemasResponseBodyDataSchemaServerProps ServerProps { get; set; }
                public class RecognizeODPSchemasResponseBodyDataSchemaServerProps : TeaModel {
                    [NameInMap("BackendMaxConn")]
                    [Validation(Required=false)]
                    public long? BackendMaxConn { get; set; }
                    [NameInMap("EnvMode")]
                    [Validation(Required=false)]
                    public string EnvMode { get; set; }
                    [NameInMap("EnvTenant")]
                    [Validation(Required=false)]
                    public string EnvTenant { get; set; }
                    [NameInMap("FrontendIdleTimeout")]
                    [Validation(Required=false)]
                    public long? FrontendIdleTimeout { get; set; }
                    [NameInMap("FrontendSlaLatency")]
                    [Validation(Required=false)]
                    public long? FrontendSlaLatency { get; set; }
                    [NameInMap("FrontendSlaTps")]
                    [Validation(Required=false)]
                    public long? FrontendSlaTps { get; set; }
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }
                    [NameInMap("SchemaName")]
                    [Validation(Required=false)]
                    public string SchemaName { get; set; }
                };

            }
        };

    }

}
