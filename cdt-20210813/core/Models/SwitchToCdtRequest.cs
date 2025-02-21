// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDT20210813.Models
{
    public class SwitchToCdtRequest : TeaModel {
        [NameInMap("BillingType")]
        [Validation(Required=false)]
        public string BillingType { get; set; }

        [NameInMap("BusinessRegionId")]
        [Validation(Required=false)]
        public string BusinessRegionId { get; set; }

        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

    }

}
