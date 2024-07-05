// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainReqTrafficDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("ReqTrafficDataPerInterval")]
        [Validation(Required=false)]
        public DescribeVsDomainReqTrafficDataResponseBodyReqTrafficDataPerInterval ReqTrafficDataPerInterval { get; set; }
        public class DescribeVsDomainReqTrafficDataResponseBodyReqTrafficDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVsDomainReqTrafficDataResponseBodyReqTrafficDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeVsDomainReqTrafficDataResponseBodyReqTrafficDataPerIntervalDataModule : TeaModel {
                [NameInMap("ReqTrafficValue")]
                [Validation(Required=false)]
                public string ReqTrafficValue { get; set; }

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
