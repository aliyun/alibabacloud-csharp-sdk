// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class HandleSecurityEventsResponseBody : TeaModel {
        /// <summary>
        /// The handling result of the alert events.
        /// </summary>
        [NameInMap("HandleSecurityEventsResponse")]
        [Validation(Required=false)]
        public HandleSecurityEventsResponseBodyHandleSecurityEventsResponse HandleSecurityEventsResponse { get; set; }
        public class HandleSecurityEventsResponseBodyHandleSecurityEventsResponse : TeaModel {
            /// <summary>
            /// The ID of the task to handle the alert events.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
