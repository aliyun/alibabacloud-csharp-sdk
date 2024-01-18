// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain_intl20171218.Models
{
    public class BatchFuzzyMatchDomainSensitiveWordResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SensitiveWordMatchResultList")]
        [Validation(Required=false)]
        public BatchFuzzyMatchDomainSensitiveWordResponseBodySensitiveWordMatchResultList SensitiveWordMatchResultList { get; set; }
        public class BatchFuzzyMatchDomainSensitiveWordResponseBodySensitiveWordMatchResultList : TeaModel {
            [NameInMap("SensitiveWordMatchResult")]
            [Validation(Required=false)]
            public List<BatchFuzzyMatchDomainSensitiveWordResponseBodySensitiveWordMatchResultListSensitiveWordMatchResult> SensitiveWordMatchResult { get; set; }
            public class BatchFuzzyMatchDomainSensitiveWordResponseBodySensitiveWordMatchResultListSensitiveWordMatchResult : TeaModel {
                [NameInMap("Exist")]
                [Validation(Required=false)]
                public bool? Exist { get; set; }

                [NameInMap("Keyword")]
                [Validation(Required=false)]
                public string Keyword { get; set; }

                [NameInMap("MatchedSentiveWords")]
                [Validation(Required=false)]
                public BatchFuzzyMatchDomainSensitiveWordResponseBodySensitiveWordMatchResultListSensitiveWordMatchResultMatchedSentiveWords MatchedSentiveWords { get; set; }
                public class BatchFuzzyMatchDomainSensitiveWordResponseBodySensitiveWordMatchResultListSensitiveWordMatchResultMatchedSentiveWords : TeaModel {
                    [NameInMap("MatchedSensitiveWord")]
                    [Validation(Required=false)]
                    public List<BatchFuzzyMatchDomainSensitiveWordResponseBodySensitiveWordMatchResultListSensitiveWordMatchResultMatchedSentiveWordsMatchedSensitiveWord> MatchedSensitiveWord { get; set; }
                    public class BatchFuzzyMatchDomainSensitiveWordResponseBodySensitiveWordMatchResultListSensitiveWordMatchResultMatchedSentiveWordsMatchedSensitiveWord : TeaModel {
                        [NameInMap("Word")]
                        [Validation(Required=false)]
                        public string Word { get; set; }

                    }

                }

            }

        }

    }

}
