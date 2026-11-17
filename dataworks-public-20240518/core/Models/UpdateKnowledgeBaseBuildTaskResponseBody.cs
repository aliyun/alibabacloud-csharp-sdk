// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateKnowledgeBaseBuildTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The business error code, which is used to determine the error type when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data returned when the request is successful.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateKnowledgeBaseBuildTaskResponseBodyData Data { get; set; }
        public class UpdateKnowledgeBaseBuildTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The content language of this task. This parameter is optional and is explicitly selected when the task is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh-CN</para>
            /// </summary>
            [NameInMap("ContentLocale")]
            [Validation(Required=false)]
            public string ContentLocale { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1790200000000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The task description. This parameter is optional.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sales metrics and policy documents</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The input scope specified based on the task type.</para>
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public UpdateKnowledgeBaseBuildTaskResponseBodyDataInput Input { get; set; }
            public class UpdateKnowledgeBaseBuildTaskResponseBodyDataInput : TeaModel {
                /// <summary>
                /// <para>The Data Map entities such as databases, schemas, and tables selected for data asset-scoped builds. The list cannot be empty and must contain unique values.</para>
                /// </summary>
                [NameInMap("Entities")]
                [Validation(Required=false)]
                public List<UpdateKnowledgeBaseBuildTaskResponseBodyDataInputEntities> Entities { get; set; }
                public class UpdateKnowledgeBaseBuildTaskResponseBodyDataInputEntities : TeaModel {
                    /// <summary>
                    /// <para>The metadata entity ID returned by Data Map. The client must pass this value as is and must not concatenate database, schema, or table identifiers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>maxcompute-table:::project_name:schema_name:table_name</para>
                    /// </summary>
                    [NameInMap("EntityId")]
                    [Validation(Required=false)]
                    public string EntityId { get; set; }

                    /// <summary>
                    /// <para>The entity level, such as DATABASE, SCHEMA, or TABLE. The server validates this value based on the Data Map identity. The presence of an enum value does not guarantee that all engines support it.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TABLE</para>
                    /// </summary>
                    [NameInMap("EntityType")]
                    [Validation(Required=false)]
                    public string EntityType { get; set; }

                }

                /// <summary>
                /// <para>Required when building from document objects in this knowledge base. The list cannot be empty and must contain unique values. Each item is a KnowledgeObjectId with Type=DOCUMENT in this knowledge base. Do not mix this with SourceIds for external connector synchronization scopes.</para>
                /// </summary>
                [NameInMap("KnowledgeObjectIds")]
                [Validation(Required=false)]
                public List<string> KnowledgeObjectIds { get; set; }

                /// <summary>
                /// <para>The DataWorks workspace IDs selected for workspace-scoped builds. The list cannot be empty and must contain unique values.</para>
                /// </summary>
                [NameInMap("ProjectIds")]
                [Validation(Required=false)]
                public List<long?> ProjectIds { get; set; }

                /// <summary>
                /// <para>The IDs of registered sources in this knowledge base. The list must contain unique values. Whether this parameter is required and the allowed source types depend on the task input scenario. See the following table.</para>
                /// </summary>
                [NameInMap("SourceIds")]
                [Validation(Required=false)]
                public List<string> SourceIds { get; set; }

                /// <summary>
                /// <para>The YAML upload session ID in this knowledge base used for SEMANTIC_MODEL import tasks. This ID is bound when the task is created and cannot be mixed with other input scopes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>upload-yaml-001</para>
                /// </summary>
                [NameInMap("YamlUploadId")]
                [Validation(Required=false)]
                public string YamlUploadId { get; set; }

            }

            /// <summary>
            /// <para>The associated knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678-1234-4234-8234-123456789abc</para>
            /// </summary>
            [NameInMap("KnowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <para>The specific model ID or AUTO configured for tasks that require a model. If this parameter is omitted during creation, it is equivalent to AUTO. This parameter is not configured for tasks that do not call a model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AUTO</para>
            /// </summary>
            [NameInMap("LlmModel")]
            [Validation(Required=false)]
            public string LlmModel { get; set; }

            /// <summary>
            /// <para>The time when the definition was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1790200300000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sales Project Knowledge Building</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The DataWorks workspace ID where the task runs. This is different from the build asset scope specified by Input.ProjectIds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>67890</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The task runtime resource group and Builder compute specifications.</para>
            /// </summary>
            [NameInMap("RuntimeResource")]
            [Validation(Required=false)]
            public UpdateKnowledgeBaseBuildTaskResponseBodyDataRuntimeResource RuntimeResource { get; set; }
            public class UpdateKnowledgeBaseBuildTaskResponseBodyDataRuntimeResource : TeaModel {
                /// <summary>
                /// <para>The compute specifications of the Builder. Valid values: 4 to 16. If this parameter is omitted during creation, the valid value is 4. The read operation returns the valid value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Cu")]
                [Validation(Required=false)]
                public int? Cu { get; set; }

                /// <summary>
                /// <para>The DataWorks resource group ID used by the actual Builder node. The server validates that it is available in the workspace corresponding to the top-level ProjectId of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-001</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

            }

            /// <summary>
            /// <para>The stable task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The manual or periodic trigger configuration.</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public UpdateKnowledgeBaseBuildTaskResponseBodyDataTrigger Trigger { get; set; }
            public class UpdateKnowledgeBaseBuildTaskResponseBodyDataTrigger : TeaModel {
                /// <summary>
                /// <para>The DataWorks scheduling cron expression. This parameter is provided only when Mode is set to PERIODIC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 2 * * ?</para>
                /// </summary>
                [NameInMap("Cron")]
                [Validation(Required=false)]
                public string Cron { get; set; }

                /// <summary>
                /// <para>Specifies whether periodic automatic triggering is enabled. This parameter is provided only when Mode is set to PERIODIC. This parameter does not indicate the instance status.</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The trigger mode. Valid values: MANUAL and PERIODIC. Manual tasks do not create instances automatically.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MANUAL</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

            }

            /// <summary>
            /// <para>The task type. Valid values: PROJECT_SPACE_BUILD, SEMANTIC_GRAPH, DOCUMENT_GRAPH, DOCUMENT_SYNC, DOCUMENT_SYNC_AND_GRAPH, and SEMANTIC_MODEL. SEMANTIC_MODEL is used only for YAML import.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROJECT_SPACE_BUILD</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The secure error message returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request parameters are invalid</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
