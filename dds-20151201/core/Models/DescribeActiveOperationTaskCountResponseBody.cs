// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeActiveOperationTaskCountResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether any O\\&M tasks need pop-up windows to notify users actions. Valid values:
        /// 
        /// *   **0**: No O\\&M tasks need pop-up windows to notify users actions.
        /// *   **1**: Some O\\&M tasks need pop-up windows to notify users actions.
        /// </summary>
        [NameInMap("NeedPop")]
        [Validation(Required=false)]
        public int? NeedPop { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of pending O\\&M tasks.
        /// </summary>
        [NameInMap("TaskCount")]
        [Validation(Required=false)]
        public int? TaskCount { get; set; }

    }

}
