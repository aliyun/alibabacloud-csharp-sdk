// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainDetailDataByLayerResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDomainDetailDataByLayerResponseBodyData Data { get; set; }
        public class DescribeDomainDetailDataByLayerResponseBodyData : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainDetailDataByLayerResponseBodyDataDataModule> DataModule { get; set; }
            public class DescribeDomainDetailDataByLayerResponseBodyDataDataModule : TeaModel {
                [NameInMap("Acc")]
                [Validation(Required=false)]
                public long? Acc { get; set; }

                [NameInMap("Bps")]
                [Validation(Required=false)]
                public float? Bps { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("HttpCode")]
                [Validation(Required=false)]
                public string HttpCode { get; set; }

                [NameInMap("Ipv6Acc")]
                [Validation(Required=false)]
                public long? Ipv6Acc { get; set; }

                [NameInMap("Ipv6Bps")]
                [Validation(Required=false)]
                public float? Ipv6Bps { get; set; }

                [NameInMap("Ipv6Qps")]
                [Validation(Required=false)]
                public float? Ipv6Qps { get; set; }

                [NameInMap("Ipv6Traf")]
                [Validation(Required=false)]
                public long? Ipv6Traf { get; set; }

                [NameInMap("Qps")]
                [Validation(Required=false)]
                public float? Qps { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("Traf")]
                [Validation(Required=false)]
                public long? Traf { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
