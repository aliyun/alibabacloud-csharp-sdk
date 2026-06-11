// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiPolicyConfigs : TeaModel {
        /// <summary>
        /// <para>AiCacheConfig</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("aiCacheConfig")]
        [Validation(Required=false)]
        public AiCacheConfig AiCacheConfig { get; set; }

        /// <summary>
        /// <para>AiFallbackConfig</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("aiFallbackConfig")]
        [Validation(Required=false)]
        public AiFallbackConfig AiFallbackConfig { get; set; }

        /// <summary>
        /// <para>AiNetworkSearchConfig</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("aiNetworkSearchConfig")]
        [Validation(Required=false)]
        public AiNetworkSearchConfig AiNetworkSearchConfig { get; set; }

        /// <summary>
        /// <para>AiSecurityGuardConfig</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("aiSecurityGuardConfig")]
        [Validation(Required=false)]
        public AiSecurityGuardConfig AiSecurityGuardConfig { get; set; }

        /// <summary>
        /// <para>AiStatisticsConfig</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("aiStatisticsConfig")]
        [Validation(Required=false)]
        public AiStatisticsConfig AiStatisticsConfig { get; set; }

        /// <summary>
        /// <para>AiTokenRateLimitConfig</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("aiTokenRateLimitConfig")]
        [Validation(Required=false)]
        public AiTokenRateLimitConfig AiTokenRateLimitConfig { get; set; }

        /// <summary>
        /// <para>AiToolSelectionConfig</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("aiToolSelectionConfig")]
        [Validation(Required=false)]
        public AiToolSelectionConfig AiToolSelectionConfig { get; set; }

        /// <summary>
        /// <para>Policy Enable</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>SemanticRouterConfig</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("semanticRouterConfig")]
        [Validation(Required=false)]
        public HttpApiPolicyConfigsSemanticRouterConfig SemanticRouterConfig { get; set; }
        public class HttpApiPolicyConfigsSemanticRouterConfig : TeaModel {
            /// <summary>
            /// <para>Timeout in milliseconds</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("timeoutMillisecond")]
            [Validation(Required=false)]
            public int? TimeoutMillisecond { get; set; }

        }

        /// <summary>
        /// <para>Policy Type</para>
        /// 
        /// <b>Example:</b>
        /// <para>K8S</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
