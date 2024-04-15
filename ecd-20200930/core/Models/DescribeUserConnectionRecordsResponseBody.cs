// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeUserConnectionRecordsResponseBody : TeaModel {
        /// <summary>
        /// Details about connection records of the end user.
        /// </summary>
        [NameInMap("ConnectionRecords")]
        [Validation(Required=false)]
        public List<DescribeUserConnectionRecordsResponseBodyConnectionRecords> ConnectionRecords { get; set; }
        public class DescribeUserConnectionRecordsResponseBodyConnectionRecords : TeaModel {
            /// <summary>
            /// The duration for which the end user is connected to the cloud computer. Unit: seconds.
            /// </summary>
            [NameInMap("ConnectDuration")]
            [Validation(Required=false)]
            public string ConnectDuration { get; set; }

            /// <summary>
            /// The time when the end user disconnected from the cloud computer.
            /// </summary>
            [NameInMap("ConnectEndTime")]
            [Validation(Required=false)]
            public string ConnectEndTime { get; set; }

            /// <summary>
            /// The time when the end user connected to the cloud computer.
            /// </summary>
            [NameInMap("ConnectStartTime")]
            [Validation(Required=false)]
            public string ConnectStartTime { get; set; }

            /// <summary>
            /// The ID of the connection record.
            /// </summary>
            [NameInMap("ConnectionRecordId")]
            [Validation(Required=false)]
            public string ConnectionRecordId { get; set; }

            /// <summary>
            /// The ID of the cloud computer to which the end user connected.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// The name of the cloud computer to which the end user connected.
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

        }

        /// <summary>
        /// The token that is used to start the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
