// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeAckOperatorResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAckOperatorResponseBodyResult Result { get; set; }
        public class DescribeAckOperatorResponseBodyResult : TeaModel {
            /// <summary>
            /// The installation status of ES-operator. Valid values:
            /// 
            /// *   deployed: ES-operator is installed.
            /// *   not-deploy: ES-operator is not installed.
            /// *   failed: ES-operator fails to be installed.
            /// *   unknown: The installation status of ES-operator is unknown.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The version of ES-operator.
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
