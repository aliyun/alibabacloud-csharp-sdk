// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class FuzzyMatchDomainSensitiveWordResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Exist")]
        [Validation(Required=false)]
        public bool? Exist { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx**.cn</para>
        /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Word")]
                [Validation(Required=false)]
                public string Word { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D15F91FD-0B34-4E48-8CBF-EFA5D2A31586</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
