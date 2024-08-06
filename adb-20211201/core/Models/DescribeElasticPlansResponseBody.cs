// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeElasticPlansResponseBody : TeaModel {
        /// <summary>
        /// The queried scaling plans.
        /// </summary>
        [NameInMap("ElasticPlans")]
        [Validation(Required=false)]
        public List<DescribeElasticPlansResponseBodyElasticPlans> ElasticPlans { get; set; }
        public class DescribeElasticPlansResponseBodyElasticPlans : TeaModel {
            /// <summary>
            /// Indicates whether **Proportional Default Scaling for EIUs** is enabled. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("AutoScale")]
            [Validation(Required=false)]
            public bool? AutoScale { get; set; }

            /// <summary>
            /// The name of the scaling plan.
            /// </summary>
            [NameInMap("ElasticPlanName")]
            [Validation(Required=false)]
            public string ElasticPlanName { get; set; }

            /// <summary>
            /// Indicates whether the scaling plan was immediately enabled after the plan is created. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// The time when the next scheduling is performed.
            /// 
            /// > The time is in the yyyy-MM-ddTHH:mm:ssZ format.
            /// </summary>
            [NameInMap("NextScheduleTime")]
            [Validation(Required=false)]
            public string NextScheduleTime { get; set; }

            /// <summary>
            /// The name of the resource group.
            /// 
            /// > You can call the [DescribeDBResourceGroup](https://help.aliyun.com/document_detail/459446.html) operation to query the name of a resource group within a cluster.
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// The amount of elastic resources after scaling.
            /// </summary>
            [NameInMap("TargetSize")]
            [Validation(Required=false)]
            public string TargetSize { get; set; }

            /// <summary>
            /// The type of the scaling plan. Valid values:
            /// 
            /// *   EXECUTOR: interactive resource group.
            /// *   WORKER: EIU.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
