// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiTokenRateLimitConfig : TeaModel {
        [NameInMap("enableGlobalRules")]
        [Validation(Required=false)]
        public bool? EnableGlobalRules { get; set; }

        [NameInMap("globalRules")]
        [Validation(Required=false)]
        public List<AiTokenRateLimitConfigRule> GlobalRules { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("pluginStatus")]
        [Validation(Required=false)]
        public AiPluginStatus PluginStatus { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("redisConfig")]
        [Validation(Required=false)]
        public AiPolicyRedisConfig RedisConfig { get; set; }

        [NameInMap("rules")]
        [Validation(Required=false)]
        public List<AiTokenRateLimitConfigRule> Rules { get; set; }

    }

}
