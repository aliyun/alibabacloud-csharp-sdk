// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class ChatRequest : TeaModel {
        /// <summary>
        /// <para>Optional. The agent ID. You can use the ID of an agent that is automatically generated when you enable DAS Agent, or the ID of a custom agent. If this parameter is omitted, the default agent is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ag-472T0DxtmjIxxxxx</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The message object.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;id&quot;:&quot;68fe0321-37fe-4c75-a118-b61b33156f6a&quot;,&quot;role&quot;:&quot;user&quot;,&quot;content&quot;:[{&quot;type&quot;:&quot;text&quot;,&quot;text&quot;:&quot;hello&quot;}]}</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Optional. The session ID, which must be a UUID. If unspecified, a new session is created. To maintain conversational context, use the same session ID for all subsequent requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return summary information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

    }

}
