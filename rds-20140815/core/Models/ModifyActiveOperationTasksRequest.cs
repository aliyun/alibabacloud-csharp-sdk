// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyActiveOperationTasksRequest : TeaModel {
        /// <summary>
        /// The ID of the O\&M task. Separate multiple IDs with commas (,).
        /// 
        /// > You can call the [DescribeActiveOperationTask](~~611455~~) operation to query the IDs of O\&M tasks.
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// Specifies whether to immediately start scheduling. The value 0 indicates that scheduling is not immediately started. This is the default value. The value 1 indicates that scheduling is immediately started. If you set this parameter to 0, SwitchTime takes effect. If you set this parameter to 1, SwitchTimer does not take effect. In this case, the start time of the task is set to the current time, and the system determines the switching time based on the start time.
        /// 
        /// > Immediate scheduling indicates that the task enters the preparation state instead of the immediate switchover. After the preparation is complete, the switchover is performed. You can call the [DescribeActiveOperationTasks](~~611455~~) operation to obtain the period of time for preparation. The period of time for preparation is returned in PrepareInterva.
        /// </summary>
        [NameInMap("ImmediateStart")]
        [Validation(Required=false)]
        public int? ImmediateStart { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The scheduled switching time that you want to specify. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// > The time that you specify cannot be later than the deadline for performing the O\&M task. You can call [DescribeActiveOperationTasks](~~611455~~) to query the deadlines of O\&M tasks. The deadline of a task is returned in Deadline.
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

    }

}
