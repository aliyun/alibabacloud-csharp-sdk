// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpdatePolarClawAgentRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the agent to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>work</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The new avatar for the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// <para>The file list to update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;FileName&quot;:&quot;SOUL.md&quot;,&quot;FileContent&quot;:&quot;You are a helpful assistant.&quot;}]</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<UpdatePolarClawAgentRequestFiles> Files { get; set; }
        public class UpdatePolarClawAgentRequestFiles : TeaModel {
            /// <summary>
            /// <para>The file content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>You are a helpful assistant.</para>
            /// </summary>
            [NameInMap("FileContent")]
            [Validation(Required=false)]
            public string FileContent { get; set; }

            /// <summary>
            /// <para>The file name. This must be one of the allowed file names: AGENTS.md, SOUL.md, TOOLS.md, IDENTITY.md, USER.md, HEARTBEAT.md, BOOTSTRAP.md, MEMORY.md, or MEMORY.alt.md.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SOUL.md</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

        }

        /// <summary>
        /// <para>The model to override the agent\&quot;s default setting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>claude-sonnet-4-5</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The new display name for the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Work Bot</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether to restart the gateway after the update. The default value is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Restart")]
        [Validation(Required=false)]
        public bool? Restart { get; set; }

        /// <summary>
        /// <para>The new path for the agent\&quot;s workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home/node/.openclaw/workspace-work-v2</para>
        /// </summary>
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
