// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeConnectionCountRecordsResponseBody : TeaModel {
        /// <summary>
        /// The queried client IP addresses.
        /// </summary>
        [NameInMap("AccessIpRecords")]
        [Validation(Required=false)]
        public List<DescribeConnectionCountRecordsResponseBodyAccessIpRecords> AccessIpRecords { get; set; }
        public class DescribeConnectionCountRecordsResponseBodyAccessIpRecords : TeaModel {
            /// <summary>
            /// The IP address of the client.
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
        /// The cluster ID.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The queried database accounts.
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
            /// The username of the database account.
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

    }

}
