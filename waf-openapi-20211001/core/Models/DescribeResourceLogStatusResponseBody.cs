// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeResourceLogStatusResponseBody : TeaModel {
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
        public List<DescribeResourceLogStatusResponseBodyResult> Result { get; set; }
        public class DescribeResourceLogStatusResponseBodyResult : TeaModel {
            /// <summary>
            /// The protected object.
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// Indicates whether the log collection feature is enabled for the protected object. Valid values:
            /// 
            /// *   **true:** The log collection feature is enabled.
            /// *   **false:** The log collection feature is disabled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

    }

}
