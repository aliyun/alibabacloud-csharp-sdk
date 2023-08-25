// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeElasticPlanJobsResponseBody : TeaModel {
        /// <summary>
        /// Details of the scaling plan jobs.
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public List<DescribeElasticPlanJobsResponseBodyJobs> Jobs { get; set; }
        public class DescribeElasticPlanJobsResponseBodyJobs : TeaModel {
            /// <summary>
            /// The amount of elastic resources.
            /// 
            /// > *   If the Type parameter is set to EXECUTOR, ElasticAcu indicates the amount of elastic resources in the current resource group.
            /// > *   If the Type parameter is set to WORKER, ElasticAcu indicates the total amount of elastic storage resources in the current cluster.
            /// </summary>
            [NameInMap("ElasticAcu")]
            [Validation(Required=false)]
            public string ElasticAcu { get; set; }

            /// <summary>
            /// The name of the scaling plan.
            /// </summary>
            [NameInMap("ElasticPlanName")]
            [Validation(Required=false)]
            public string ElasticPlanName { get; set; }

            /// <summary>
            /// The time when the scaling plan job was complete.
            /// 
            /// >  The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The number of instances.
            /// 
            /// > *   If the Type parameter is set to EXECUTOR, InstanceSize indicates the number of compute nodes.
            /// > *   If the Type parameter is set to EXECUTOR, InstanceSize indicates the number of replica sets at the storage layer in the cluster.
            /// </summary>
            [NameInMap("InstanceSize")]
            [Validation(Required=false)]
            public int? InstanceSize { get; set; }

            /// <summary>
            /// The amount of reserved resources.
            /// 
            /// > *   If the Type parameter is set to EXECUTOR, ReserveAcu indicates the amount of reserved resources in the current resource group.
            /// > *   If the Type parameter is set to WORKER, ReserveAcu indicates the total amount of reserved storage resources in the current cluster.
            /// </summary>
            [NameInMap("ReserveAcu")]
            [Validation(Required=false)]
            public string ReserveAcu { get; set; }

            /// <summary>
            /// The name of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// The time when the scaling plan job was enabled.
            /// 
            /// >  The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The state of the scaling plan job.
            /// 
            /// Valid values:
            /// 
            /// *   RUNNING: The job is running.
            /// *   SUCCESSFUL: The job is successfully run.
            /// *   FAILED: The job fails.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The amount of elastic resources after scaling.
            /// </summary>
            [NameInMap("TargetSize")]
            [Validation(Required=false)]
            public string TargetSize { get; set; }

            /// <summary>
            /// The total amount of resources.
            /// 
            /// > *   If the Type parameter is set to EXECUTOR, TotalAcu indicates the total amount of computing resources in the current resource group.
            /// > *   If the Type parameter is set to WORKER, TotalAcu indicates the total amount of storage resources in the cluster.
            /// </summary>
            [NameInMap("TotalAcu")]
            [Validation(Required=false)]
            public string TotalAcu { get; set; }

            /// <summary>
            /// The type of the scaling plan job.
            /// 
            /// Valid values:
            /// 
            /// *   EXECUTOR: interactive resource groups, which fall into the computing resource category.
            /// *   WORKER: EIUs.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of scaling plan jobs returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of scaling plan jobs.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
