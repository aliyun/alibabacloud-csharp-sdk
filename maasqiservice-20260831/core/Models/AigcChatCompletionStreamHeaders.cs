// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaasQIService20260831.Models
{
    public class AigcChatCompletionStreamHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The instance access key. The key must belong to the Creative Agent instance being called. This key is different from the AccessKey Secret used for OpenAPI signing. Do not expose it publicly.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qis_xxx</para>
        /// </summary>
        [NameInMap("X-QI-Agent-Api-Key")]
        [Validation(Required=false)]
        public string XQIAgentApiKey { get; set; }

        /// <summary>
        /// <para>The published Creative Agent instance ID. Must correspond to the X-QI-Agent-Api-Key.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AIGC_xxx</para>
        /// </summary>
        [NameInMap("X-QI-Instance-Id")]
        [Validation(Required=false)]
        public string XQIInstanceId { get; set; }

        /// <summary>
        /// <para>The session identifier. Can be omitted for the first turn. Obtain it from the qi_session_id field in the SSE response and pass it back in subsequent turns. Use no more than 128 characters consisting of letters, digits, periods, underscores, colons, or hyphens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>session-xxx</para>
        /// </summary>
        [NameInMap("X-QI-Session-Id")]
        [Validation(Required=false)]
        public string XQISessionId { get; set; }

    }

}
