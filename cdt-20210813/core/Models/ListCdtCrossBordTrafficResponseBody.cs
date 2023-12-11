// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDT20210813.Models
{
    public class ListCdtCrossBordTrafficResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrafficDetails")]
        [Validation(Required=false)]
        public List<ListCdtCrossBordTrafficResponseBodyTrafficDetails> TrafficDetails { get; set; }
        public class ListCdtCrossBordTrafficResponseBodyTrafficDetails : TeaModel {
            [NameInMap("BusinessRegionId")]
            [Validation(Required=false)]
            public string BusinessRegionId { get; set; }

            [NameInMap("ProductTrafficDetails")]
            [Validation(Required=false)]
            public List<ListCdtCrossBordTrafficResponseBodyTrafficDetailsProductTrafficDetails> ProductTrafficDetails { get; set; }
            public class ListCdtCrossBordTrafficResponseBodyTrafficDetailsProductTrafficDetails : TeaModel {
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

        }

    }

}
