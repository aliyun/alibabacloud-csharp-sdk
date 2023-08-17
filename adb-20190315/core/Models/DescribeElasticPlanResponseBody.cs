// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeElasticPlanResponseBody : TeaModel {
        /// <summary>
        /// Details of the scaling plans.
        /// </summary>
        [NameInMap("ElasticPlanList")]
        [Validation(Required=false)]
        public List<DescribeElasticPlanResponseBodyElasticPlanList> ElasticPlanList { get; set; }
        public class DescribeElasticPlanResponseBodyElasticPlanList : TeaModel {
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
            /// Specifies whether the scaling plan takes effect. Default value: true. Valid values:
            /// 
            /// *   **true**: The scaling plan takes effect.
            /// *   **false**: The scaling plan does not take effect.
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// The end date of the scaling plan. This parameter is returned only if the end date of the scaling plan is set. The date is in the yyyy-MM-dd format.
            /// </summary>
            [NameInMap("EndDay")]
            [Validation(Required=false)]
            public string EndDay { get; set; }

            /// <summary>
            /// The restoration time of the scaling plan. The interval between the scale-up time and the restoration time cannot be more than 24 hours. The time is in the HH:mm:ss format.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The name of the scaling plan.
            /// </summary>
            [NameInMap("PlanName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }

            /// <summary>
            /// The name of the resource group.
            /// </summary>
            [NameInMap("ResourcePoolName")]
            [Validation(Required=false)]
            public string ResourcePoolName { get; set; }

            /// <summary>
            /// The start date of the scaling plan. This parameter is returned only if the start date of the scaling plan is set. The date is in the yyyy-MM-dd format.
            /// </summary>
            [NameInMap("StartDay")]
            [Validation(Required=false)]
            public string StartDay { get; set; }

            /// <summary>
            /// The scale-up time of the scaling plan. The time is in the HH:mm:ss format.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The days of the week when you want to execute the scaling plan. Valid values: 0 to 6, which indicate Sunday to Saturday. Multiple values are separated by commas (,).
            /// </summary>
            [NameInMap("WeeklyRepeat")]
            [Validation(Required=false)]
            public string WeeklyRepeat { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
