// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiTokenRateLimitConfigRule : TeaModel {
        /// <summary>
        /// <para>The throttling mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TokenPerMinute</para>
        /// </summary>
        [NameInMap("limitMode")]
        [Validation(Required=false)]
        public string LimitMode { get; set; }

        /// <summary>
        /// <para>The throttling type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Consumer</para>
        /// </summary>
        [NameInMap("limitType")]
        [Validation(Required=false)]
        public string LimitType { get; set; }

        /// <summary>
        /// <para>The throttling value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("limitValue")]
        [Validation(Required=false)]
        public int? LimitValue { get; set; }

        /// <summary>
        /// <para>The match key name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>X-API-Key</para>
        /// </summary>
        [NameInMap("matchKey")]
        [Validation(Required=false)]
        public string MatchKey { get; set; }

        /// <summary>
        /// <para>The matching method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Exact</para>
        /// </summary>
        [NameInMap("matchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        /// <summary>
        /// <para>The match value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>consumer-a</para>
        /// </summary>
        [NameInMap("matchValue")]
        [Validation(Required=false)]
        public string MatchValue { get; set; }

    }

}
