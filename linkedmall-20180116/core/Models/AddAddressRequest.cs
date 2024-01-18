/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class AddAddressRequest : TeaModel {
        [NameInMap("AddressInfo")]
        [Validation(Required=false)]
        public string AddressInfo { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("ThirdPartyUserId")]
        [Validation(Required=false)]
        public string ThirdPartyUserId { get; set; }

        [NameInMap("UseAnonymousTbAccount")]
        [Validation(Required=false)]
        public bool? UseAnonymousTbAccount { get; set; }

    }

}
