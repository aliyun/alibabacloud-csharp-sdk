// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpdatePolarClawAgentShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>work</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;FileName&quot;:&quot;SOUL.md&quot;,&quot;FileContent&quot;:&quot;You are a helpful assistant.&quot;}]</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public string FilesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>claude-sonnet-4-5</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Work Bot</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Restart")]
        [Validation(Required=false)]
        public bool? Restart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/home/node/.openclaw/workspace-work-v2</para>
        /// </summary>
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
