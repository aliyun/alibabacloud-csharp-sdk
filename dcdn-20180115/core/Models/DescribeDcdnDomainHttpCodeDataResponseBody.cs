// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainHttpCodeDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainHttpCodeDataResponseBodyDataPerInterval DataPerInterval { get; set; }
        public class DescribeDcdnDomainHttpCodeDataResponseBodyDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainHttpCodeDataResponseBodyDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainHttpCodeDataResponseBodyDataPerIntervalDataModule : TeaModel {
                [NameInMap("HttpCodeDataPerInterval")]
                [Validation(Required=false)]
                public DescribeDcdnDomainHttpCodeDataResponseBodyDataPerIntervalDataModuleHttpCodeDataPerInterval HttpCodeDataPerInterval { get; set; }
                public class DescribeDcdnDomainHttpCodeDataResponseBodyDataPerIntervalDataModuleHttpCodeDataPerInterval : TeaModel {
                    [NameInMap("HttpCodeDataModule")]
                    [Validation(Required=false)]
                    public List<DescribeDcdnDomainHttpCodeDataResponseBodyDataPerIntervalDataModuleHttpCodeDataPerIntervalHttpCodeDataModule> HttpCodeDataModule { get; set; }
                    public class DescribeDcdnDomainHttpCodeDataResponseBodyDataPerIntervalDataModuleHttpCodeDataPerIntervalHttpCodeDataModule : TeaModel {
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public int? Code { get; set; }

                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public float? Count { get; set; }

                        [NameInMap("Proportion")]
                        [Validation(Required=false)]
                        public float? Proportion { get; set; }

                    }

                }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

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

    }

}
