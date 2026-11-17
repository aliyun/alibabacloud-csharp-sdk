// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateKnowledgeBaseBuildTaskInstanceResponseBody : TeaModel {
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
        public CreateKnowledgeBaseBuildTaskInstanceResponseBodyData Data { get; set; }
        public class CreateKnowledgeBaseBuildTaskInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The snapshot of the model, content language, and runtime resources for this execution. This snapshot does not change when the task is updated.</para>
            /// </summary>
            [NameInMap("ConfigSnapshot")]
            [Validation(Required=false)]
            public CreateKnowledgeBaseBuildTaskInstanceResponseBodyDataConfigSnapshot ConfigSnapshot { get; set; }
            public class CreateKnowledgeBaseBuildTaskInstanceResponseBodyDataConfigSnapshot : TeaModel {
                /// <summary>
                /// <para>The content language used for this execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zh-CN</para>
                /// </summary>
                [NameInMap("ContentLocale")]
                [Validation(Required=false)]
                public string ContentLocale { get; set; }

                /// <summary>
                /// <para>The specific model ID actually used and frozen for this execution. AUTO is not returned. This parameter can be empty for tasks that do not call models, such as pure synchronization tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>model-001</para>
                /// </summary>
                [NameInMap("LlmModel")]
                [Validation(Required=false)]
                public string LlmModel { get; set; }

                /// <summary>
                /// <para>The DataWorks workspace ID used for this execution. This ID is frozen from the task definition when the instance is created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>67890</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The resource group and Builder CUs actually used for this execution.</para>
                /// </summary>
                [NameInMap("RuntimeResource")]
                [Validation(Required=false)]
                public CreateKnowledgeBaseBuildTaskInstanceResponseBodyDataConfigSnapshotRuntimeResource RuntimeResource { get; set; }
                public class CreateKnowledgeBaseBuildTaskInstanceResponseBodyDataConfigSnapshotRuntimeResource : TeaModel {
                    /// <summary>
                    /// <para>The Builder compute specifications. Valid values: 4 to 16. If this parameter is omitted during creation, the effective value is 4. The read operation returns the effective value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("Cu")]
                    [Validation(Required=false)]
                    public int? Cu { get; set; }

                    /// <summary>
                    /// <para>The DataWorks resource group ID used by the actual Builder nodes. The server validates that this resource group is available in the workspace corresponding to the top-level ProjectId of the task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rg-001</para>
                    /// </summary>
                    [NameInMap("ResourceGroupId")]
                    [Validation(Required=false)]
                    public string ResourceGroupId { get; set; }

                }

            }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1790200400000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The current business stage. This parameter is returned when reliable records are available. For common build stages and semantic model import stages, refer to the domain model. This parameter does not replace the overall status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INITIALIZE</para>
            /// </summary>
            [NameInMap("CurrentStage")]
            [Validation(Required=false)]
            public string CurrentStage { get; set; }

            /// <summary>
            /// <para>The error code and secure error message returned when the request fails.</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public CreateKnowledgeBaseBuildTaskInstanceResponseBodyDataError Error { get; set; }
            public class CreateKnowledgeBaseBuildTaskInstanceResponseBodyDataError : TeaModel {
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
                /// <para>The secure error message returned when the request fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The request parameters are invalid</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The time when the execution finished. This parameter is optional.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1790200060000</para>
            /// </summary>
            [NameInMap("FinishedTime")]
            [Validation(Required=false)]
            public long? FinishedTime { get; set; }

            /// <summary>
            /// <para>The confirmed ModelId and VersionNo for model imports only. For their structure, see GetKnowledgeBaseBuildTaskInstance.</para>
            /// </summary>
            [NameInMap("GeneratedModels")]
            [Validation(Required=false)]
            public List<CreateKnowledgeBaseBuildTaskInstanceResponseBodyDataGeneratedModels> GeneratedModels { get; set; }
            public class CreateKnowledgeBaseBuildTaskInstanceResponseBodyDataGeneratedModels : TeaModel {
                /// <summary>
                /// <para>The model ID generated by the semantic layer. You can use this ID as a KnowledgeObjectId to read the corresponding semantic model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>01MODELULID</para>
                /// </summary>
                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public string ModelId { get; set; }

                /// <summary>
                /// <para>The current version of the SEMANTIC_MODEL being read. Pass this value when updating content. The version can be edited in place.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("VersionNo")]
                [Validation(Required=false)]
                public long? VersionNo { get; set; }

            }

            /// <summary>
            /// <para>The non-sensitive input snapshot after selection and parsing for this execution. This snapshot does not change when the task is updated.</para>
            /// </summary>
            [NameInMap("InputSnapshot")]
            [Validation(Required=false)]
            public CreateKnowledgeBaseBuildTaskInstanceResponseBodyDataInputSnapshot InputSnapshot { get; set; }
            public class CreateKnowledgeBaseBuildTaskInstanceResponseBodyDataInputSnapshot : TeaModel {
                /// <summary>
                /// <para>The number of external document sources selected for this execution. This parameter is not returned when it is not applicable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DocumentSourceCount")]
                [Validation(Required=false)]
                public long? DocumentSourceCount { get; set; }

                /// <summary>
                /// <para>The actual Data Map entities resolved from the project, database, or schema scope for this execution. This parameter is not returned when it is not applicable.</para>
                /// </summary>
                [NameInMap("ResolvedEntities")]
                [Validation(Required=false)]
                public List<CreateKnowledgeBaseBuildTaskInstanceResponseBodyDataInputSnapshotResolvedEntities> ResolvedEntities { get; set; }
                public class CreateKnowledgeBaseBuildTaskInstanceResponseBodyDataInputSnapshotResolvedEntities : TeaModel {
                    /// <summary>
                    /// <para>The metadata entity ID returned by Data Map. The client passes this ID as is and does not concatenate database, schema, or table identifiers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>maxcompute-table:::project_name:schema_name:table_name</para>
                    /// </summary>
                    [NameInMap("EntityId")]
                    [Validation(Required=false)]
                    public string EntityId { get; set; }

                    /// <summary>
                    /// <para>The entity level, such as DATABASE, SCHEMA, or TABLE. The server validates this parameter based on the Data Map identity. The presence of an enum value does not guarantee that all engines support it.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TABLE</para>
                    /// </summary>
                    [NameInMap("EntityType")]
                    [Validation(Required=false)]
                    public string EntityType { get; set; }

                }

                /// <summary>
                /// <para>The total number of resolved entities. An accurate count is returned even if the array is not returned due to its size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>42</para>
                /// </summary>
                [NameInMap("ResolvedEntityCount")]
                [Validation(Required=false)]
                public long? ResolvedEntityCount { get; set; }

                /// <summary>
                /// <para>The snapshot of the selection conditions in the task definition when the instance is created. This snapshot does not change when the task is updated.</para>
                /// </summary>
                [NameInMap("SelectedInput")]
                [Validation(Required=false)]
                public CreateKnowledgeBaseBuildTaskInstanceResponseBodyDataInputSnapshotSelectedInput SelectedInput { get; set; }
                public class CreateKnowledgeBaseBuildTaskInstanceResponseBodyDataInputSnapshotSelectedInput : TeaModel {
                    /// <summary>
                    /// <para>The Data Map entities such as databases, schemas, and tables selected for data asset-scoped builds. The values are non-empty and deduplicated.</para>
                    /// </summary>
                    [NameInMap("Entities")]
                    [Validation(Required=false)]
                    public List<CreateKnowledgeBaseBuildTaskInstanceResponseBodyDataInputSnapshotSelectedInputEntities> Entities { get; set; }
                    public class CreateKnowledgeBaseBuildTaskInstanceResponseBodyDataInputSnapshotSelectedInputEntities : TeaModel {
                        /// <summary>
                        /// <para>The metadata entity ID returned by Data Map. The client passes this ID as is and does not concatenate database, schema, or table identifiers.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>maxcompute-table:::project_name:schema_name:table_name</para>
                        /// </summary>
                        [NameInMap("EntityId")]
                        [Validation(Required=false)]
                        public string EntityId { get; set; }

                        /// <summary>
                        /// <para>The entity level, such as DATABASE, SCHEMA, or TABLE. The server validates this parameter based on the Data Map identity. The presence of an enum value does not guarantee that all engines support it.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TABLE</para>
                        /// </summary>
                        [NameInMap("EntityType")]
                        [Validation(Required=false)]
                        public string EntityType { get; set; }

                    }

                    /// <summary>
                    /// <para>The knowledge object IDs required when building from document objects in this knowledge base. The values must be non-empty and deduplicated. Each item is a KnowledgeObjectId with Type=DOCUMENT in this knowledge base. Do not mix these IDs with SourceIds for external connector synchronization scopes.</para>
                    /// </summary>
                    [NameInMap("KnowledgeObjectIds")]
                    [Validation(Required=false)]
                    public List<string> KnowledgeObjectIds { get; set; }

                    /// <summary>
                    /// <para>The DataWorks workspace IDs selected for workspace-scoped builds. The values are non-empty and deduplicated.</para>
                    /// </summary>
                    [NameInMap("ProjectIds")]
                    [Validation(Required=false)]
                    public List<long?> ProjectIds { get; set; }

                    /// <summary>
                    /// <para>The IDs of registered sources in this knowledge base. The values are deduplicated. Whether this parameter is required and the allowed source types depend on the task input scenario. Refer to the following table.</para>
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

            }

            /// <summary>
            /// <para>The knowledge base ID, which is used for scope validation and queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678-1234-4234-8234-123456789abc</para>
            /// </summary>
            [NameInMap("KnowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <para>The time when the execution started. This parameter is optional.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1790200001000</para>
            /// </summary>
            [NameInMap("StartedTime")]
            [Validation(Required=false)]
            public long? StartedTime { get; set; }

            /// <summary>
            /// <para>The overall status of this execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The source task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The ID of this execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20001</para>
            /// </summary>
            [NameInMap("TaskInstanceId")]
            [Validation(Required=false)]
            public string TaskInstanceId { get; set; }

            /// <summary>
            /// <para>The trigger type of this execution, such as manual, periodic, or supported events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MANUAL</para>
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

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
        /// <para>The unique identifier of the request, which can be used to troubleshoot issues.</para>
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
