// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class RateLimitRuleResult : TeaModel {
        /// <summary>
        /// <para>A value of <c>SUCCESS</c> indicates the request succeeded. On failure, this field returns the corresponding error type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the rate limit rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public RateLimitRule Data { get; set; }

        /// <summary>
        /// <para>A unique request identifier for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8A0F5F3-0C3E-4C82-9D4F-5E4B6A7C8D9E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
