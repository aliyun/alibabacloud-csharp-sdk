// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainStatusCodeListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StatusCodeList")]
        [Validation(Required=false)]
        public List<DescribeDomainStatusCodeListResponseBodyStatusCodeList> StatusCodeList { get; set; }
        public class DescribeDomainStatusCodeListResponseBodyStatusCodeList : TeaModel {
            [NameInMap("Status502")]
            [Validation(Required=false)]
            public long? Status502 { get; set; }

            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            [NameInMap("Status405")]
            [Validation(Required=false)]
            public long? Status405 { get; set; }

            [NameInMap("Status3XX")]
            [Validation(Required=false)]
            public long? Status3XX { get; set; }

            [NameInMap("Status503")]
            [Validation(Required=false)]
            public long? Status503 { get; set; }

            [NameInMap("Status4XX")]
            [Validation(Required=false)]
            public long? Status4XX { get; set; }

            [NameInMap("Status2XX")]
            [Validation(Required=false)]
            public long? Status2XX { get; set; }

            [NameInMap("Status5XX")]
            [Validation(Required=false)]
            public long? Status5XX { get; set; }

            [NameInMap("Status504")]
            [Validation(Required=false)]
            public long? Status504 { get; set; }

            [NameInMap("Status403")]
            [Validation(Required=false)]
            public long? Status403 { get; set; }

            [NameInMap("Status200")]
            [Validation(Required=false)]
            public long? Status200 { get; set; }

            [NameInMap("Status404")]
            [Validation(Required=false)]
            public long? Status404 { get; set; }

            [NameInMap("Status501")]
            [Validation(Required=false)]
            public long? Status501 { get; set; }

        }

    }

}
