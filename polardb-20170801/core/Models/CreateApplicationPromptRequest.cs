// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateApplicationPromptRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You must specify an application with <c>ApplicationType</c> set to <c>mem0</c>. You can first call the CreateApplication operation with <c>ApplicationType</c> set to <c>mem0</c> to create an application, and then pass the returned ApplicationId to this operation. This parameter does not apply to other application types such as standard PolarClaw or Supabase.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The prompt name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_prompt</para>
        /// </summary>
        [NameInMap("PromptName")]
        [Validation(Required=false)]
        public string PromptName { get; set; }

        /// <summary>
        /// <para>The prompt type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONVERSATION_SUMMERY
        /// SEMANTIC_MEMORY
        /// MEMORY_ANSWER_PROMPT
        /// USER_MEMORY_EXTRACTION_PROMPT
        /// AGENT_MEMORY_EXTRACTION_PROMPT
        /// PROCEDURAL_MEMORY_SYSTEM_PROMPT
        /// RETRIEVE_NODES_PROMPT
        /// EXTRACT_RELATIONS_PROMPT
        /// UPDATE_GRAPH_PROMPT
        /// DELETE_RELATIONS_SYSTEM_PROMPT</para>
        /// </summary>
        [NameInMap("PromptType")]
        [Validation(Required=false)]
        public string PromptType { get; set; }

        /// <summary>
        /// <para>The prompt content.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prompt content</para>
        /// </summary>
        [NameInMap("PromptValue")]
        [Validation(Required=false)]
        public string PromptValue { get; set; }

    }

}
