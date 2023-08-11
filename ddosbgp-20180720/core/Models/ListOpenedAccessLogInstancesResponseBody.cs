// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class ListOpenedAccessLogInstancesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the Anti-DDoS Origin instance.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether log analysis was enabled for the Anti-DDoS Origin instance. Valid values:
        /// 
        /// *   **true**: Log analysis was enabled.
        /// *   **false**: Log analysis was disabled.
        /// </summary>
        [NameInMap("SlsConfigStatus")]
        [Validation(Required=false)]
        public List<ListOpenedAccessLogInstancesResponseBodySlsConfigStatus> SlsConfigStatus { get; set; }
        public class ListOpenedAccessLogInstancesResponseBodySlsConfigStatus : TeaModel {
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// All Alibaba Cloud API operations must include common request parameters. For more information about common request parameters, see [Common parameters](~~118841~~).
            /// 
            /// For more information about sample requests, see the **"Examples"** section of this topic.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// The configuration of log analysis for the Anti-DDoS Origin instance.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
