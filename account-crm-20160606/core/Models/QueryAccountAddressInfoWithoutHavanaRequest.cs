// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class QueryAccountAddressInfoWithoutHavanaRequest : TeaModel {
        [NameInMap("AddressVersion")]
        [Validation(Required=false)]
        public string AddressVersion { get; set; }

        [NameInMap("HavanaId")]
        [Validation(Required=false)]
        public string HavanaId { get; set; }

        [NameInMap("PK")]
        [Validation(Required=false)]
        public string PK { get; set; }

    }

}
