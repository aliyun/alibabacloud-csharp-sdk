// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi_intl20211015.Models
{
    public class ListQualificationResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListQualificationResponseBodyList> List { get; set; }
        public class ListQualificationResponseBodyList : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("AuditRemark")]
            [Validation(Required=false)]
            public string AuditRemark { get; set; }

            [NameInMap("AuditTs")]
            [Validation(Required=false)]
            public string AuditTs { get; set; }

            [NameInMap("BusinessLicenseFileKey")]
            [Validation(Required=false)]
            public string BusinessLicenseFileKey { get; set; }

            [NameInMap("CommitTs")]
            [Validation(Required=false)]
            public string CommitTs { get; set; }

            [NameInMap("CompanyName")]
            [Validation(Required=false)]
            public string CompanyName { get; set; }

            [NameInMap("ContactEmail")]
            [Validation(Required=false)]
            public string ContactEmail { get; set; }

            [NameInMap("ContactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            [NameInMap("ContactPhone")]
            [Validation(Required=false)]
            public string ContactPhone { get; set; }

            [NameInMap("CountryId")]
            [Validation(Required=false)]
            public string CountryId { get; set; }

            [NameInMap("LegalId")]
            [Validation(Required=false)]
            public string LegalId { get; set; }

            [NameInMap("LegalLicenseFileKey")]
            [Validation(Required=false)]
            public string LegalLicenseFileKey { get; set; }

            [NameInMap("LegalName")]
            [Validation(Required=false)]
            public string LegalName { get; set; }

            [NameInMap("NetworkAccessFileKey")]
            [Validation(Required=false)]
            public string NetworkAccessFileKey { get; set; }

            [NameInMap("QualificationId")]
            [Validation(Required=false)]
            public string QualificationId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("UnifiedCode")]
            [Validation(Required=false)]
            public string UnifiedCode { get; set; }

            [NameInMap("UpdateTs")]
            [Validation(Required=false)]
            public string UpdateTs { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
