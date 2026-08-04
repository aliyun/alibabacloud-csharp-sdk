// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class UpdateAccountAddressInfoRequest : TeaModel {
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("Address2")]
        [Validation(Required=false)]
        public string Address2 { get; set; }

        [NameInMap("CityJsonString")]
        [Validation(Required=false)]
        public Dictionary<string, object> CityJsonString { get; set; }

        [NameInMap("DistrictJsonString")]
        [Validation(Required=false)]
        public Dictionary<string, object> DistrictJsonString { get; set; }

        [NameInMap("PK")]
        [Validation(Required=false)]
        public string PK { get; set; }

        [NameInMap("PostCode")]
        [Validation(Required=false)]
        public string PostCode { get; set; }

        [NameInMap("ProvinceJsonString")]
        [Validation(Required=false)]
        public Dictionary<string, object> ProvinceJsonString { get; set; }

    }

}
