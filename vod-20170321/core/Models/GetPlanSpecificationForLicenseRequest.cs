// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetPlanSpecificationForLicenseRequest : TeaModel {
        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        [NameInMap("NeedItemSpecification")]
        [Validation(Required=false)]
        public bool? NeedItemSpecification { get; set; }

        [NameInMap("PlanCode")]
        [Validation(Required=false)]
        public string PlanCode { get; set; }

        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

    }

}
