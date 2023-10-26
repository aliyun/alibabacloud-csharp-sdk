// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateEnvPodMonitorResponseBody : TeaModel {
        /// <summary>
        /// The status code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned information.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateEnvPodMonitorResponseBodyData Data { get; set; }
        public class CreateEnvPodMonitorResponseBodyData : TeaModel {
            /// <summary>
            /// target matching prompt information.
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
            /// Successfully created podMonitor name.
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
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
