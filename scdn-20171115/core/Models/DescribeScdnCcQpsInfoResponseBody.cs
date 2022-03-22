// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnCcQpsInfoResponseBody : TeaModel {
        [NameInMap("Attacks")]
        [Validation(Required=false)]
        public DescribeScdnCcQpsInfoResponseBodyAttacks Attacks { get; set; }
        public class DescribeScdnCcQpsInfoResponseBodyAttacks : TeaModel {
            [NameInMap("Attack")]
            [Validation(Required=false)]
            public List<string> Attack { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TimeScopes")]
        [Validation(Required=false)]
        public DescribeScdnCcQpsInfoResponseBodyTimeScopes TimeScopes { get; set; }
        public class DescribeScdnCcQpsInfoResponseBodyTimeScopes : TeaModel {
            [NameInMap("TimeScope")]
            [Validation(Required=false)]
            public List<DescribeScdnCcQpsInfoResponseBodyTimeScopesTimeScope> TimeScope { get; set; }
            public class DescribeScdnCcQpsInfoResponseBodyTimeScopesTimeScope : TeaModel {
                public string Interval { get; set; }
                public string Start { get; set; }
            }
        };

        [NameInMap("Totals")]
        [Validation(Required=false)]
        public DescribeScdnCcQpsInfoResponseBodyTotals Totals { get; set; }
        public class DescribeScdnCcQpsInfoResponseBodyTotals : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=false)]
            public List<string> Total { get; set; }
        };

    }

}
