// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiTokenRateLimitConfig : TeaModel {
        /// <summary>
        /// <para>Controls whether global rules are enabled. If set to <c>true</c>, the rules in <c>globalRules</c> are applied. Defaults to <c>false</c>.</para>
        /// </summary>
        [NameInMap("enableGlobalRules")]
        [Validation(Required=false)]
        public bool? EnableGlobalRules { get; set; }

        /// <summary>
        /// <para>A list of global rate limit rules. These rules are applied when no specific rule in <c>rules</c> is matched.</para>
        /// </summary>
        [NameInMap("globalRules")]
        [Validation(Required=false)]
        public List<AiTokenRateLimitConfigRule> GlobalRules { get; set; }

        /// <summary>
        /// <para>Specifies the status of the plugin, such as <c>enabled</c> or <c>disabled</c>.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("pluginStatus")]
        [Validation(Required=false)]
        public AiPluginStatus PluginStatus { get; set; }

        /// <summary>
        /// <para>Specifies the Redis configuration for distributed rate limiting.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("redisConfig")]
        [Validation(Required=false)]
        public AiPolicyRedisConfig RedisConfig { get; set; }

        /// <summary>
        /// <para>A list of specific rate limit rules.</para>
        /// </summary>
        [NameInMap("rules")]
        [Validation(Required=false)]
        public List<AiTokenRateLimitConfigRule> Rules { get; set; }

    }

}
