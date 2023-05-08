// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecurityEventOperationStatusRequest : TeaModel {
        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The code that indicates the handling result of the alert event.
        /// </summary>
        [NameInMap("SecurityEventIds")]
        [Validation(Required=false)]
        public List<string> SecurityEventIds { get; set; }

        /// <summary>
        /// An array consisting of the status of the alert events handled by the task.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The information about the task that handles the alert events.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
