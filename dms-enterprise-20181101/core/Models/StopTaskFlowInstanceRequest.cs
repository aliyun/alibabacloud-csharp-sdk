// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class StopTaskFlowInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the task flow. You can call the [ListTaskFlow](~~424565~~) or [ListLhTaskFlowAndScenario](~~426672~~) operation to query the task flow ID.
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// The ID of the execution record of the task flow. You can call the [ListTaskFlowInstance](~~424689~~) operation to query the execution record ID.
        /// </summary>
        [NameInMap("DagInstanceId")]
        [Validation(Required=false)]
        public long? DagInstanceId { get; set; }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
