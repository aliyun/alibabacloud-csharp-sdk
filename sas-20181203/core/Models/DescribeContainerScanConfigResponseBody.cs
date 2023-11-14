// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerScanConfigResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeContainerScanConfigResponseBodyData Data { get; set; }
        public class DescribeContainerScanConfigResponseBodyData : TeaModel {
            /// <summary>
            /// The total number of container applications in the cluster.
            /// </summary>
            [NameInMap("AllCount")]
            [Validation(Required=false)]
            public int? AllCount { get; set; }

            /// <summary>
            /// The names of the container applications.
            /// </summary>
            [NameInMap("AppNames")]
            [Validation(Required=false)]
            public string AppNames { get; set; }

            /// <summary>
            /// The number of selected container applications.
            /// </summary>
            [NameInMap("ChooseCount")]
            [Validation(Required=false)]
            public int? ChooseCount { get; set; }

            /// <summary>
            /// The cluster ID.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The name of the cluster.
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
