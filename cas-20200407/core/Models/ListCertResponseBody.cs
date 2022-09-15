// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCertResponseBody : TeaModel {
        [NameInMap("CertList")]
        [Validation(Required=false)]
        public List<ListCertResponseBodyCertList> CertList { get; set; }
        public class ListCertResponseBodyCertList : TeaModel {
            [NameInMap("AfterDate")]
            [Validation(Required=false)]
            public long? AfterDate { get; set; }

            [NameInMap("BeforeDate")]
            [Validation(Required=false)]
            public long? BeforeDate { get; set; }

            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            [NameInMap("ExistPrivateKey")]
            [Validation(Required=false)]
            public bool? ExistPrivateKey { get; set; }

            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            [NameInMap("Sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("WhId")]
            [Validation(Required=false)]
            public long? WhId { get; set; }

            [NameInMap("WhInstanceId")]
            [Validation(Required=false)]
            public string WhInstanceId { get; set; }

        }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public long? ShowSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
