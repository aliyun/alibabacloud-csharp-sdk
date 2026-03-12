// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20160511.Models
{
    public class SaveContactTemplateRequest : TeaModel {
        [NameInMap("CCity")]
        [Validation(Required=false)]
        public string CCity { get; set; }

        [NameInMap("CCompany")]
        [Validation(Required=false)]
        public string CCompany { get; set; }

        [NameInMap("CCountry")]
        [Validation(Required=false)]
        public string CCountry { get; set; }

        [NameInMap("CName")]
        [Validation(Required=false)]
        public string CName { get; set; }

        [NameInMap("CProvince")]
        [Validation(Required=false)]
        public string CProvince { get; set; }

        [NameInMap("CVenu")]
        [Validation(Required=false)]
        public string CVenu { get; set; }

        [NameInMap("ContactTemplateId")]
        [Validation(Required=false)]
        public long? ContactTemplateId { get; set; }

        [NameInMap("DefaultTemplate")]
        [Validation(Required=false)]
        public bool? DefaultTemplate { get; set; }

        [NameInMap("ECity")]
        [Validation(Required=false)]
        public string ECity { get; set; }

        [NameInMap("ECompany")]
        [Validation(Required=false)]
        public string ECompany { get; set; }

        [NameInMap("EName")]
        [Validation(Required=false)]
        public string EName { get; set; }

        [NameInMap("EProvince")]
        [Validation(Required=false)]
        public string EProvince { get; set; }

        [NameInMap("EVenu")]
        [Validation(Required=false)]
        public string EVenu { get; set; }

        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("PostalCode")]
        [Validation(Required=false)]
        public string PostalCode { get; set; }

        [NameInMap("RegType")]
        [Validation(Required=false)]
        public string RegType { get; set; }

        [NameInMap("TelArea")]
        [Validation(Required=false)]
        public string TelArea { get; set; }

        [NameInMap("TelExt")]
        [Validation(Required=false)]
        public string TelExt { get; set; }

        [NameInMap("TelMain")]
        [Validation(Required=false)]
        public string TelMain { get; set; }

        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
