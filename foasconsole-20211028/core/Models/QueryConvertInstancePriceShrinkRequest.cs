// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class QueryConvertInstancePriceShrinkRequest : TeaModel {
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IsAutoRenew")]
        [Validation(Required=false)]
        public bool? IsAutoRenew { get; set; }

        [NameInMap("NamespaceResourceSpecs")]
        [Validation(Required=false)]
        public string NamespaceResourceSpecsShrink { get; set; }

        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
