// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class BenefitPkgDeliveryInfo : TeaModel {
        [NameInMap("amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("expire_time")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("is_permanent")]
        [Validation(Required=false)]
        public bool? IsPermanent { get; set; }

    }

}
