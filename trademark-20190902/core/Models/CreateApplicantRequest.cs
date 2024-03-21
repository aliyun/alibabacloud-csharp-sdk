// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class CreateApplicantRequest : TeaModel {
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("ApplicantName")]
        [Validation(Required=false)]
        public string ApplicantName { get; set; }

        [NameInMap("ApplicantRegion")]
        [Validation(Required=false)]
        public int? ApplicantRegion { get; set; }

        [NameInMap("ApplicantType")]
        [Validation(Required=false)]
        public int? ApplicantType { get; set; }

        [NameInMap("AuthorizationOssKey")]
        [Validation(Required=false)]
        public string AuthorizationOssKey { get; set; }

        [NameInMap("BusinessLicenceOssKey")]
        [Validation(Required=false)]
        public string BusinessLicenceOssKey { get; set; }

        [NameInMap("CardNumber")]
        [Validation(Required=false)]
        public string CardNumber { get; set; }

        [NameInMap("ContactAddress")]
        [Validation(Required=false)]
        public string ContactAddress { get; set; }

        [NameInMap("ContactCity")]
        [Validation(Required=false)]
        public string ContactCity { get; set; }

        [NameInMap("ContactCounty")]
        [Validation(Required=false)]
        public string ContactCounty { get; set; }

        [NameInMap("ContactDistrict")]
        [Validation(Required=false)]
        public string ContactDistrict { get; set; }

        [NameInMap("ContactEmail")]
        [Validation(Required=false)]
        public string ContactEmail { get; set; }

        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        [NameInMap("ContactNumber")]
        [Validation(Required=false)]
        public string ContactNumber { get; set; }

        [NameInMap("ContactProvince")]
        [Validation(Required=false)]
        public string ContactProvince { get; set; }

        [NameInMap("ContactZipcode")]
        [Validation(Required=false)]
        public string ContactZipcode { get; set; }

        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        [NameInMap("EAddress")]
        [Validation(Required=false)]
        public string EAddress { get; set; }

        [NameInMap("EName")]
        [Validation(Required=false)]
        public string EName { get; set; }

        [NameInMap("IdCardName")]
        [Validation(Required=false)]
        public string IdCardName { get; set; }

        [NameInMap("IdCardNumber")]
        [Validation(Required=false)]
        public string IdCardNumber { get; set; }

        [NameInMap("IdCardOssKey")]
        [Validation(Required=false)]
        public string IdCardOssKey { get; set; }

        [NameInMap("LegalNoticeOssKey")]
        [Validation(Required=false)]
        public string LegalNoticeOssKey { get; set; }

        [NameInMap("PassportOssKey")]
        [Validation(Required=false)]
        public string PassportOssKey { get; set; }

        [NameInMap("PersonalType")]
        [Validation(Required=false)]
        public long? PersonalType { get; set; }

        [NameInMap("PrincipalName")]
        [Validation(Required=false)]
        public int? PrincipalName { get; set; }

        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

    }

}
