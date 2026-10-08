// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class FuzzyMatchDomainSensitiveWordResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the domain name contains sensitive words. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The domain name contains sensitive words.  </description></item>
        /// <item><description><b>false</b>: The domain name does not contain sensitive words.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Exist")]
        [Validation(Required=false)]
        public bool? Exist { get; set; }

        /// <summary>
        /// <para>The domain name keyword that was passed in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx**</para>
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
                [NameInMap("Word")]
                [Validation(Required=false)]
                public string Word { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D15F91FD-0B34-4E48-8CBF-EFA5D2A31586</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
