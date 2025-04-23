// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetResourceExportTaskResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("task")]
        [Validation(Required=false)]
        public GetResourceExportTaskResponseBodyTask Task { get; set; }
        public class GetResourceExportTaskResponseBodyTask : TeaModel {
            [NameInMap("configPath")]
            [Validation(Required=false)]
            public string ConfigPath { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("elapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

            [NameInMap("excludeRules")]
            [Validation(Required=false)]
            public List<GetResourceExportTaskResponseBodyTaskExcludeRules> ExcludeRules { get; set; }
            public class GetResourceExportTaskResponseBodyTaskExcludeRules : TeaModel {
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            [NameInMap("exportTaskId")]
            [Validation(Required=false)]
            public string ExportTaskId { get; set; }

            [NameInMap("exportToModule")]
            [Validation(Required=false)]
            public GetResourceExportTaskResponseBodyTaskExportToModule ExportToModule { get; set; }
            public class GetResourceExportTaskResponseBodyTaskExportToModule : TeaModel {
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("sourcePath")]
                [Validation(Required=false)]
                public string SourcePath { get; set; }

                [NameInMap("statePath")]
                [Validation(Required=false)]
                public string StatePath { get; set; }

            }

            [NameInMap("exportVersion")]
            [Validation(Required=false)]
            public string ExportVersion { get; set; }

            [NameInMap("failedReason")]
            [Validation(Required=false)]
            public string FailedReason { get; set; }

            [NameInMap("includeRules")]
            [Validation(Required=false)]
            public List<GetResourceExportTaskResponseBodyTaskIncludeRules> IncludeRules { get; set; }
            public class GetResourceExportTaskResponseBodyTaskIncludeRules : TeaModel {
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            [NameInMap("modules")]
            [Validation(Required=false)]
            public List<GetResourceExportTaskResponseBodyTaskModules> Modules { get; set; }
            public class GetResourceExportTaskResponseBodyTaskModules : TeaModel {
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("sourcePath")]
                [Validation(Required=false)]
                public string SourcePath { get; set; }

                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ramRole")]
            [Validation(Required=false)]
            public string RamRole { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("taskOutputPath")]
            [Validation(Required=false)]
            public string TaskOutputPath { get; set; }

            [NameInMap("terraformContext")]
            [Validation(Required=false)]
            public Dictionary<string, object> TerraformContext { get; set; }

            [NameInMap("terraformProviderVersion")]
            [Validation(Required=false)]
            public string TerraformProviderVersion { get; set; }

            [NameInMap("terraformVersion")]
            [Validation(Required=false)]
            public string TerraformVersion { get; set; }

            [NameInMap("triggerStrategy")]
            [Validation(Required=false)]
            public string TriggerStrategy { get; set; }

            [NameInMap("variables")]
            [Validation(Required=false)]
            public List<GetResourceExportTaskResponseBodyTaskVariables> Variables { get; set; }
            public class GetResourceExportTaskResponseBodyTaskVariables : TeaModel {
                [NameInMap("properties")]
                [Validation(Required=false)]
                public List<string> Properties { get; set; }

                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

    }

}
