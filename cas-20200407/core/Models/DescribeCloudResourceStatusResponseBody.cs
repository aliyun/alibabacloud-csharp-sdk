// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DescribeCloudResourceStatusResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeCloudResourceStatusResponseBodyData> Data { get; set; }
        public class DescribeCloudResourceStatusResponseBodyData : TeaModel {
            /// <summary>
            /// The cloud service provider.
            /// </summary>
            [NameInMap("CloudName")]
            [Validation(Required=false)]
            public string CloudName { get; set; }

            /// <summary>
            /// The cloud service.
            /// </summary>
            [NameInMap("CloudProduct")]
            [Validation(Required=false)]
            public string CloudProduct { get; set; }

            /// <summary>
            /// The total number of cloud resources on which certificates are deployed.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
