// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class StopChatRequest : TeaModel {
        /// <summary>
        /// <para>Set this parameter to V2 to route to the ROS Agent V2 backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V2</para>
        /// </summary>
        [NameInMap("AgentVersion")]
        [Validation(Required=false)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// <para>The ID of the session to stop. The operation verifies that the session belongs to the current user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7f4e2a8c6d9b4a1f8e3c5b7d2a6f9012</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
