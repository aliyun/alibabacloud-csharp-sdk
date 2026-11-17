// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class UpdateEvaluatorSkillRequest : TeaModel {
        /// <summary>
        /// <para>The name of the AgentSpace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod-agentspace</para>
        /// </summary>
        [NameInMap("agentSpace")]
        [Validation(Required=false)]
        public string AgentSpace { get; set; }

        /// <summary>
        /// <para>The description of the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Read trace context to assist evaluation</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Read Trace Context</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Specifies whether the skill is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The list of skill files. If specified, the content of the skill files is updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;SKILL.md&quot;,&quot;content&quot;:&quot;# Trace Context Loader&quot;,&quot;remark&quot;:&quot;Primary skill description&quot;}]</para>
        /// </summary>
        [NameInMap("files")]
        [Validation(Required=false)]
        public List<UpdateEvaluatorSkillRequestFiles> Files { get; set; }
        public class UpdateEvaluatorSkillRequestFiles : TeaModel {
            /// <summary>
            /// <para>The content of the skill file.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <h1>Trace Context Loader</h1>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The name of the skill file.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SKILL.md</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The remark for the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Primary skill description</para>
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// <para>The idempotency token. CloudSpec declares this query parameter, but the backend does not currently perform idempotency checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-1234-5678-90ab-cdef12345678</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
