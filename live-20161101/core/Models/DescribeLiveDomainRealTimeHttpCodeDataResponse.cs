// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainRealTimeHttpCodeDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=true)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=true)]
        public string EndTime { get; set; }

        [NameInMap("DataInterval")]
        [Validation(Required=true)]
        public string DataInterval { get; set; }

        [NameInMap("RealTimeHttpCodeData")]
        [Validation(Required=true)]
        public DescribeLiveDomainRealTimeHttpCodeDataResponseRealTimeHttpCodeData RealTimeHttpCodeData { get; set; }
        public class DescribeLiveDomainRealTimeHttpCodeDataResponseRealTimeHttpCodeData : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=true)]
            public List<DescribeLiveDomainRealTimeHttpCodeDataResponseRealTimeHttpCodeDataUsageData> UsageData { get; set; }
            public class DescribeLiveDomainRealTimeHttpCodeDataResponseRealTimeHttpCodeDataUsageData : TeaModel {
                public string TimeStamp { get; set; }
                public DescribeLiveDomainRealTimeHttpCodeDataResponseRealTimeHttpCodeDataUsageDataValue Value { get; set; }
                public class DescribeLiveDomainRealTimeHttpCodeDataResponseRealTimeHttpCodeDataUsageDataValue : TeaModel {
                    [NameInMap("RealTimeCodeProportionData")]
                    [Validation(Required=true)]
                    public List<DescribeLiveDomainRealTimeHttpCodeDataResponseRealTimeHttpCodeDataUsageDataValueRealTimeCodeProportionData> RealTimeCodeProportionData { get; set; }
                    public class DescribeLiveDomainRealTimeHttpCodeDataResponseRealTimeHttpCodeDataUsageDataValueRealTimeCodeProportionData : TeaModel {
                        [NameInMap("Code")]
                        [Validation(Required=true)]
                        public string Code { get; set; }

                        [NameInMap("Proportion")]
                        [Validation(Required=true)]
                        public string Proportion { get; set; }

                        [NameInMap("Count")]
                        [Validation(Required=true)]
                        public string Count { get; set; }

                    }

                }
            }
        };

    }

}
