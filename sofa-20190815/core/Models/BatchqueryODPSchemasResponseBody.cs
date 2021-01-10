// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class BatchqueryODPSchemasResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<BatchqueryODPSchemasResponseBodyData> Data { get; set; }
        public class BatchqueryODPSchemasResponseBodyData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("ServerProps")]
            [Validation(Required=false)]
            public BatchqueryODPSchemasResponseBodyDataServerProps ServerProps { get; set; }
            public class BatchqueryODPSchemasResponseBodyDataServerProps : TeaModel {
                [NameInMap("EnvTenant")]
                [Validation(Required=false)]
                public string EnvTenant { get; set; }
                [NameInMap("FrontendIdleTimeout")]
                [Validation(Required=false)]
                public long? FrontendIdleTimeout { get; set; }
                [NameInMap("EnvMode")]
                [Validation(Required=false)]
                public string EnvMode { get; set; }
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }
                [NameInMap("FrontendSlaTps")]
                [Validation(Required=false)]
                public long? FrontendSlaTps { get; set; }
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }
                [NameInMap("BackendMaxConn")]
                [Validation(Required=false)]
                public long? BackendMaxConn { get; set; }
                [NameInMap("FrontendSlaLatency")]
                [Validation(Required=false)]
                public long? FrontendSlaLatency { get; set; }
            };

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("AppDsName")]
            [Validation(Required=false)]
            public string AppDsName { get; set; }

            [NameInMap("GroupCount")]
            [Validation(Required=false)]
            public long? GroupCount { get; set; }

            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            [NameInMap("ExpansionStatus")]
            [Validation(Required=false)]
            public string ExpansionStatus { get; set; }

            [NameInMap("LogicTableCount")]
            [Validation(Required=false)]
            public string LogicTableCount { get; set; }

            [NameInMap("EnableDtx")]
            [Validation(Required=false)]
            public bool? EnableDtx { get; set; }

            [NameInMap("ParserDbType")]
            [Validation(Required=false)]
            public string ParserDbType { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("DbNum")]
            [Validation(Required=false)]
            public long? DbNum { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("Collation")]
            [Validation(Required=false)]
            public string Collation { get; set; }

            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("AutoCreateSchema")]
            [Validation(Required=false)]
            public bool? AutoCreateSchema { get; set; }

            [NameInMap("UpdateStatus")]
            [Validation(Required=false)]
            public string UpdateStatus { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("Charset")]
            [Validation(Required=false)]
            public string Charset { get; set; }

            [NameInMap("EnvMode")]
            [Validation(Required=false)]
            public string EnvMode { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("PhysicalSchemaCount")]
            [Validation(Required=false)]
            public long? PhysicalSchemaCount { get; set; }

            [NameInMap("GmtValid")]
            [Validation(Required=false)]
            public string GmtValid { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("OpenReadAndWriteSeparation")]
            [Validation(Required=false)]
            public bool? OpenReadAndWriteSeparation { get; set; }

            [NameInMap("EnvTenant")]
            [Validation(Required=false)]
            public string EnvTenant { get; set; }

            [NameInMap("ExpansionJobId")]
            [Validation(Required=false)]
            public string ExpansionJobId { get; set; }

            [NameInMap("LatestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("AutoUpdateVersion")]
            [Validation(Required=false)]
            public bool? AutoUpdateVersion { get; set; }

            [NameInMap("SchemaGroupType")]
            [Validation(Required=false)]
            public long? SchemaGroupType { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("NodeSchemaMappings")]
            [Validation(Required=false)]
            public List<BatchqueryODPSchemasResponseBodyDataNodeSchemaMappings> NodeSchemaMappings { get; set; }
            public class BatchqueryODPSchemasResponseBodyDataNodeSchemaMappings : TeaModel {
                [NameInMap("SchemaPattern")]
                [Validation(Required=false)]
                public string SchemaPattern { get; set; }

                [NameInMap("PowerfulUsername")]
                [Validation(Required=false)]
                public string PowerfulUsername { get; set; }

                [NameInMap("PhysicalUsername")]
                [Validation(Required=false)]
                public string PhysicalUsername { get; set; }

                [NameInMap("PhysicalPassword")]
                [Validation(Required=false)]
                public string PhysicalPassword { get; set; }

                [NameInMap("SchemaCount")]
                [Validation(Required=false)]
                public long? SchemaCount { get; set; }

                [NameInMap("PowerfulPassword")]
                [Validation(Required=false)]
                public string PowerfulPassword { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

            }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
