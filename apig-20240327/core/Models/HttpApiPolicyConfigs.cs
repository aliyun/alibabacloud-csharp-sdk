// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiPolicyConfigs : TeaModel {
        /// <summary>
        /// <para>The AI cache configuration.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("aiCacheConfig")]
        [Validation(Required=false)]
        public AiCacheConfig AiCacheConfig { get; set; }

        /// <summary>
        /// <para>The AI fallback configuration.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("aiFallbackConfig")]
        [Validation(Required=false)]
        public AiFallbackConfig AiFallbackConfig { get; set; }

        /// <summary>
        /// <para>The AI web search configuration.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("aiNetworkSearchConfig")]
        [Validation(Required=false)]
        public AiNetworkSearchConfig AiNetworkSearchConfig { get; set; }

        /// <summary>
        /// <para>The AI security protection configuration.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("aiSecurityGuardConfig")]
        [Validation(Required=false)]
        public AiSecurityGuardConfig AiSecurityGuardConfig { get; set; }

        /// <summary>
        /// <para>The AI statistics configuration.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("aiStatisticsConfig")]
        [Validation(Required=false)]
        public AiStatisticsConfig AiStatisticsConfig { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The AI token rate limiting configuration.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("aiTokenRateLimitConfig")]
        [Validation(Required=false)]
        [Obsolete]
        public AiTokenRateLimitConfig AiTokenRateLimitConfig { get; set; }

        /// <summary>
        /// <para>The AI tool selection configuration.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("aiToolSelectionConfig")]
        [Validation(Required=false)]
        public AiToolSelectionConfig AiToolSelectionConfig { get; set; }

        /// <summary>
        /// <para>Indicates whether the policy is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The read-only compatible reference. GetHttpApi returns policyId/policyAttachmentId for ModelAPI AiTokenRateLimit. This must be stripped before write path persistence and is not used as a bind/unbind instruction.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("policyReference")]
        [Validation(Required=false)]
        public HttpApiPolicyReference PolicyReference { get; set; }

        /// <summary>
        /// <para>The semantic routing configuration.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("semanticRouterConfig")]
        [Validation(Required=false)]
        public HttpApiPolicyConfigsSemanticRouterConfig SemanticRouterConfig { get; set; }
        public class HttpApiPolicyConfigsSemanticRouterConfig : TeaModel {
            /// <summary>
            /// <para>The timeout period, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("timeoutMillisecond")]
            [Validation(Required=false)]
            public int? TimeoutMillisecond { get; set; }

        }

        /// <summary>
        /// <para>The policy template type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>K8S</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
