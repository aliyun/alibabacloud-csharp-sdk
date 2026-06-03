// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypns20170620.Models
{
    public class GetEnterpriseInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEnterpriseInfoResponseBodyData Data { get; set; }
        public class GetEnterpriseInfoResponseBodyData : TeaModel {
            [NameInMap("AuditDesc")]
            [Validation(Required=false)]
            public string AuditDesc { get; set; }

            [NameInMap("AuditTime")]
            [Validation(Required=false)]
            public string AuditTime { get; set; }

            [NameInMap("BusinessLicenseAddress")]
            [Validation(Required=false)]
            public string BusinessLicenseAddress { get; set; }

            [NameInMap("BusinessLicensePicture")]
            [Validation(Required=false)]
            public string BusinessLicensePicture { get; set; }

            [NameInMap("EnterpriseId")]
            [Validation(Required=false)]
            public long? EnterpriseId { get; set; }

            [NameInMap("EnterpriseName")]
            [Validation(Required=false)]
            public string EnterpriseName { get; set; }

            [NameInMap("LegalPersonCertNumber")]
            [Validation(Required=false)]
            public string LegalPersonCertNumber { get; set; }

            [NameInMap("LegalPersonCertPicture")]
            [Validation(Required=false)]
            public string LegalPersonCertPicture { get; set; }

            [NameInMap("LegalPersonName")]
            [Validation(Required=false)]
            public string LegalPersonName { get; set; }

            [NameInMap("ManagerCertNumber")]
            [Validation(Required=false)]
            public string ManagerCertNumber { get; set; }

            [NameInMap("ManagerCertPicture")]
            [Validation(Required=false)]
            public string ManagerCertPicture { get; set; }

            [NameInMap("ManagerContactNumber")]
            [Validation(Required=false)]
            public string ManagerContactNumber { get; set; }

            [NameInMap("ManagerName")]
            [Validation(Required=false)]
            public string ManagerName { get; set; }

            [NameInMap("NumberApplicationLetterPicture")]
            [Validation(Required=false)]
            public string NumberApplicationLetterPicture { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            [NameInMap("OrganizationCode")]
            [Validation(Required=false)]
            public string OrganizationCode { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("UndertakingPicture")]
            [Validation(Required=false)]
            public string UndertakingPicture { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
