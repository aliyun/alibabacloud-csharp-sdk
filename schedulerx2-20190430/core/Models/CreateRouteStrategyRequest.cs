// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class CreateRouteStrategyRequest : TeaModel {
        /// <summary>
        /// The ID of the application group. You can obtain the ID on the **Application Management** page in the SchedulerX console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The job ID. You can obtain the ID on the **Task Management** page in the SchedulerX console.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// The name of the routing policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The namespace ID. You can obtain the namespace ID on the **Namespace** page in the SchedulerX console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to enable the routing policy. Valid values:
        /// 
        /// *   **0**: disables the routing policy.
        /// *   **1**: enables the routing policy.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The details of the routing policy. The value is a JSON string. For more information about this parameter, see **the additional information about request parameters** below this table.
        /// </summary>
        [NameInMap("StrategyContent")]
        [Validation(Required=false)]
        public string StrategyContent { get; set; }

        /// <summary>
        /// The type of the routing policy. Valid value:
        /// 
        /// *   **3**: routes by proportion.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
