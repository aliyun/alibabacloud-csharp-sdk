// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnDomainQpsDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("QpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeScdnDomainQpsDataResponseBodyQpsDataPerInterval QpsDataPerInterval { get; set; }
        public class DescribeScdnDomainQpsDataResponseBodyQpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainQpsDataResponseBodyQpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeScdnDomainQpsDataResponseBodyQpsDataPerIntervalDataModule : TeaModel {
                [NameInMap("AccValue")]
                [Validation(Required=false)]
                public string AccValue { get; set; }

                [NameInMap("HttpAccValue")]
                [Validation(Required=false)]
                public string HttpAccValue { get; set; }

                /// <summary>
                /// http QPS。
                /// </summary>
                [NameInMap("HttpQpsValue")]
                [Validation(Required=false)]
                public string HttpQpsValue { get; set; }

                [NameInMap("HttpsAccValue")]
                [Validation(Required=false)]
                public string HttpsAccValue { get; set; }

                /// <summary>
                /// https QPS。
                /// </summary>
                [NameInMap("HttpsQpsValue")]
                [Validation(Required=false)]
                public string HttpsQpsValue { get; set; }

                [NameInMap("QpsValue")]
                [Validation(Required=false)]
                public string QpsValue { get; set; }

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
