// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class UpdateOrInsertEnterpriseInfoRequest : TeaModel {
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("Alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        [NameInMap("CityJsonString")]
        [Validation(Required=false)]
        public Dictionary<string, object> CityJsonString { get; set; }

        [NameInMap("EnterpriseSize")]
        [Validation(Required=false)]
        public string EnterpriseSize { get; set; }

        [NameInMap("Fax")]
        [Validation(Required=false)]
        public string Fax { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PK")]
        [Validation(Required=false)]
        public string PK { get; set; }

        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("ProvinceJsonString")]
        [Validation(Required=false)]
        public Dictionary<string, object> ProvinceJsonString { get; set; }

        [NameInMap("Years")]
        [Validation(Required=false)]
        public string Years { get; set; }

    }

}
