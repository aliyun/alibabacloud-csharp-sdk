// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class AddMem0MemoriesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>my-agent-space</para>
        /// </summary>
        [NameInMap("agentSpace")]
        [Validation(Required=false)]
        public string AgentSpace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;messages&quot;:[{&quot;role&quot;:&quot;user&quot;,&quot;content&quot;:&quot;我喜欢喝拿铁&quot;}],&quot;user_id&quot;:&quot;alice&quot;,&quot;metadata&quot;:{&quot;channel&quot;:&quot;app&quot;}}</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public Dictionary<string, object> Body { get; set; }

    }

}
