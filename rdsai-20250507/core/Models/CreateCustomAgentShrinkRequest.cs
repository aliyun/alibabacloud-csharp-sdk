// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateCustomAgentShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable tools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableTools")]
        [Validation(Required=false)]
        public bool? EnableTools { get; set; }

        /// <summary>
        /// <para>The name of the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>查询实例列表Agent</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("SkillIds")]
        [Validation(Required=false)]
        public string SkillIdsShrink { get; set; }

        /// <summary>
        /// <para>The system prompt.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>我是您用来查询实例列表的专属Agent</para>
        /// </summary>
        [NameInMap("SystemPrompt")]
        [Validation(Required=false)]
        public string SystemPrompt { get; set; }

        /// <summary>
        /// <para>The tool information.</para>
        /// </summary>
        [NameInMap("Tools")]
        [Validation(Required=false)]
        public string ToolsShrink { get; set; }

    }

}
