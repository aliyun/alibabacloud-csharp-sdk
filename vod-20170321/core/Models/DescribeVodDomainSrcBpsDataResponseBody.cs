// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainSrcBpsDataResponseBody : TeaModel {
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

        [NameInMap("SrcBpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeVodDomainSrcBpsDataResponseBodySrcBpsDataPerInterval SrcBpsDataPerInterval { get; set; }
        public class DescribeVodDomainSrcBpsDataResponseBodySrcBpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVodDomainSrcBpsDataResponseBodySrcBpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeVodDomainSrcBpsDataResponseBodySrcBpsDataPerIntervalDataModule : TeaModel {
                public string HttpsValue { get; set; }
                public string TimeStamp { get; set; }
                public string Value { get; set; }
            }
        };

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
