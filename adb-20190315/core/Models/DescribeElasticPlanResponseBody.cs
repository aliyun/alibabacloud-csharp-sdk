// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeElasticPlanResponseBody : TeaModel {
        [NameInMap("ElasticPlanList")]
        [Validation(Required=false)]
        public List<DescribeElasticPlanResponseBodyElasticPlanList> ElasticPlanList { get; set; }
        public class DescribeElasticPlanResponseBodyElasticPlanList : TeaModel {
            [NameInMap("ElasticNodeNum")]
            [Validation(Required=false)]
            public int? ElasticNodeNum { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("EndDay")]
            [Validation(Required=false)]
            public string EndDay { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("PlanName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }

            [NameInMap("ResourcePoolName")]
            [Validation(Required=false)]
            public string ResourcePoolName { get; set; }

            [NameInMap("StartDay")]
            [Validation(Required=false)]
            public string StartDay { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("WeeklyRepeat")]
            [Validation(Required=false)]
            public string WeeklyRepeat { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
