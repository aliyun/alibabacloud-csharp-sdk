// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bss20140714.Models
{
    public class DescribeCouponListRequest : TeaModel {
        [NameInMap("EndDeliveryTime")]
        [Validation(Required=false)]
        public string EndDeliveryTime { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("StartDeliveryTime")]
        [Validation(Required=false)]
        public string StartDeliveryTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
