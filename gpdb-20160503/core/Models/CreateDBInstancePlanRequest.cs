// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateDBInstancePlanRequest : TeaModel {
        /// <summary>
        /// The ID of instance.
        /// 
        /// >  You can call the [DescribeDBInstances](~~86911~~) operation to query the IDs of all AnalyticDB for PostgreSQL instances in a specific region.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The execution information of the plan. Specify the parameter in the JSON format. The parameter value varies based on the values of the **PlanType** and **PlanScheduleType** parameters. The following section describes the PlanConfig parameter.
        /// </summary>
        [NameInMap("PlanConfig")]
        [Validation(Required=false)]
        public string PlanConfig { get; set; }

        /// <summary>
        /// The description of the plan.
        /// </summary>
        [NameInMap("PlanDesc")]
        [Validation(Required=false)]
        public string PlanDesc { get; set; }

        /// <summary>
        /// The end time of the plan. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm*Z format. The time must be in UTC. The end time must be later than the start time.
        /// 
        /// > *   This parameter is required only if the **PlanScheduleType** parameter is set to **Regular**.
        /// > *   If you do not specify this parameter, the plan does not end.
        /// </summary>
        [NameInMap("PlanEndDate")]
        [Validation(Required=false)]
        public string PlanEndDate { get; set; }

        /// <summary>
        /// The name of the plan.
        /// </summary>
        [NameInMap("PlanName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// The execution mode of the plan. Valid values:
        /// 
        /// *   **Postpone**: The plan is executed later.
        /// *   **Regular**: The plan is executed periodically.
        /// </summary>
        [NameInMap("PlanScheduleType")]
        [Validation(Required=false)]
        public string PlanScheduleType { get; set; }

        /// <summary>
        /// The start time of the plan. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm*Z format. The time must be in UTC.
        /// 
        /// >  *   This parameter is required only if the **PlanScheduleType** parameter is set to **Regular**.
        /// >  *   If you do not specify this parameter, the plan is executed immediately.
        /// </summary>
        [NameInMap("PlanStartDate")]
        [Validation(Required=false)]
        public string PlanStartDate { get; set; }

        /// <summary>
        /// The type of the plan. Valid values:
        /// 
        /// *   **PauseResume**: pauses and resumes an instance.
        /// *   **Resize**: changes the number of compute nodes.
        /// *   **ModifySpec**: changes compute node specifications.
        /// 
        /// > *   You can specify the value to Resize only for instances in Serverless mode.
        /// > *   You can specify the value to ModifySpec only for instances in elastic storage mode.
        /// </summary>
        [NameInMap("PlanType")]
        [Validation(Required=false)]
        public string PlanType { get; set; }

    }

}
