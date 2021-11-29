// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainFileSizeProportionDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("FileSizeProportionDataInterval")]
        [Validation(Required=false)]
        public DescribeDomainFileSizeProportionDataResponseBodyFileSizeProportionDataInterval FileSizeProportionDataInterval { get; set; }
        public class DescribeDomainFileSizeProportionDataResponseBodyFileSizeProportionDataInterval : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<DescribeDomainFileSizeProportionDataResponseBodyFileSizeProportionDataIntervalUsageData> UsageData { get; set; }
            public class DescribeDomainFileSizeProportionDataResponseBodyFileSizeProportionDataIntervalUsageData : TeaModel {
                public string TimeStamp { get; set; }
                public DescribeDomainFileSizeProportionDataResponseBodyFileSizeProportionDataIntervalUsageDataValue Value { get; set; }
                public class DescribeDomainFileSizeProportionDataResponseBodyFileSizeProportionDataIntervalUsageDataValue : TeaModel {
                    [NameInMap("FileSizeProportionData")]
                    [Validation(Required=false)]
                    public List<DescribeDomainFileSizeProportionDataResponseBodyFileSizeProportionDataIntervalUsageDataValueFileSizeProportionData> FileSizeProportionData { get; set; }
                    public class DescribeDomainFileSizeProportionDataResponseBodyFileSizeProportionDataIntervalUsageDataValueFileSizeProportionData : TeaModel {
                        [NameInMap("FileSize")]
                        [Validation(Required=false)]
                        public string FileSize { get; set; }

                        [NameInMap("Proportion")]
                        [Validation(Required=false)]
                        public string Proportion { get; set; }

                    }

                }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
