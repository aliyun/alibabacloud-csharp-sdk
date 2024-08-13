// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class ListOpenedAccessLogInstancesResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The configuration of log analysis for the Anti-DDoS Origin instance.
        /// </summary>
        [NameInMap("SlsConfigStatus")]
        [Validation(Required=false)]
        public List<ListOpenedAccessLogInstancesResponseBodySlsConfigStatus> SlsConfigStatus { get; set; }
        public class ListOpenedAccessLogInstancesResponseBodySlsConfigStatus : TeaModel {
            /// <summary>
            /// Indicates whether log analysis was enabled for the Anti-DDoS Origin instance. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// The ID of the Anti-DDoS Origin instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// The number of the Anti-DDoS Origin instances for which log analysis was enabled.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
