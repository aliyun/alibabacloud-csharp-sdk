// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class CreateAndAnalyzeNetworkPathResponseBody : TeaModel {
        /// <summary>
        /// The ID of the task for analyzing network reachability that you initiated.
        /// </summary>
        [NameInMap("NetworkReachableAnalysisId")]
        [Validation(Required=false)]
        public string NetworkReachableAnalysisId { get; set; }

        /// <summary>
        /// The protocol type.
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the source resource.
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// The source IP address.
        /// </summary>
        [NameInMap("SourceIpAddress")]
        [Validation(Required=false)]
        public string SourceIpAddress { get; set; }

        /// <summary>
        /// The source port.
        /// </summary>
        [NameInMap("SourcePort")]
        [Validation(Required=false)]
        public string SourcePort { get; set; }

        /// <summary>
        /// The type of the source resource.
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// The ID of the destination resource.
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// The destination IP address.
        /// </summary>
        [NameInMap("TargetIpAddress")]
        [Validation(Required=false)]
        public string TargetIpAddress { get; set; }

        /// <summary>
        /// The destination port.
        /// </summary>
        [NameInMap("TargetPort")]
        [Validation(Required=false)]
        public string TargetPort { get; set; }

        /// <summary>
        /// The type of the destination resource.
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
