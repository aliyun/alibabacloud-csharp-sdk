// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20180713.Models
{
    public class DescribeUserCertificateDetailResponseBody : TeaModel {
        [NameInMap("Fingerprint")]
        [Validation(Required=false)]
        public string Fingerprint { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        [NameInMap("Expired")]
        [Validation(Required=false)]
        public bool? Expired { get; set; }

        [NameInMap("OrgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        [NameInMap("BuyInAliyun")]
        [Validation(Required=false)]
        public bool? BuyInAliyun { get; set; }

        [NameInMap("Common")]
        [Validation(Required=false)]
        public string Common { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("Sans")]
        [Validation(Required=false)]
        public string Sans { get; set; }

        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        [NameInMap("Cert")]
        [Validation(Required=false)]
        public string Cert { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

    }

}
