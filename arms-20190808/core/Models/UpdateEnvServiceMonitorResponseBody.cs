// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateEnvServiceMonitorResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateEnvServiceMonitorResponseBodyData Data { get; set; }
        public class UpdateEnvServiceMonitorResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether targets are matched.
            /// </summary>
            [NameInMap("MatchedMsg")]
            [Validation(Required=false)]
            public string MatchedMsg { get; set; }

            /// <summary>
            /// The number of matched targets.
            /// </summary>
            [NameInMap("MatchedTargetCount")]
            [Validation(Required=false)]
            public string MatchedTargetCount { get; set; }

        }

        /// <summary>
        /// The returned message.
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

    }

}
