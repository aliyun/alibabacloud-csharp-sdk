// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class UpdateAccountProfileInfoRequest : TeaModel {
        [NameInMap("AccountAttribute")]
        [Validation(Required=false)]
        public string AccountAttribute { get; set; }

        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("Address2")]
        [Validation(Required=false)]
        public string Address2 { get; set; }

        [NameInMap("BindAlipayNo")]
        [Validation(Required=false)]
        public string BindAlipayNo { get; set; }

        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        [NameInMap("CityJsonString")]
        [Validation(Required=false)]
        public Dictionary<string, object> CityJsonString { get; set; }

        [NameInMap("ContactMethod")]
        [Validation(Required=false)]
        public string ContactMethod { get; set; }

        [NameInMap("DistrictJsonString")]
        [Validation(Required=false)]
        public Dictionary<string, object> DistrictJsonString { get; set; }

        [NameInMap("Fax")]
        [Validation(Required=false)]
        public string Fax { get; set; }

        [NameInMap("FirstName")]
        [Validation(Required=false)]
        public string FirstName { get; set; }

        [NameInMap("Head")]
        [Validation(Required=false)]
        public string Head { get; set; }

        [NameInMap("HeadColor")]
        [Validation(Required=false)]
        public string HeadColor { get; set; }

        [NameInMap("LastName")]
        [Validation(Required=false)]
        public string LastName { get; set; }

        [NameInMap("PK")]
        [Validation(Required=false)]
        public string PK { get; set; }

        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("PostCode")]
        [Validation(Required=false)]
        public string PostCode { get; set; }

        [NameInMap("ProvinceJsonString")]
        [Validation(Required=false)]
        public Dictionary<string, object> ProvinceJsonString { get; set; }

        [NameInMap("SelfServicingBusinessRegNum")]
        [Validation(Required=false)]
        public string SelfServicingBusinessRegNum { get; set; }

        [NameInMap("SelfServicingIdentificationNum")]
        [Validation(Required=false)]
        public string SelfServicingIdentificationNum { get; set; }

        [NameInMap("TrueName")]
        [Validation(Required=false)]
        public string TrueName { get; set; }

    }

}
