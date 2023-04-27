// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowInstanceRequest : TeaModel {
        /// <summary>
        /// The operation that you want to perform. Set the value to **ListTaskFlowInstance**.
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// The ID of the task flow. You can call the [ListTaskFlow](~~424565~~) or [ListLhTaskFlowAndScenario](~~426672~~) operation to obtain the ID of the task flow.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("StartTimeBegin")]
        [Validation(Required=false)]
        public string StartTimeBegin { get; set; }

        /// <summary>
        /// The ID of the task flow.
        /// </summary>
        [NameInMap("StartTimeEnd")]
        [Validation(Required=false)]
        public string StartTimeEnd { get; set; }

        /// <summary>
        /// The ID of the execution record.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// The business time of the task flow. The time is displayed in the yyyy-MM-DD HH:mm:ss format.
        /// </summary>
        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public int? TriggerType { get; set; }

    }

}
