// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateGroupMonitoringAgentProcessResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// 
        /// > The status code 200 indicates that the call is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The group process information.
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public CreateGroupMonitoringAgentProcessResponseBodyResource Resource { get; set; }
        public class CreateGroupMonitoringAgentProcessResponseBodyResource : TeaModel {
            /// <summary>
            /// The ID of the group process.
            /// </summary>
            [NameInMap("GroupProcessId")]
            [Validation(Required=false)]
            public string GroupProcessId { get; set; }

        }

        /// <summary>
        /// Indicates whether the call is successful. Valid values:
        /// 
        /// *   true: The call is successful.
        /// *   false: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
