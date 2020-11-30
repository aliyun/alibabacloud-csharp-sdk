// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribleCertListResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("CertList")]
        [Validation(Required=true)]
        public List<DescribleCertListResponseCertList> CertList { get; set; }
        public class DescribleCertListResponseCertList : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=true)]
            public int? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }

            [NameInMap("Common")]
            [Validation(Required=true)]
            public string Common { get; set; }

            [NameInMap("Issuer")]
            [Validation(Required=true)]
            public string Issuer { get; set; }

            [NameInMap("StartDate")]
            [Validation(Required=true)]
            public string StartDate { get; set; }

            [NameInMap("EndDate")]
            [Validation(Required=true)]
            public string EndDate { get; set; }

            [NameInMap("DomainRelated")]
            [Validation(Required=true)]
            public bool? DomainRelated { get; set; }

        }

    }

}
