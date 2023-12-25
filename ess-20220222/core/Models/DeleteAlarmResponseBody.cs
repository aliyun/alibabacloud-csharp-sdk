// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DeleteAlarmResponseBody : TeaModel {
        /// <summary>
        /// The ID of the event-triggered task.
        /// </summary>
        [NameInMap("AlarmTaskId")]
        [Validation(Required=false)]
        public string AlarmTaskId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
