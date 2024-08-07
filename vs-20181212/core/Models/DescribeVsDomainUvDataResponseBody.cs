// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainUvDataResponseBody : TeaModel {
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

        [NameInMap("UvDataInterval")]
        [Validation(Required=false)]
        public DescribeVsDomainUvDataResponseBodyUvDataInterval UvDataInterval { get; set; }
        public class DescribeVsDomainUvDataResponseBodyUvDataInterval : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<DescribeVsDomainUvDataResponseBodyUvDataIntervalUsageData> UsageData { get; set; }
            public class DescribeVsDomainUvDataResponseBodyUvDataIntervalUsageData : TeaModel {
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
