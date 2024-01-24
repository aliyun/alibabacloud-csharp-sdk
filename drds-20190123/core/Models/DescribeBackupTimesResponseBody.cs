// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeBackupTimesResponseBody : TeaModel {
        /// <summary>
        /// Indicates the ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates the information about the time range within which the data of the instance can be restored to a point in time.
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public DescribeBackupTimesResponseBodyRestoreTime RestoreTime { get; set; }
        public class DescribeBackupTimesResponseBodyRestoreTime : TeaModel {
            /// <summary>
            /// Indicates the end time. The time is in the UNIX timestamp format. The time is in UTC. Unit: ms.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// Indicates the start time. The time is in the UNIX timestamp format. The time must be in UTC. Unit: ms.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
