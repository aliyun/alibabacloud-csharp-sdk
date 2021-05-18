// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetQualityRuleDetailResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQualityRuleDetailResponseBodyData Data { get; set; }
        public class GetQualityRuleDetailResponseBodyData : TeaModel {
            [NameInMap("RuleTag")]
            [Validation(Required=false)]
            public int? RuleTag { get; set; }
            [NameInMap("KeyWords")]
            [Validation(Required=false)]
            public List<string> KeyWords { get; set; }
            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public int? MatchType { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("RuleCreateTime")]
            [Validation(Required=false)]
            public string RuleCreateTime { get; set; }
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
