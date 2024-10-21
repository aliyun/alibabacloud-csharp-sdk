// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainSuffixResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D1C9DE44-1D7F-4F66-9653-00000</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuffixList")]
        [Validation(Required=false)]
        public QueryDomainSuffixResponseBodySuffixList SuffixList { get; set; }
        public class QueryDomainSuffixResponseBodySuffixList : TeaModel {
            [NameInMap("Suffix")]
            [Validation(Required=false)]
            public List<string> Suffix { get; set; }

        }

    }

}
