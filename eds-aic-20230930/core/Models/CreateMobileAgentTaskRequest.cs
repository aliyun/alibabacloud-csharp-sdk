// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateMobileAgentTaskRequest : TeaModel {
        /// <summary>
        /// <para>The agent ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agt-mobileagent</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The task input.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Open DingTalk and reply to the first 5 unread messages</para>
        /// </summary>
        [NameInMap("InputParam")]
        [Validation(Required=false)]
        public string InputParam { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Auto-reply to DingTalk messages</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of node IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpn-csbdhjcbvfd****</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public string NodeIds { get; set; }

        /// <summary>
        /// <para>The session ID. Tasks with the same session ID share the same context.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ses-261005-6ekkb1m9ls00</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The task type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mobile_use_agent</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
