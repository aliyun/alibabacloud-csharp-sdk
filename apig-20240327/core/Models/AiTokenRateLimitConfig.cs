// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiTokenRateLimitConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable global (API-level) throttling rules. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableGlobalRules")]
        [Validation(Required=false)]
        public bool? EnableGlobalRules { get; set; }

        /// <summary>
        /// <para>The list of global throttling rules. Only the LimitByGlobal type is allowed.</para>
        /// </summary>
        [NameInMap("globalRules")]
        [Validation(Required=false)]
        public List<AiTokenRateLimitConfigRule> GlobalRules { get; set; }

        /// <summary>
        /// <para>The running status of the plugin.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("pluginStatus")]
        [Validation(Required=false)]
        public AiPluginStatus PluginStatus { get; set; }

        /// <summary>
        /// <para>The Redis configuration.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("redisConfig")]
        [Validation(Required=false)]
        public AiPolicyRedisConfig RedisConfig { get; set; }

        /// <summary>
        /// <para>The list of throttling rules.</para>
        /// </summary>
        [NameInMap("rules")]
        [Validation(Required=false)]
        public List<AiTokenRateLimitConfigRule> Rules { get; set; }

    }

}
