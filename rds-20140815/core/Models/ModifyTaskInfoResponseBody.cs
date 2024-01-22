// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The ID of the failed task. This parameter is returned when a task fails.
        /// </summary>
        [NameInMap("ErrorTaskId")]
        [Validation(Required=false)]
        public string ErrorTaskId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of completed tasks.
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public string SuccessCount { get; set; }

    }

}
