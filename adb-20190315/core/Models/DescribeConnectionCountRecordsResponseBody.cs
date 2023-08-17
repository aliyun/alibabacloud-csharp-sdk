// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeConnectionCountRecordsResponseBody : TeaModel {
        /// <summary>
        /// Details of the client IP addresses.
        /// </summary>
        [NameInMap("AccessIpRecords")]
        [Validation(Required=false)]
        public List<DescribeConnectionCountRecordsResponseBodyAccessIpRecords> AccessIpRecords { get; set; }
        public class DescribeConnectionCountRecordsResponseBodyAccessIpRecords : TeaModel {
            /// <summary>
            /// The IP address of the client used to connect to the cluster.
            /// </summary>
            [NameInMap("AccessIp")]
            [Validation(Required=false)]
            public string AccessIp { get; set; }

            /// <summary>
            /// The number of connections.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

        }

        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details of the users.
        /// </summary>
        [NameInMap("UserRecords")]
        [Validation(Required=false)]
        public List<DescribeConnectionCountRecordsResponseBodyUserRecords> UserRecords { get; set; }
        public class DescribeConnectionCountRecordsResponseBodyUserRecords : TeaModel {
            /// <summary>
            /// The number of connections.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The name of the user used to connect to the cluster.
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

    }

}
