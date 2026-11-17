// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaasQIService20260831.Models
{
    public class CuaChatCompletionStreamHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The instance access key, which must match the instance. According to the original documentation, you can pass the original qis_ key or the Bearer format. It cannot replace the POP AK signature.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qis_<instance_api_key></para>
        /// </summary>
        [NameInMap("X-QI-Agent-Api-Key")]
        [Validation(Required=false)]
        public string XQIAgentApiKey { get; set; }

        /// <summary>
        /// <para>The ID of the target published CUA standard instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CUA_<instance_id></para>
        /// </summary>
        [NameInMap("X-QI-Instance-Id")]
        [Validation(Required=false)]
        public string XQIInstanceId { get; set; }

        /// <summary>
        /// <para>The request ID. We recommend that you explicitly generate it. Reuse it for retries of the same step, and use a new ID for a new step.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request_id</para>
        /// </summary>
        [NameInMap("X-QI-Request-Id")]
        [Validation(Required=false)]
        public string XQIRequestId { get; set; }

        /// <summary>
        /// <para>The session ID. It can be omitted in the first round. In subsequent rounds, reuse the qi_session_id returned in the body.</para>
        /// 
        /// <b>Example:</b>
        /// <para>session-cua-1</para>
        /// </summary>
        [NameInMap("X-QI-Session-Id")]
        [Validation(Required=false)]
        public string XQISessionId { get; set; }

    }

}
