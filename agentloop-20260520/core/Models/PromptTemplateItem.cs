// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class PromptTemplateItem : TeaModel {
        /// <summary>
        /// <para>The content, which supports {{variable name}} placeholders.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Please answer: {{question}}</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The role: system/user/assistant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

    }

}
