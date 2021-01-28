// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainWebsocketHttpCodeDataResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainWebsocketHttpCodeDataResponseBodyDataPerInterval DataPerInterval { get; set; }
        public class DescribeDcdnDomainWebsocketHttpCodeDataResponseBodyDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainWebsocketHttpCodeDataResponseBodyDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainWebsocketHttpCodeDataResponseBodyDataPerIntervalDataModule : TeaModel {
                [NameInMap("HttpCodeDataModule")]
                [Validation(Required=false)]
                public List<DescribeDcdnDomainWebsocketHttpCodeDataResponseBodyDataPerIntervalDataModuleHttpCodeDataModule> HttpCodeDataModule { get; set; }
                public class DescribeDcdnDomainWebsocketHttpCodeDataResponseBodyDataPerIntervalDataModuleHttpCodeDataModule : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    [NameInMap("Proportion")]
                    [Validation(Required=false)]
                    public float? Proportion { get; set; }

                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public float? Count { get; set; }

                }

            }
        };

    }

}
