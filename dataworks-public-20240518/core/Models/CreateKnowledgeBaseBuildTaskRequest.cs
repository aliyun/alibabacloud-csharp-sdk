// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateKnowledgeBaseBuildTaskRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency token for the creation request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-create-001</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The language of the content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("ContentLocale")]
        [Validation(Required=false)]
        public string ContentLocale { get; set; }

        /// <summary>
        /// <para>The description of the task. The description can be up to 1,024 characters in length. If this parameter is omitted, no description is set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sales metrics and policy documents</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies the input scope by selecting projects, entities, sources, or files based on the type.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public CreateKnowledgeBaseBuildTaskRequestInput Input { get; set; }
        public class CreateKnowledgeBaseBuildTaskRequestInput : TeaModel {
            /// <summary>
            /// <para>The Data Map entities such as databases, schemas, and tables selected for data asset-scoped builds. The list cannot be empty and must contain unique values.</para>
            /// </summary>
            [NameInMap("Entities")]
            [Validation(Required=false)]
            public List<CreateKnowledgeBaseBuildTaskRequestInputEntities> Entities { get; set; }
            public class CreateKnowledgeBaseBuildTaskRequestInputEntities : TeaModel {
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
            /// <para>Required when building from document objects in the current knowledge base. The list cannot be empty and must contain unique values. Each item is the KnowledgeObjectId of a DOCUMENT type object in the current knowledge base. This parameter cannot be mixed with SourceIds for external connector synchronization scopes.</para>
            /// </summary>
            [NameInMap("KnowledgeObjectIds")]
            [Validation(Required=false)]
            public List<string> KnowledgeObjectIds { get; set; }

            /// <summary>
            /// <para>The IDs of the DataWorks workspaces selected for workspace-scoped builds. The list cannot be empty and must contain unique values.</para>
            /// </summary>
            [NameInMap("ProjectIds")]
            [Validation(Required=false)]
            public List<long?> ProjectIds { get; set; }

            /// <summary>
            /// <para>The IDs of the registered sources in the current knowledge base. The list must contain unique values. Whether this parameter is required and the allowed source types depend on the task input scenario. For more information, see the following table.</para>
            /// </summary>
            [NameInMap("SourceIds")]
            [Validation(Required=false)]
            public List<string> SourceIds { get; set; }

            /// <summary>
            /// <para>The YAML upload session ID in the current knowledge base used for SEMANTIC_MODEL import tasks. This ID is bound when the task is created and cannot be mixed with other input scopes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>upload-yaml-001</para>
            /// </summary>
            [NameInMap("YamlUploadId")]
            [Validation(Required=false)]
            public string YamlUploadId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the knowledge base to which the task belongs.</para>
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
        /// <para>model-001</para>
        /// </summary>
        [NameInMap("LlmModel")]
        [Validation(Required=false)]
        public string LlmModel { get; set; }

        /// <summary>
        /// <para>The name of the task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Project space knowledge building</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the workspace where the task runs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67890</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The resource group and Builder compute units (CUs).</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RuntimeResource")]
        [Validation(Required=false)]
        public CreateKnowledgeBaseBuildTaskRequestRuntimeResource RuntimeResource { get; set; }
        public class CreateKnowledgeBaseBuildTaskRequestRuntimeResource : TeaModel {
            /// <summary>
            /// <para>The Builder compute specifications. Valid values: 4 to 16. If this parameter is omitted during creation, the default value is 4. The actual valid value is returned in read operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Cu")]
            [Validation(Required=false)]
            public int? Cu { get; set; }

            /// <summary>
            /// <para>The ID of the DataWorks resource group used by the actual Builder nodes. The server validates that the resource group is available in the workspace corresponding to the top-level ProjectId of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-001</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

        }

        /// <summary>
        /// <para>The manual or periodic trigger configuration.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public CreateKnowledgeBaseBuildTaskRequestTrigger Trigger { get; set; }
        public class CreateKnowledgeBaseBuildTaskRequestTrigger : TeaModel {
            /// <summary>
            /// <para>The DataWorks scheduling cron expression. This parameter is provided only when the mode is set to PERIODIC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 2 * * ?</para>
            /// </summary>
            [NameInMap("Cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable or disable automatic periodic triggering. This parameter is provided only when the mode is set to PERIODIC and does not indicate the instance status.</para>
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
        /// <para>The available build types.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROJECT_SPACE_BUILD</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
