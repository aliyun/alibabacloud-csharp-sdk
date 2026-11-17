// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateKnowledgeBaseBuildTaskShrinkRequest : TeaModel {
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
        public string InputShrink { get; set; }

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
        public string RuntimeResourceShrink { get; set; }

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
        public string TriggerShrink { get; set; }

    }

}
