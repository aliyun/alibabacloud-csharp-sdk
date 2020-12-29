// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20180713.Models
{
    public class DescribeUserCertificateListResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("CertificateList")]
        [Validation(Required=false)]
        public List<DescribeUserCertificateListResponseBodyCertificateList> CertificateList { get; set; }
        public class DescribeUserCertificateListResponseBodyCertificateList : TeaModel {
            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            [NameInMap("province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            [NameInMap("sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

            [NameInMap("common")]
            [Validation(Required=false)]
            public string Common { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            [NameInMap("issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            [NameInMap("buyInAliyun")]
            [Validation(Required=false)]
            public bool? BuyInAliyun { get; set; }

            [NameInMap("endDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("expired")]
            [Validation(Required=false)]
            public bool? Expired { get; set; }

            [NameInMap("fingerprint")]
            [Validation(Required=false)]
            public string Fingerprint { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("city")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

        }

        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

    }

}
