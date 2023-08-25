// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeElasticPlanAttributeResponseBody : TeaModel {
        /// <summary>
        /// Details of the scaling plan.
        /// </summary>
        [NameInMap("ElasticPlan")]
        [Validation(Required=false)]
        public DescribeElasticPlanAttributeResponseBodyElasticPlan ElasticPlan { get; set; }
        public class DescribeElasticPlanAttributeResponseBodyElasticPlan : TeaModel {
            /// <summary>
            /// Indicates whether **Proportional Default Scaling for EIUs** is enabled.
            /// 
            /// Valid values:
            /// 
            /// true: Proportional Default Scaling for EIUs is enabled. If you set this parameter to true, the amount of storage resources scales along with the computing resources.
            /// 
            /// false: Proportional Default Scaling for EIUs is not enabled.
            /// 
            /// >  You can enable Proportional Default Scaling for EIUs for only a single scaling plan of a cluster.
            /// </summary>
            [NameInMap("AutoScale")]
            [Validation(Required=false)]
            public bool? AutoScale { get; set; }

            /// <summary>
            /// A CORN expression that indicates the scaling cycle and time for the scaling plan.
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// The name of the scaling plan.
            /// </summary>
            [NameInMap("ElasticPlanName")]
            [Validation(Required=false)]
            public string ElasticPlanName { get; set; }

            /// <summary>
            /// Indicates whether the scaling plan was enabled.
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// The end time of the scaling plan.
            /// 
            /// >  The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The name of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// The start time of the scaling plan.
            /// 
            /// >  The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The amount of elastic resources after scaling.
            /// </summary>
            [NameInMap("TargetSize")]
            [Validation(Required=false)]
            public string TargetSize { get; set; }

            /// <summary>
            /// The type of the scaling plan.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
