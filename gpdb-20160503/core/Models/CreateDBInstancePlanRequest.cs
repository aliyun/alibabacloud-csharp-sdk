// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateDBInstancePlanRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// 
        /// > You can call the [DescribeDBInstances](https://help.aliyun.com/document_detail/86911.html) operation to query the IDs of all AnalyticDB for PostgreSQL instances within a region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The execution information of the plan. Specify the parameter in the JSON format. The parameter value varies based on the values of **PlanType** and **PlanScheduleType**. The following section describes the PlanConfig parameter.
        /// 
        /// This parameter is required.
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
        /// The end time of the plan. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC. The end time must be later than the start time.
        /// 
        /// > - This parameter must be specified only when **PlanScheduleType** is set to **Regular.
        ///  > - If you do not specify this parameter, the plan stops until the plan is deleted.
        /// </summary>
        [NameInMap("PlanEndDate")]
        [Validation(Required=false)]
        public string PlanEndDate { get; set; }

        /// <summary>
        /// The name of the plan.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PlanName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// The execution mode of the plan. Valid values:
        /// 
        /// *   **Postpone**: The plan is executed later.
        /// *   **Regular**: The plan is executed periodically.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PlanScheduleType")]
        [Validation(Required=false)]
        public string PlanScheduleType { get; set; }

        /// <summary>
        /// The start time of the plan. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// 
        /// > -  This parameter must be specified only when **PlanScheduleType** is set to **Regular**.
        /// > -  If you do not specify this parameter, the current time is used.
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
        /// > - You can specify the value to ModifySpec only for instances in elastic storage mode.
        /// >- You can specify the value to ModifySpec only for instances in elastic storage mode.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PlanType")]
        [Validation(Required=false)]
        public string PlanType { get; set; }

    }

}
