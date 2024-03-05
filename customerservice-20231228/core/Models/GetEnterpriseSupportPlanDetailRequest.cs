// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CustomerService20231228.Models
{
    public class GetEnterpriseSupportPlanDetailRequest : TeaModel {
        [NameInMap("freeOrderApplyCodes")]
        [Validation(Required=false)]
        public List<string> FreeOrderApplyCodes { get; set; }

        [NameInMap("orderIds")]
        [Validation(Required=false)]
        public List<long?> OrderIds { get; set; }

    }

}
