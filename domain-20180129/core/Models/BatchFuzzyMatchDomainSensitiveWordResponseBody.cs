// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class BatchFuzzyMatchDomainSensitiveWordResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>C560A803-B975-481D-A66B-A4395EA863A1</para>
        /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Exist")]
                [Validation(Required=false)]
                public bool? Exist { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>example.com,aliyundoc.com</para>
                /// </summary>
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
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("Word")]
                        [Validation(Required=false)]
                        public string Word { get; set; }

                    }

                }

            }

        }

    }

}
