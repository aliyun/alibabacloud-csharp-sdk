// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ClearAgentInstanceMemoryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the agent instance whose memory you want to clear. This parameter is required and can be obtained from the response of ListAgentInstanceMemory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agi-08vm****</para>
        /// </summary>
        [NameInMap("AgentInstanceId")]
        [Validation(Required=false)]
        public string AgentInstanceId { get; set; }

    }

}
