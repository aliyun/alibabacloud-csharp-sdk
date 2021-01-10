// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetAKSPlanStatesRequest : TeaModel {
        [NameInMap("PlanQueryJsonStr")]
        [Validation(Required=false)]
        public string PlanQueryJsonStr { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
