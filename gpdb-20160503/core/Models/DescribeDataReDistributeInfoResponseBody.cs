// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDataReDistributeInfoResponseBody : TeaModel {
        /// <summary>
        /// The data redistribution information.
        /// </summary>
        [NameInMap("DataReDistributeInfo")]
        [Validation(Required=false)]
        public DescribeDataReDistributeInfoResponseBodyDataReDistributeInfo DataReDistributeInfo { get; set; }
        public class DescribeDataReDistributeInfoResponseBodyDataReDistributeInfo : TeaModel {
            /// <summary>
            /// The execution information. If an error occurs, the error message is returned.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The progress of data redistribution. Unit: %.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public long? Progress { get; set; }

            /// <summary>
            /// The estimated remaining time for data redistribution.
            /// </summary>
            [NameInMap("RemainTime")]
            [Validation(Required=false)]
            public string RemainTime { get; set; }

            /// <summary>
            /// This parameter is not supported.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The status of data redistribution.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The execution type. The value **immediate** is returned, indicating immediate execution.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
