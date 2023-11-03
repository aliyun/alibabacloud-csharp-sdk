// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateEnvPodMonitorResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned result, which indicates whether the operation was successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateEnvPodMonitorResponseBodyData Data { get; set; }
        public class CreateEnvPodMonitorResponseBodyData : TeaModel {
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

            /// <summary>
            /// The namespace.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The name of the created PodMonitor.
            /// </summary>
            [NameInMap("PodMonitorName")]
            [Validation(Required=false)]
            public string PodMonitorName { get; set; }

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
