// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class UpdateCustomAgentRequest : TeaModel {
        /// <summary>
        /// <para>The operation that you want to perform. Set the value to <b>UpdateCustomAgent</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ebe44453-3b41-4c74-94d1-01d088d7****</para>
        /// </summary>
        [NameInMap("CustomAgentId")]
        [Validation(Required=false)]
        public string CustomAgentId { get; set; }

        /// <summary>
        /// <para>The system prompts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableTools")]
        [Validation(Required=false)]
        public bool? EnableTools { get; set; }

        /// <summary>
        /// <para>The ID of the agent.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("SkillIds")]
        [Validation(Required=false)]
        public List<string> SkillIds { get; set; }

        /// <summary>
        /// <para>The name of the agent.</para>
        /// </summary>
        [NameInMap("SystemPrompt")]
        [Validation(Required=false)]
        public string SystemPrompt { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable tools.</para>
        /// </summary>
        [NameInMap("Tools")]
        [Validation(Required=false)]
        public List<string> Tools { get; set; }

    }

}
