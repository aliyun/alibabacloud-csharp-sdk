// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypns20170620.Models
{
    public class GetSmsSignResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetSmsSignResponseBodyData> Data { get; set; }
        public class GetSmsSignResponseBodyData : TeaModel {
            [NameInMap("AppUrl")]
            [Validation(Required=false)]
            public string AppUrl { get; set; }

            [NameInMap("AuditResult")]
            [Validation(Required=false)]
            public string AuditResult { get; set; }

            [NameInMap("BusinessLicenseCert")]
            [Validation(Required=false)]
            public string BusinessLicenseCert { get; set; }

            [NameInMap("BusinessLicenseCertId")]
            [Validation(Required=false)]
            public string BusinessLicenseCertId { get; set; }

            [NameInMap("CertType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public long? CreateDate { get; set; }

            [NameInMap("DefaultFlag")]
            [Validation(Required=false)]
            public bool? DefaultFlag { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("OrganizationCodeCert")]
            [Validation(Required=false)]
            public string OrganizationCodeCert { get; set; }

            [NameInMap("OrganizationCodeCertId")]
            [Validation(Required=false)]
            public string OrganizationCodeCertId { get; set; }

            [NameInMap("SmsSignName")]
            [Validation(Required=false)]
            public string SmsSignName { get; set; }

            [NameInMap("SmsSignRemark")]
            [Validation(Required=false)]
            public string SmsSignRemark { get; set; }

            [NameInMap("SmsSignSource")]
            [Validation(Required=false)]
            public string SmsSignSource { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaxRegistrationCert")]
            [Validation(Required=false)]
            public string TaxRegistrationCert { get; set; }

            [NameInMap("TaxRegistrationCertId")]
            [Validation(Required=false)]
            public string TaxRegistrationCertId { get; set; }

            [NameInMap("TestFlag")]
            [Validation(Required=false)]
            public bool? TestFlag { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
