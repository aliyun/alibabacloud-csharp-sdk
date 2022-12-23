// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainSrcTrafficDataResponseBody : TeaModel {
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

        [NameInMap("SrcTrafficDataPerInterval")]
        [Validation(Required=false)]
        public DescribeVodDomainSrcTrafficDataResponseBodySrcTrafficDataPerInterval SrcTrafficDataPerInterval { get; set; }
        public class DescribeVodDomainSrcTrafficDataResponseBodySrcTrafficDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVodDomainSrcTrafficDataResponseBodySrcTrafficDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeVodDomainSrcTrafficDataResponseBodySrcTrafficDataPerIntervalDataModule : TeaModel {
                [NameInMap("HttpsValue")]
                [Validation(Required=false)]
                public string HttpsValue { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TotalTraffic")]
        [Validation(Required=false)]
        public string TotalTraffic { get; set; }

    }

}
