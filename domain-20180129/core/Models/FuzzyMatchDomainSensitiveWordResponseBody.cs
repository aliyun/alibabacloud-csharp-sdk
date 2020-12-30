// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class FuzzyMatchDomainSensitiveWordResponseBody : TeaModel {
        [NameInMap("Exist")]
        [Validation(Required=false)]
        public bool? Exist { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("MatchedSentiveWords")]
        [Validation(Required=false)]
        public FuzzyMatchDomainSensitiveWordResponseBodyMatchedSentiveWords MatchedSentiveWords { get; set; }
        public class FuzzyMatchDomainSensitiveWordResponseBodyMatchedSentiveWords : TeaModel {
            [NameInMap("MatchedSensitiveWord")]
            [Validation(Required=false)]
            public List<FuzzyMatchDomainSensitiveWordResponseBodyMatchedSentiveWordsMatchedSensitiveWord> MatchedSensitiveWord { get; set; }
            public class FuzzyMatchDomainSensitiveWordResponseBodyMatchedSentiveWordsMatchedSensitiveWord : TeaModel {
                public string Word { get; set; }
            }
        };

    }

}
