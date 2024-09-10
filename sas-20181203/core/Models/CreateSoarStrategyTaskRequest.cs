// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateSoarStrategyTaskRequest : TeaModel {
        /// <summary>
        /// The ID of the policy.
        /// 
        /// >  You can call the [DescribeSoarSubscribedStrategy](~~DescribeSoarSubscribedStrategy~~) operation to obtain the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

        /// <summary>
        /// The name of the policy. Set the value to Automated Batch Vulnerability Fixing Policy for Multiple Servers.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        /// <summary>
        /// The name of.the policy task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StrategyTaskName")]
        [Validation(Required=false)]
        public string StrategyTaskName { get; set; }

        /// <summary>
        /// The parameters of the policy task. The value is a JSON array.
        /// 
        /// Vulnerability-related parameters:
        /// 
        /// *   name: vluList
        /// *   associationProperty: sasAllVul
        /// *   value: basic vulnerability information
        /// 
        /// Snapshot-related parameters:
        /// 
        /// *   name: snapshotConfig
        /// *   associationProperty: snapshotConfig
        /// *   value: retention period
        /// 
        /// Notification-related parameters:
        /// 
        /// *   name: notifyConfig
        /// *   associationProperty: notifyConfig
        /// *   value: email or DingTalk configuration information
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StrategyTaskParams")]
        [Validation(Required=false)]
        public string StrategyTaskParams { get; set; }

        /// <summary>
        /// The timestamp when the task is scheduled to start. Unit: milliseconds.
        /// </summary>
        [NameInMap("StrategyTaskPlanExeTime")]
        [Validation(Required=false)]
        public long? StrategyTaskPlanExeTime { get; set; }

    }

}
