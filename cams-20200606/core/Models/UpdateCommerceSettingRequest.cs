// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdateCommerceSettingRequest : TeaModel {
        [NameInMap("CartEnable")]
        [Validation(Required=false)]
        public bool? CartEnable { get; set; }

        [NameInMap("CatalogVisible")]
        [Validation(Required=false)]
        public bool? CatalogVisible { get; set; }

        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

    }

}
