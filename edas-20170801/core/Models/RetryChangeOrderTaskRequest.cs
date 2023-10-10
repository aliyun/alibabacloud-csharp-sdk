// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class RetryChangeOrderTaskRequest : TeaModel {
        /// <summary>
        /// The retry status.
        /// </summary>
        [NameInMap("RetryStatus")]
        [Validation(Required=false)]
        public bool? RetryStatus { get; set; }

        /// <summary>
        /// The ID of the process.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
