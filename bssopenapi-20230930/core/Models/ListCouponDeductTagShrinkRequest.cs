// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ListCouponDeductTagShrinkRequest : TeaModel {
        [NameInMap("CouponId")]
        [Validation(Required=false)]
        public string CouponId { get; set; }

        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public string EcIdAccountIdsShrink { get; set; }

        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

    }

}
