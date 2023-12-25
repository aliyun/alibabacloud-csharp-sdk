// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListOperationPlansResponseBody : TeaModel {
        [NameInMap("plans")]
        [Validation(Required=false)]
        public List<ListOperationPlansResponseBodyPlans> Plans { get; set; }
        public class ListOperationPlansResponseBodyPlans : TeaModel {
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            [NameInMap("end_time")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("plan_id")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            [NameInMap("start_time")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("target_id")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            [NameInMap("target_type")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
