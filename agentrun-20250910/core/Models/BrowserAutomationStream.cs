// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class BrowserAutomationStream : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>wss://browser-automation.cn-hangzhou.agentrun.aliyuncs.com/stream/bs-1234567890abcdef</para>
        /// </summary>
        [NameInMap("streamEndpoint")]
        [Validation(Required=false)]
        public string StreamEndpoint { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("streamStatus")]
        [Validation(Required=false)]
        public string StreamStatus { get; set; }

    }

}
