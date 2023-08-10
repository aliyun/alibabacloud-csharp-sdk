// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeSlowQueryStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The return result.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeSlowQueryStatusResponseBodyResult Result { get; set; }
        public class DescribeSlowQueryStatusResponseBodyResult : TeaModel {
            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("appGroupId")]
            [Validation(Required=false)]
            public string AppGroupId { get; set; }

            /// <summary>
            /// The network type of the slow query optimization service. Valid values:
            /// 
            /// *   outer: the Internet
            /// *   internal: the internal network
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The status of the slow query optimization service. Valid values:
            /// 
            /// *   enabled
            /// *   disabled
            /// *   n/a
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
