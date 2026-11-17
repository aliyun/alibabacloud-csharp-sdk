// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateKnowledgeBaseBuildTaskShrinkRequest : TeaModel {
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
        public string InputShrink { get; set; }

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
        public string RuntimeResourceShrink { get; set; }

        /// <summary>
        /// <para>The manual or periodic trigger configuration.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public string TriggerShrink { get; set; }

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
