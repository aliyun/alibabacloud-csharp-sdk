// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateCustomAgentRequest : TeaModel {
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
        /// <para>The operation that you want to perform. Set the value to <b>CreateCustomAgent</b>.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("SkillIds")]
        [Validation(Required=false)]
        public List<string> SkillIds { get; set; }

        /// <summary>
        /// <para>The name of the dedicated agent.</para>
        /// <para>This parameter is required.</para>
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
