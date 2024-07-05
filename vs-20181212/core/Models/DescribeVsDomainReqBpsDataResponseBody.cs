// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainReqBpsDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("ReqBpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeVsDomainReqBpsDataResponseBodyReqBpsDataPerInterval ReqBpsDataPerInterval { get; set; }
        public class DescribeVsDomainReqBpsDataResponseBodyReqBpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVsDomainReqBpsDataResponseBodyReqBpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeVsDomainReqBpsDataResponseBodyReqBpsDataPerIntervalDataModule : TeaModel {
                [NameInMap("ReqBpsValue")]
                [Validation(Required=false)]
                public string ReqBpsValue { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
