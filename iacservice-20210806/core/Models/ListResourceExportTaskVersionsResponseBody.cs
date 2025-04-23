// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListResourceExportTaskVersionsResponseBody : TeaModel {
        [NameInMap("exportTasks")]
        [Validation(Required=false)]
        public List<ListResourceExportTaskVersionsResponseBodyExportTasks> ExportTasks { get; set; }
        public class ListResourceExportTaskVersionsResponseBodyExportTasks : TeaModel {
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
            public List<ListResourceExportTaskVersionsResponseBodyExportTasksExcludeRules> ExcludeRules { get; set; }
            public class ListResourceExportTaskVersionsResponseBodyExportTasksExcludeRules : TeaModel {
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
            public ListResourceExportTaskVersionsResponseBodyExportTasksExportToModule ExportToModule { get; set; }
            public class ListResourceExportTaskVersionsResponseBodyExportTasksExportToModule : TeaModel {
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

            [NameInMap("hasDestroy")]
            [Validation(Required=false)]
            public bool? HasDestroy { get; set; }

            [NameInMap("includeRules")]
            [Validation(Required=false)]
            public List<ListResourceExportTaskVersionsResponseBodyExportTasksIncludeRules> IncludeRules { get; set; }
            public class ListResourceExportTaskVersionsResponseBodyExportTasksIncludeRules : TeaModel {
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            [NameInMap("modules")]
            [Validation(Required=false)]
            public List<ListResourceExportTaskVersionsResponseBodyExportTasksModules> Modules { get; set; }
            public class ListResourceExportTaskVersionsResponseBodyExportTasksModules : TeaModel {
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

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("variables")]
            [Validation(Required=false)]
            public List<ListResourceExportTaskVersionsResponseBodyExportTasksVariables> Variables { get; set; }
            public class ListResourceExportTaskVersionsResponseBodyExportTasksVariables : TeaModel {
                [NameInMap("properties")]
                [Validation(Required=false)]
                public List<string> Properties { get; set; }

                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
