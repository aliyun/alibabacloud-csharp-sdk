// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetResourceExportTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>FC49AA8C-0A19-5556-8929-E7447F18D529</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("task")]
        [Validation(Required=false)]
        public GetResourceExportTaskResponseBodyTask Task { get; set; }
        public class GetResourceExportTaskResponseBodyTask : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-06-15T02:44:37Z</para>
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
            /// <para>4533</para>
            /// </summary>
            [NameInMap("elapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ex-al1111jlfh53i6mo4o94jj</para>
            /// </summary>
            [NameInMap("exportTaskId")]
            [Validation(Required=false)]
            public string ExportTaskId { get; set; }

            [NameInMap("exportToModule")]
            [Validation(Required=false)]
            public GetResourceExportTaskResponseBodyTaskExportToModule ExportToModule { get; set; }
            public class GetResourceExportTaskResponseBodyTaskExportToModule : TeaModel {
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
            /// <para>v2</para>
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
            public List<GetResourceExportTaskResponseBodyTaskIncludeRules> IncludeRules { get; set; }
            public class GetResourceExportTaskResponseBodyTaskIncludeRules : TeaModel {
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
            public List<GetResourceExportTaskResponseBodyTaskModules> Modules { get; set; }
            public class GetResourceExportTaskResponseBodyTaskModules : TeaModel {
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
                /// <para>v3</para>
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
            /// <para>role</para>
            /// </summary>
            [NameInMap("ramRole")]
            [Validation(Required=false)]
            public string RamRole { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("taskOutputPath")]
            [Validation(Required=false)]
            public string TaskOutputPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("terraformContext")]
            [Validation(Required=false)]
            public Dictionary<string, object> TerraformContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.246.0</para>
            /// </summary>
            [NameInMap("terraformProviderVersion")]
            [Validation(Required=false)]
            public string TerraformProviderVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.2.6</para>
            /// </summary>
            [NameInMap("terraformVersion")]
            [Validation(Required=false)]
            public string TerraformVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>ALIYUN::Bastionhost::Instance</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

    }

}
