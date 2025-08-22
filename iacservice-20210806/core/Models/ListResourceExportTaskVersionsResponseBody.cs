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
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-05-11T02:18:50Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4521</para>
            /// </summary>
            [NameInMap("elapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ex-al1711jl6hd8u5crggeq6v</para>
            /// </summary>
            [NameInMap("exportTaskId")]
            [Validation(Required=false)]
            public string ExportTaskId { get; set; }

            [NameInMap("exportToModule")]
            [Validation(Required=false)]
            public ListResourceExportTaskVersionsResponseBodyExportTasksExportToModule ExportToModule { get; set; }
            public class ListResourceExportTaskVersionsResponseBodyExportTasksExportToModule : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>alibaba/security-group/alicloud</para>
                /// </summary>
                [NameInMap("sourcePath")]
                [Validation(Required=false)]
                public string SourcePath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("statePath")]
                [Validation(Required=false)]
                public string StatePath { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v3</para>
            /// </summary>
            [NameInMap("exportVersion")]
            [Validation(Required=false)]
            public string ExportVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Reason</para>
            /// </summary>
            [NameInMap("failedReason")]
            [Validation(Required=false)]
            public string FailedReason { get; set; }

            [NameInMap("includeRules")]
            [Validation(Required=false)]
            public List<ListResourceExportTaskVersionsResponseBodyExportTasksIncludeRules> IncludeRules { get; set; }
            public class ListResourceExportTaskVersionsResponseBodyExportTasksIncludeRules : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ZoneId</para>
                /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oss::https://.oss-cn-hangzhou.aliyuncs.com/xxx.zip</para>
                /// </summary>
                [NameInMap("sourcePath")]
                [Validation(Required=false)]
                public string SourcePath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc_all</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>Vswitch</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>860FDEEE-1CA3-55F3-97F6-63FC40B7962D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>72</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
