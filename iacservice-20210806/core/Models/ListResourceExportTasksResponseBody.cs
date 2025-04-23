// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListResourceExportTasksResponseBody : TeaModel {
        [NameInMap("exportTasks")]
        [Validation(Required=false)]
        public List<ListResourceExportTasksResponseBodyExportTasks> ExportTasks { get; set; }
        public class ListResourceExportTasksResponseBodyExportTasks : TeaModel {
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
            public List<ListResourceExportTasksResponseBodyExportTasksExcludeRules> ExcludeRules { get; set; }
            public class ListResourceExportTasksResponseBodyExportTasksExcludeRules : TeaModel {
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            [NameInMap("exportStatus")]
            [Validation(Required=false)]
            public string ExportStatus { get; set; }

            [NameInMap("exportTaskId")]
            [Validation(Required=false)]
            public string ExportTaskId { get; set; }

            [NameInMap("exportToModule")]
            [Validation(Required=false)]
            public ListResourceExportTasksResponseBodyExportTasksExportToModule ExportToModule { get; set; }
            public class ListResourceExportTasksResponseBodyExportTasksExportToModule : TeaModel {
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

            [NameInMap("hasDestroy")]
            [Validation(Required=false)]
            public bool? HasDestroy { get; set; }

            [NameInMap("includeRules")]
            [Validation(Required=false)]
            public List<ListResourceExportTasksResponseBodyExportTasksIncludeRules> IncludeRules { get; set; }
            public class ListResourceExportTasksResponseBodyExportTasksIncludeRules : TeaModel {
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            [NameInMap("modules")]
            [Validation(Required=false)]
            public List<ListResourceExportTasksResponseBodyExportTasksModules> Modules { get; set; }
            public class ListResourceExportTasksResponseBodyExportTasksModules : TeaModel {
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
            public List<ListResourceExportTasksResponseBodyExportTasksVariables> Variables { get; set; }
            public class ListResourceExportTasksResponseBodyExportTasksVariables : TeaModel {
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
