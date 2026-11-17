// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateKnowledgeBaseBuildTaskRequest : TeaModel {
        /// <summary>
        /// <para>The content language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("ContentLocale")]
        [Validation(Required=false)]
        public string ContentLocale { get; set; }

        /// <summary>
        /// <para>The new description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sales metrics and policy documents</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The input configuration that completely replaces the original input.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public UpdateKnowledgeBaseBuildTaskRequestInput Input { get; set; }
        public class UpdateKnowledgeBaseBuildTaskRequestInput : TeaModel {
            /// <summary>
            /// <para>The Data Map entities such as databases, schemas, and tables selected for data asset-scoped builds. The list cannot be empty and must contain unique values.</para>
            /// </summary>
            [NameInMap("Entities")]
            [Validation(Required=false)]
            public List<UpdateKnowledgeBaseBuildTaskRequestInputEntities> Entities { get; set; }
            public class UpdateKnowledgeBaseBuildTaskRequestInputEntities : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-4234-8234-123456789abc</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The specific model ID or AUTO.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO</para>
        /// </summary>
        [NameInMap("LlmModel")]
        [Validation(Required=false)]
        public string LlmModel { get; set; }

        /// <summary>
        /// <para>The new task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sales Project Knowledge Building</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The workspace used for future runs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67890</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>Updates the runtime resources based on the submitted fields. If ResourceGroupId or Cu is not provided, the original value is retained.</para>
        /// </summary>
        [NameInMap("RuntimeResource")]
        [Validation(Required=false)]
        public UpdateKnowledgeBaseBuildTaskRequestRuntimeResource RuntimeResource { get; set; }
        public class UpdateKnowledgeBaseBuildTaskRequestRuntimeResource : TeaModel {
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
        /// <para>The task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The trigger configuration that completely replaces the original trigger.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public UpdateKnowledgeBaseBuildTaskRequestTrigger Trigger { get; set; }
        public class UpdateKnowledgeBaseBuildTaskRequestTrigger : TeaModel {
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

    }

}
