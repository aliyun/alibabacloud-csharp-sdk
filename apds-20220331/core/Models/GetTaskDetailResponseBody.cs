// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Apds20220331.Models
{
    public class GetTaskDetailResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetTaskDetailResponseBodyData Data { get; set; }
        public class GetTaskDetailResponseBodyData : TeaModel {
            [NameInMap("ddlFilename")]
            [Validation(Required=false)]
            public string DdlFilename { get; set; }

            [NameInMap("ddlRelateType")]
            [Validation(Required=false)]
            public int? DdlRelateType { get; set; }

            [NameInMap("dqlAssociationDDLTaskList")]
            [Validation(Required=false)]
            public List<GetTaskDetailResponseBodyDataDqlAssociationDDLTaskList> DqlAssociationDDLTaskList { get; set; }
            public class GetTaskDetailResponseBodyDataDqlAssociationDDLTaskList : TeaModel {
                [NameInMap("ddlTaskId")]
                [Validation(Required=false)]
                public long? DdlTaskId { get; set; }

                [NameInMap("ddlTaskName")]
                [Validation(Required=false)]
                public string DdlTaskName { get; set; }

                [NameInMap("dqlTaskId")]
                [Validation(Required=false)]
                public long? DqlTaskId { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                [NameInMap("uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

            [NameInMap("dqlFilename")]
            [Validation(Required=false)]
            public string DqlFilename { get; set; }

            [NameInMap("dqlRelateDdlMessage")]
            [Validation(Required=false)]
            public string DqlRelateDdlMessage { get; set; }

            [NameInMap("dqlRelateTargetDatasourceId")]
            [Validation(Required=false)]
            public string DqlRelateTargetDatasourceId { get; set; }

            [NameInMap("dqlRelateTargetDatasourceName")]
            [Validation(Required=false)]
            public string DqlRelateTargetDatasourceName { get; set; }

            [NameInMap("dqlTestDatasourceId")]
            [Validation(Required=false)]
            public string DqlTestDatasourceId { get; set; }

            [NameInMap("dqlTestDatasourceName")]
            [Validation(Required=false)]
            public string DqlTestDatasourceName { get; set; }

            [NameInMap("dqlTestProject")]
            [Validation(Required=false)]
            public string DqlTestProject { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("lastImportTime")]
            [Validation(Required=false)]
            public string LastImportTime { get; set; }

            [NameInMap("scriptTransformStatus")]
            [Validation(Required=false)]
            public string ScriptTransformStatus { get; set; }

            [NameInMap("sourceDatasourceId")]
            [Validation(Required=false)]
            public string SourceDatasourceId { get; set; }

            [NameInMap("sourceDatasourceName")]
            [Validation(Required=false)]
            public string SourceDatasourceName { get; set; }

            [NameInMap("sourceDialect")]
            [Validation(Required=false)]
            public string SourceDialect { get; set; }

            [NameInMap("sourceProject")]
            [Validation(Required=false)]
            public string SourceProject { get; set; }

            [NameInMap("syntaxErrorCount")]
            [Validation(Required=false)]
            public int? SyntaxErrorCount { get; set; }

            [NameInMap("syntaxPassCount")]
            [Validation(Required=false)]
            public int? SyntaxPassCount { get; set; }

            [NameInMap("syntaxValidationStatus")]
            [Validation(Required=false)]
            public string SyntaxValidationStatus { get; set; }

            [NameInMap("targetDatasourceId")]
            [Validation(Required=false)]
            public string TargetDatasourceId { get; set; }

            [NameInMap("targetDatasourceName")]
            [Validation(Required=false)]
            public string TargetDatasourceName { get; set; }

            [NameInMap("targetDialect")]
            [Validation(Required=false)]
            public string TargetDialect { get; set; }

            [NameInMap("targetProject")]
            [Validation(Required=false)]
            public string TargetProject { get; set; }

            [NameInMap("taskDescription")]
            [Validation(Required=false)]
            public string TaskDescription { get; set; }

            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("taskType")]
            [Validation(Required=false)]
            public int? TaskType { get; set; }

            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            [NameInMap("transformFailureCount")]
            [Validation(Required=false)]
            public int? TransformFailureCount { get; set; }

            [NameInMap("transformSchema")]
            [Validation(Required=false)]
            public string TransformSchema { get; set; }

            [NameInMap("transformSuccessCount")]
            [Validation(Required=false)]
            public int? TransformSuccessCount { get; set; }

            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            [NameInMap("uploadedScriptUrl")]
            [Validation(Required=false)]
            public string UploadedScriptUrl { get; set; }

            [NameInMap("zipParsingState")]
            [Validation(Required=false)]
            public string ZipParsingState { get; set; }

        }

        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
