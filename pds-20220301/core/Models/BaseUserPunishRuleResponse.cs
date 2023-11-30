// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class BaseUserPunishRuleResponse : TeaModel {
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<BaseUserPunishRuleResponseResults> Results { get; set; }
        public class BaseUserPunishRuleResponseResults : TeaModel {
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
