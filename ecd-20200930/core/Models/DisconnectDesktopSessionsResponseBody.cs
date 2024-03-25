// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DisconnectDesktopSessionsResponseBody : TeaModel {
        /// <summary>
        /// The list of invalid sessions.
        /// </summary>
        [NameInMap("InvalidSessions")]
        [Validation(Required=false)]
        public List<DisconnectDesktopSessionsResponseBodyInvalidSessions> InvalidSessions { get; set; }
        public class DisconnectDesktopSessionsResponseBodyInvalidSessions : TeaModel {
            /// <summary>
            /// The cloud desktop ID.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// The end user ID.
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
