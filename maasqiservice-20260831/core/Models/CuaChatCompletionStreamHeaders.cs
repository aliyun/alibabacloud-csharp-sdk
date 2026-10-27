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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qis_<instance_api_key></para>
        /// </summary>
        [NameInMap("X-QI-Agent-Api-Key")]
        [Validation(Required=false)]
        public string XQIAgentApiKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CUA_<instance_id></para>
        /// </summary>
        [NameInMap("X-QI-Instance-Id")]
        [Validation(Required=false)]
        public string XQIInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>session-cua-1</para>
        /// </summary>
        [NameInMap("X-QI-Session-Id")]
        [Validation(Required=false)]
        public string XQISessionId { get; set; }

    }

}
