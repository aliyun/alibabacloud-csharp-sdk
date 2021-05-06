// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeElasticDailyPlanResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ElasticDailyPlanList")]
        [Validation(Required=false)]
        public List<DescribeElasticDailyPlanResponseBodyElasticDailyPlanList> ElasticDailyPlanList { get; set; }
        public class DescribeElasticDailyPlanResponseBodyElasticDailyPlanList : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Day")]
            [Validation(Required=false)]
            public string Day { get; set; }

            [NameInMap("ResourcePoolName")]
            [Validation(Required=false)]
            public string ResourcePoolName { get; set; }

            [NameInMap("StartTs")]
            [Validation(Required=false)]
            public string StartTs { get; set; }

            [NameInMap("PlanEndTs")]
            [Validation(Required=false)]
            public string PlanEndTs { get; set; }

            [NameInMap("PlanStartTs")]
            [Validation(Required=false)]
            public string PlanStartTs { get; set; }

            [NameInMap("ElasticNodeNum")]
            [Validation(Required=false)]
            public int? ElasticNodeNum { get; set; }

            [NameInMap("EndTs")]
            [Validation(Required=false)]
            public string EndTs { get; set; }

            [NameInMap("PlanName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }

        }

    }

}
