// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainTrafficDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TotalTraffic")]
        [Validation(Required=false)]
        public string TotalTraffic { get; set; }

        [NameInMap("TrafficDataPerInterval")]
        [Validation(Required=false)]
        public DescribeVodDomainTrafficDataResponseBodyTrafficDataPerInterval TrafficDataPerInterval { get; set; }
        public class DescribeVodDomainTrafficDataResponseBodyTrafficDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVodDomainTrafficDataResponseBodyTrafficDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeVodDomainTrafficDataResponseBodyTrafficDataPerIntervalDataModule : TeaModel {
                public string DomesticValue { get; set; }
                public string HttpsDomesticValue { get; set; }
                public string HttpsOverseasValue { get; set; }
                public string HttpsValue { get; set; }
                public string OverseasValue { get; set; }
                public string TimeStamp { get; set; }
                public string Value { get; set; }
            }
        };

    }

}
