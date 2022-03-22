// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnDDoSTrafficInfoResponseBody : TeaModel {
        [NameInMap("BpsDrops")]
        [Validation(Required=false)]
        public DescribeScdnDDoSTrafficInfoResponseBodyBpsDrops BpsDrops { get; set; }
        public class DescribeScdnDDoSTrafficInfoResponseBodyBpsDrops : TeaModel {
            [NameInMap("BpsDrop")]
            [Validation(Required=false)]
            public List<string> BpsDrop { get; set; }
        };

        [NameInMap("BpsTotals")]
        [Validation(Required=false)]
        public DescribeScdnDDoSTrafficInfoResponseBodyBpsTotals BpsTotals { get; set; }
        public class DescribeScdnDDoSTrafficInfoResponseBodyBpsTotals : TeaModel {
            [NameInMap("BpsTotal")]
            [Validation(Required=false)]
            public List<string> BpsTotal { get; set; }
        };

        [NameInMap("PpsDrops")]
        [Validation(Required=false)]
        public DescribeScdnDDoSTrafficInfoResponseBodyPpsDrops PpsDrops { get; set; }
        public class DescribeScdnDDoSTrafficInfoResponseBodyPpsDrops : TeaModel {
            [NameInMap("PpsDrop")]
            [Validation(Required=false)]
            public List<string> PpsDrop { get; set; }
        };

        [NameInMap("PpsTotals")]
        [Validation(Required=false)]
        public DescribeScdnDDoSTrafficInfoResponseBodyPpsTotals PpsTotals { get; set; }
        public class DescribeScdnDDoSTrafficInfoResponseBodyPpsTotals : TeaModel {
            [NameInMap("PpsTotal")]
            [Validation(Required=false)]
            public List<string> PpsTotal { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TimeScopes")]
        [Validation(Required=false)]
        public DescribeScdnDDoSTrafficInfoResponseBodyTimeScopes TimeScopes { get; set; }
        public class DescribeScdnDDoSTrafficInfoResponseBodyTimeScopes : TeaModel {
            [NameInMap("TimeScope")]
            [Validation(Required=false)]
            public List<DescribeScdnDDoSTrafficInfoResponseBodyTimeScopesTimeScope> TimeScope { get; set; }
            public class DescribeScdnDDoSTrafficInfoResponseBodyTimeScopesTimeScope : TeaModel {
                public string Interval { get; set; }
                public string Start { get; set; }
            }
        };

    }

}
