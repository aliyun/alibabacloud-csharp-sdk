// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the task flow. You can call the [ListTaskFlow](~~424565~~) or [ListLhTaskFlowAndScenario](~~426672~~) operation to obtain the ID of the task flow.
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The beginning of the time range to query the execution records of the task flow. Specify the time in the yyyy-MM-DD format.
        /// </summary>
        [NameInMap("StartTimeBegin")]
        [Validation(Required=false)]
        public string StartTimeBegin { get; set; }

        /// <summary>
        /// The end of the time range to query the execution records of the task flow. Specify the time in the yyyy-MM-DD format.
        /// </summary>
        [NameInMap("StartTimeEnd")]
        [Validation(Required=false)]
        public string StartTimeEnd { get; set; }

        /// <summary>
        /// The running status of the task node. Valid values:
        /// 
        /// - **0**: Waiting for scheduling
        /// 
        /// - **1**: Running
        /// 
        /// - **2**: Suspend
        /// 
        /// - **3**: Failed to run
        /// 
        /// - **4**: Run successfully
        /// 
        /// - **5**: Completed
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) or [ListUserTenants](~~198074~~) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// The mode in which the task flow is triggered. Valid values:
        /// 
        /// *   **0**: The task flow is automatically triggered based on periodic scheduling.
        /// *   **1**: The task flow is manually triggered.
        /// </summary>
        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public int? TriggerType { get; set; }

        /// <summary>
        /// Adjust filter conditions:
        /// 
        /// - true: StartTimeBegin and StartTimeEnd are the time range for filtering services.
        /// 
        /// - false: StartTimeBegin and StartTimeEnd are the time range for the task to run.
        /// </summary>
        [NameInMap("UseBizDate")]
        [Validation(Required=false)]
        public bool? UseBizDate { get; set; }

    }

}
