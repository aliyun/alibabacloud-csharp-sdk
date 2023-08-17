// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeElasticDailyPlanResponseBody : TeaModel {
        /// <summary>
        /// Details of the current-day scaling plans.
        /// </summary>
        [NameInMap("ElasticDailyPlanList")]
        [Validation(Required=false)]
        public List<DescribeElasticDailyPlanResponseBodyElasticDailyPlanList> ElasticDailyPlanList { get; set; }
        public class DescribeElasticDailyPlanResponseBodyElasticDailyPlanList : TeaModel {
            /// <summary>
            /// The start date of the current-day scaling plan. The date is in the yyyy-MM-dd format.
            /// </summary>
            [NameInMap("Day")]
            [Validation(Required=false)]
            public string Day { get; set; }

            /// <summary>
            /// The number of nodes involved in the scaling plan.
            /// 
            /// *   If ElasticPlanType is set to **worker**, a value of 0 or null is returned.
            /// *   If ElasticPlanType is set to **executorcombineworker** or **executor**, a value greater than 0 is returned.
            /// </summary>
            [NameInMap("ElasticNodeNum")]
            [Validation(Required=false)]
            public int? ElasticNodeNum { get; set; }

            /// <summary>
            /// The type of the scaling plan. Default value: executorcombineworker. Valid values:
            /// 
            /// *   **worker**: scales only elastic I/O resources.
            /// *   **executor**: scales only computing resources.
            /// *   **executorcombineworker**: scales both elastic I/O resources and computing resources by proportion.
            /// </summary>
            [NameInMap("ElasticPlanType")]
            [Validation(Required=false)]
            public string ElasticPlanType { get; set; }

            /// <summary>
            /// The resource specifications that can be scaled up by the scaling plan. Default value: 8 Core 64 GB. Valid values:
            /// 
            /// *   8 Core 64 GB
            /// *   16 Core 64 GB
            /// *   32 Core 64 GB
            /// *   64 Core 128 GB
            /// *   12 Core 96 GB
            /// *   24 Core 96 GB
            /// *   52 Core 86 GB
            /// </summary>
            [NameInMap("ElasticPlanWorkerSpec")]
            [Validation(Required=false)]
            public string ElasticPlanWorkerSpec { get; set; }

            /// <summary>
            /// The actual restoration time. The time is in the yyyy-MM-dd hh:mm:ss format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("EndTs")]
            [Validation(Required=false)]
            public string EndTs { get; set; }

            /// <summary>
            /// The scheduled restoration time. The time is in the yyyy-MM-dd hh:mm:ss format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("PlanEndTs")]
            [Validation(Required=false)]
            public string PlanEndTs { get; set; }

            /// <summary>
            /// The name of the scaling plan.
            /// </summary>
            [NameInMap("PlanName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }

            /// <summary>
            /// The scheduled scale-up time. The time is in the yyyy-MM-dd hh:mm:ss format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("PlanStartTs")]
            [Validation(Required=false)]
            public string PlanStartTs { get; set; }

            /// <summary>
            /// The name of the resource group.
            /// </summary>
            [NameInMap("ResourcePoolName")]
            [Validation(Required=false)]
            public string ResourcePoolName { get; set; }

            /// <summary>
            /// The actual scale-up time. The time is in the yyyy-MM-dd hh:mm:ss format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("StartTs")]
            [Validation(Required=false)]
            public string StartTs { get; set; }

            /// <summary>
            /// The execution state of the current-day scaling plan. Multiple values are separated by commas (,). Valid values:
            /// 
            /// *   **1**: The scaling plan is not executed.
            /// *   **2**: The scaling plan is being executed.
            /// *   **3**: The scaling plan is executed.
            /// *   **4**: The scaling plan fails to be executed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
