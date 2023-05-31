// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeEventOnStageResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The platforms that are supported by the feature of container threat detection.
        /// </summary>
        [NameInMap("SecurityEventStageResponse")]
        [Validation(Required=false)]
        public DescribeEventOnStageResponseBodySecurityEventStageResponse SecurityEventStageResponse { get; set; }
        public class DescribeEventOnStageResponseBodySecurityEventStageResponse : TeaModel {
            /// <summary>
            /// The platform that is supported by the feature of container threat detection. Valid values:
            /// 
            /// *   **container**
            /// *   **linux**
            /// *   **windows**
            /// </summary>
            [NameInMap("SecurityEventOnStag")]
            [Validation(Required=false)]
            public Dictionary<string, object> SecurityEventOnStag { get; set; }

        }

    }

}
