// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnDomainHttpCodeDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DataPerInterval")]
        [Validation(Required=false)]
        public DescribeScdnDomainHttpCodeDataResponseBodyDataPerInterval DataPerInterval { get; set; }
        public class DescribeScdnDomainHttpCodeDataResponseBodyDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainHttpCodeDataResponseBodyDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeScdnDomainHttpCodeDataResponseBodyDataPerIntervalDataModule : TeaModel {
                [NameInMap("HttpCodeDataPerInterval")]
                [Validation(Required=false)]
                public DescribeScdnDomainHttpCodeDataResponseBodyDataPerIntervalDataModuleHttpCodeDataPerInterval HttpCodeDataPerInterval { get; set; }
                public class DescribeScdnDomainHttpCodeDataResponseBodyDataPerIntervalDataModuleHttpCodeDataPerInterval : TeaModel {
                    [NameInMap("HttpCodeDataModule")]
                    [Validation(Required=false)]
                    public List<DescribeScdnDomainHttpCodeDataResponseBodyDataPerIntervalDataModuleHttpCodeDataPerIntervalHttpCodeDataModule> HttpCodeDataModule { get; set; }
                    public class DescribeScdnDomainHttpCodeDataResponseBodyDataPerIntervalDataModuleHttpCodeDataPerIntervalHttpCodeDataModule : TeaModel {
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
