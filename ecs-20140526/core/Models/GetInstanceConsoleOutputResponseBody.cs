// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class GetInstanceConsoleOutputResponseBody : TeaModel {
        /// <summary>
        /// The Base64-encoded command output of the instance.
        /// </summary>
        [NameInMap("ConsoleOutput")]
        [Validation(Required=false)]
        public string ConsoleOutput { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The time when the last log entry was generated in the Linux kernel. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mmZ format. The time is displayed in UTC+8.
        /// </summary>
        [NameInMap("LastUpdateTime")]
        [Validation(Required=false)]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
