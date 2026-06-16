// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class RateLimitRule : TeaModel {
        /// <summary>
        /// <para>The creation time of the rate limit rule, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T10:30:00Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The descriptor ID for the rate limit rule, which associates the rule with a specific throttling target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model:gpt-4</para>
        /// </summary>
        [NameInMap("descriptorId")]
        [Validation(Required=false)]
        public string DescriptorId { get; set; }

        /// <summary>
        /// <para>The descriptor type for the rate limit rule, such as \&quot;model\&quot; or \&quot;user\&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model</para>
        /// </summary>
        [NameInMap("descriptorType")]
        [Validation(Required=false)]
        public string DescriptorType { get; set; }

        /// <summary>
        /// <para>Indicates whether the rate limit rule is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The last update time of the rate limit rule, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T11:45:00Z</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <para>The unique identifier for the rate limit rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-123456789abc</para>
        /// </summary>
        [NameInMap("rateLimitRuleId")]
        [Validation(Required=false)]
        public string RateLimitRuleId { get; set; }

        /// <summary>
        /// <para>A list of time window configurations. Multiple windows can be used to enforce layered rate limiting.</para>
        /// </summary>
        [NameInMap("windows")]
        [Validation(Required=false)]
        public List<WindowLimit> Windows { get; set; }

    }

}
