// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDT20210813.Models
{
    public class ListCdtInternetTrafficResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrafficDetails")]
        [Validation(Required=false)]
        public List<ListCdtInternetTrafficResponseBodyTrafficDetails> TrafficDetails { get; set; }
        public class ListCdtInternetTrafficResponseBodyTrafficDetails : TeaModel {
            [NameInMap("BusinessRegionId")]
            [Validation(Required=false)]
            public string BusinessRegionId { get; set; }

            [NameInMap("ISPType")]
            [Validation(Required=false)]
            public string ISPType { get; set; }

            [NameInMap("ProductTrafficDetails")]
            [Validation(Required=false)]
            public List<ListCdtInternetTrafficResponseBodyTrafficDetailsProductTrafficDetails> ProductTrafficDetails { get; set; }
            public class ListCdtInternetTrafficResponseBodyTrafficDetailsProductTrafficDetails : TeaModel {
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                [NameInMap("Traffic")]
                [Validation(Required=false)]
                public long? Traffic { get; set; }

            }

            [NameInMap("Traffic")]
            [Validation(Required=false)]
            public long? Traffic { get; set; }

            [NameInMap("TrafficTierDetails")]
            [Validation(Required=false)]
            public List<ListCdtInternetTrafficResponseBodyTrafficDetailsTrafficTierDetails> TrafficTierDetails { get; set; }
            public class ListCdtInternetTrafficResponseBodyTrafficDetailsTrafficTierDetails : TeaModel {
                [NameInMap("HighestTraffic")]
                [Validation(Required=false)]
                public long? HighestTraffic { get; set; }

                [NameInMap("LowestTraffic")]
                [Validation(Required=false)]
                public long? LowestTraffic { get; set; }

                [NameInMap("Tier")]
                [Validation(Required=false)]
                public long? Tier { get; set; }

                [NameInMap("Traffic")]
                [Validation(Required=false)]
                public long? Traffic { get; set; }

            }

        }

    }

}
