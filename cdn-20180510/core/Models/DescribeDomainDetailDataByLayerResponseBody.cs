// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainDetailDataByLayerResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDomainDetailDataByLayerResponseBodyData Data { get; set; }
        public class DescribeDomainDetailDataByLayerResponseBodyData : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainDetailDataByLayerResponseBodyDataDataModule> DataModule { get; set; }
            public class DescribeDomainDetailDataByLayerResponseBodyDataDataModule : TeaModel {
                public long? Traf { get; set; }
                public float? Qps { get; set; }
                public float? Ipv6Qps { get; set; }
                public float? Ipv6Bps { get; set; }
                public long? Acc { get; set; }
                public long? Ipv6Traf { get; set; }
                public long? Ipv6Acc { get; set; }
                public string TimeStamp { get; set; }
                public string HttpCode { get; set; }
                public float? Bps { get; set; }
                public string DomainName { get; set; }
            }
        };

    }

}
