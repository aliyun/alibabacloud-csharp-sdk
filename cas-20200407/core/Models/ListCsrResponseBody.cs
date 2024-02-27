// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCsrResponseBody : TeaModel {
        [NameInMap("CsrList")]
        [Validation(Required=false)]
        public List<ListCsrResponseBodyCsrList> CsrList { get; set; }
        public class ListCsrResponseBodyCsrList : TeaModel {
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            [NameInMap("CorpName")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            [NameInMap("CountryCode")]
            [Validation(Required=false)]
            public string CountryCode { get; set; }

            /// <summary>
            /// CSR ID。
            /// </summary>
            [NameInMap("CsrId")]
            [Validation(Required=false)]
            public long? CsrId { get; set; }

            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            [NameInMap("HasPrivateKey")]
            [Validation(Required=false)]
            public bool? HasPrivateKey { get; set; }

            [NameInMap("KeySha2")]
            [Validation(Required=false)]
            public string KeySha2 { get; set; }

            [NameInMap("KeySize")]
            [Validation(Required=false)]
            public int? KeySize { get; set; }

            [NameInMap("Locality")]
            [Validation(Required=false)]
            public string Locality { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            [NameInMap("Sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

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
