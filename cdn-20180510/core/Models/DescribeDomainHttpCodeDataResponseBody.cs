// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainHttpCodeDataResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("HttpCodeData")]
        [Validation(Required=false)]
        public DescribeDomainHttpCodeDataResponseBodyHttpCodeData HttpCodeData { get; set; }
        public class DescribeDomainHttpCodeDataResponseBodyHttpCodeData : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<DescribeDomainHttpCodeDataResponseBodyHttpCodeDataUsageData> UsageData { get; set; }
            public class DescribeDomainHttpCodeDataResponseBodyHttpCodeDataUsageData : TeaModel {
                public string TimeStamp { get; set; }
                public DescribeDomainHttpCodeDataResponseBodyHttpCodeDataUsageDataValue Value { get; set; }
                public class DescribeDomainHttpCodeDataResponseBodyHttpCodeDataUsageDataValue : TeaModel {
                    [NameInMap("CodeProportionData")]
                    [Validation(Required=false)]
                    public List<DescribeDomainHttpCodeDataResponseBodyHttpCodeDataUsageDataValueCodeProportionData> CodeProportionData { get; set; }
                    public class DescribeDomainHttpCodeDataResponseBodyHttpCodeDataUsageDataValueCodeProportionData : TeaModel {
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        [NameInMap("Proportion")]
                        [Validation(Required=false)]
                        public string Proportion { get; set; }

                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public string Count { get; set; }

                    }

                }
            }
        };

    }

}
