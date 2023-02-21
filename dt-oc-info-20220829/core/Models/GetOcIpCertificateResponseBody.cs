// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcIpCertificateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcIpCertificateResponseBodyData> Data { get; set; }
        public class GetOcIpCertificateResponseBodyData : TeaModel {
            [NameInMap("AuthorizeDate")]
            [Validation(Required=false)]
            public string AuthorizeDate { get; set; }

            [NameInMap("AuthorizeDepartment")]
            [Validation(Required=false)]
            public string AuthorizeDepartment { get; set; }

            [NameInMap("CertNum")]
            [Validation(Required=false)]
            public string CertNum { get; set; }

            [NameInMap("CertScope")]
            [Validation(Required=false)]
            public string CertScope { get; set; }

            [NameInMap("CertType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            [NameInMap("PubDate")]
            [Validation(Required=false)]
            public string PubDate { get; set; }

            [NameInMap("ValidEndDate")]
            [Validation(Required=false)]
            public string ValidEndDate { get; set; }

            [NameInMap("ValidStartDate")]
            [Validation(Required=false)]
            public string ValidStartDate { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
