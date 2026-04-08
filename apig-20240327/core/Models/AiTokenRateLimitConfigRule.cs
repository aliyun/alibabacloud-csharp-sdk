// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiTokenRateLimitConfigRule : TeaModel {
        [NameInMap("limitMode")]
        [Validation(Required=false)]
        public string LimitMode { get; set; }

        [NameInMap("limitType")]
        [Validation(Required=false)]
        public string LimitType { get; set; }

        [NameInMap("limitValue")]
        [Validation(Required=false)]
        public int? LimitValue { get; set; }

        [NameInMap("matchKey")]
        [Validation(Required=false)]
        public string MatchKey { get; set; }

        [NameInMap("matchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        [NameInMap("matchValue")]
        [Validation(Required=false)]
        public string MatchValue { get; set; }

    }

}
