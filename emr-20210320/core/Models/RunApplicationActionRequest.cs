// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class RunApplicationActionRequest : TeaModel {
        /// <summary>
        /// The name of the action. Valid values:
        /// 
        /// *   start
        /// *   stop
        /// *   config
        /// *   restart
        /// *   refresh_queues
        /// *   refresh_labels
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ActionName")]
        [Validation(Required=false)]
        public string ActionName { get; set; }

        /// <summary>
        /// The number of applications in each batch.
        /// </summary>
        [NameInMap("BatchSize")]
        [Validation(Required=false)]
        public int? BatchSize { get; set; }

        /// <summary>
        /// The cluster ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The operation object.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ComponentInstanceSelector")]
        [Validation(Required=false)]
        public ComponentInstanceSelector ComponentInstanceSelector { get; set; }

        /// <summary>
        /// The description of the execution.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The execution policy. Valid values:
        /// 
        /// *   FAILED_BLOCK: The system stops the execution if the execution fails.
        /// *   FAILED_CONTINUE: The system continues the execution if the execution fails.
        /// </summary>
        [NameInMap("ExecuteStrategy")]
        [Validation(Required=false)]
        public string ExecuteStrategy { get; set; }

        /// <summary>
        /// The interval for rolling execution. Unit: seconds.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to enable rolling execution.
        /// </summary>
        [NameInMap("RollingExecute")]
        [Validation(Required=false)]
        public bool? RollingExecute { get; set; }

    }

}
