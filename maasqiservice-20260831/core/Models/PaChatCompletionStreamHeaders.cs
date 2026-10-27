// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaasQIService20260831.Models
{
    public class PaChatCompletionStreamHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The Agent instance access key used for QICloud Customer API authentication.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qis_xxx</para>
        /// </summary>
        [NameInMap("X-QI-Agent-Api-Key")]
        [Validation(Required=false)]
        public string XQIAgentApiKey { get; set; }

        /// <summary>
        /// <para>The published Mobile Planner Agent instance ID. Must correspond to the X-QI-Agent-Api-Key.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PA_xxx</para>
        /// </summary>
        [NameInMap("X-QI-Instance-Id")]
        [Validation(Required=false)]
        public string XQIInstanceId { get; set; }

        /// <summary>
        /// <para>The optional session identifier. Can be omitted for the first turn, in which case the server generates one. Pass it back in subsequent turns to continue the Mobile Planner Agent session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>session-xxx</para>
        /// </summary>
        [NameInMap("X-QI-Session-Id")]
        [Validation(Required=false)]
        public string XQISessionId { get; set; }

    }

}
