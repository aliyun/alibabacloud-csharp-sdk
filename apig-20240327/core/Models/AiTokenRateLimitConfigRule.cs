// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiTokenRateLimitConfigRule : TeaModel {
        /// <summary>
        /// <para>The action to take when a request exceeds the token rate limit.</para>
        /// </summary>
        [NameInMap("limitMode")]
        [Validation(Required=false)]
        public string LimitMode { get; set; }

        /// <summary>
        /// <para>The scope of the rate limit, such as per user or per project.</para>
        /// </summary>
        [NameInMap("limitType")]
        [Validation(Required=false)]
        public string LimitType { get; set; }

        /// <summary>
        /// <para>The maximum number of tokens allowed within the defined time period. For example, if the time unit is one minute, this value represents the tokens-per-minute (TPM) limit.</para>
        /// </summary>
        [NameInMap("limitValue")]
        [Validation(Required=false)]
        public int? LimitValue { get; set; }

        /// <summary>
        /// <para>The key that identifies the request source. Its value is extracted from the request context to apply the rule.</para>
        /// </summary>
        [NameInMap("matchKey")]
        [Validation(Required=false)]
        public string MatchKey { get; set; }

        /// <summary>
        /// <para>The matching logic applied to the value of <c>matchKey</c>.</para>
        /// </summary>
        [NameInMap("matchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        /// <summary>
        /// <para>The value to match. The rate limit applies only when the value of <c>matchKey</c> in the request matches this value, according to the <c>matchType</c>.</para>
        /// </summary>
        [NameInMap("matchValue")]
        [Validation(Required=false)]
        public string MatchValue { get; set; }

    }

}
