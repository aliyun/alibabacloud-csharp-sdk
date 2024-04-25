// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainRealTimeHttpCodeDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RealTimeHttpCodeData")]
        [Validation(Required=false)]
        public DescribeVodDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeData RealTimeHttpCodeData { get; set; }
        public class DescribeVodDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeData : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<DescribeVodDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeDataUsageData> UsageData { get; set; }
            public class DescribeVodDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeDataUsageData : TeaModel {
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public DescribeVodDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeDataUsageDataValue Value { get; set; }
                public class DescribeVodDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeDataUsageDataValue : TeaModel {
                    [NameInMap("RealTimeCodeProportionData")]
                    [Validation(Required=false)]
                    public List<DescribeVodDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeDataUsageDataValueRealTimeCodeProportionData> RealTimeCodeProportionData { get; set; }
                    public class DescribeVodDomainRealTimeHttpCodeDataResponseBodyRealTimeHttpCodeDataUsageDataValueRealTimeCodeProportionData : TeaModel {
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public string Count { get; set; }

                        [NameInMap("Proportion")]
                        [Validation(Required=false)]
                        public string Proportion { get; set; }

                    }

                }

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
