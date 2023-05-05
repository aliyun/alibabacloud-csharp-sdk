// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DescribeMaliciousAddressRequest : TeaModel {
        [NameInMap("Coin")]
        [Validation(Required=false)]
        public string Coin { get; set; }

        [NameInMap("End")]
        [Validation(Required=false)]
        public string End { get; set; }

        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        [NameInMap("Start")]
        [Validation(Required=false)]
        public string Start { get; set; }

    }

}
