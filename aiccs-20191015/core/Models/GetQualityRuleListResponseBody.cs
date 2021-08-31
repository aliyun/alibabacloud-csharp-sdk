// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetQualityRuleListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQualityRuleListResponseBodyData Data { get; set; }
        public class GetQualityRuleListResponseBodyData : TeaModel {
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
            [NameInMap("QualityRuleList")]
            [Validation(Required=false)]
            public List<GetQualityRuleListResponseBodyDataQualityRuleList> QualityRuleList { get; set; }
            public class GetQualityRuleListResponseBodyDataQualityRuleList : TeaModel {
                public int? RuleTag { get; set; }
                public int? MatchType { get; set; }
                public string Name { get; set; }
                public string RuleCreateTime { get; set; }
                public long? RuleId { get; set; }
                public List<string> KeyWords { get; set; }
            }
        };

    }

}
