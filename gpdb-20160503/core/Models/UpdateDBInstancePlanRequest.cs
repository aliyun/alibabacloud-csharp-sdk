// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class UpdateDBInstancePlanRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// >  You can call the [DescribeDBInstances](https://help.aliyun.com/document_detail/86911.html) operation to query the details of all AnalyticDB for PostgreSQL instances in a specific region, including instance IDs.
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
        /// > 
        /// 
        /// *   This parameter must be specified only for **periodically executed** plans.
        /// 
        /// *   If you do not specify this parameter, the plan stops until the plan is deleted.
        /// </summary>
        [NameInMap("PlanEndDate")]
        [Validation(Required=false)]
        public string PlanEndDate { get; set; }

        /// <summary>
        /// The ID of the plan.
        /// 
        /// >  You can call the [DescribeDBInstancePlans](https://help.aliyun.com/document_detail/449398.html) operation to query the details of plans, including plan IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// The name of the plan.
        /// </summary>
        [NameInMap("PlanName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// The start time of the plan. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// 
        /// > 
        /// 
        /// *   This parameter must be specified only for **periodically executed** plans.
        /// 
        /// *   If you do not specify this parameter, the current time is used.
        /// </summary>
        [NameInMap("PlanStartDate")]
        [Validation(Required=false)]
        public string PlanStartDate { get; set; }

    }

}
