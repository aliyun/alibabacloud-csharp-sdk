// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetShipperStatusResponseBody : TeaModel {
        /// <summary>
        /// The number of log shipping jobs returned on the current page.
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// The statistics about log shipping jobs.
        /// </summary>
        [NameInMap("statistics")]
        [Validation(Required=false)]
        public GetShipperStatusResponseBodyStatistics Statistics { get; set; }
        public class GetShipperStatusResponseBodyStatistics : TeaModel {
            /// <summary>
            /// The number of log shipping jobs that are in the fail state.
            /// </summary>
            [NameInMap("fail")]
            [Validation(Required=false)]
            public long? Fail { get; set; }

            /// <summary>
            /// The number of log shipping jobs that are in the running state.
            /// </summary>
            [NameInMap("running")]
            [Validation(Required=false)]
            public long? Running { get; set; }

            /// <summary>
            /// The number of log shipping jobs that are in the success state.
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public long? Success { get; set; }

        }

        /// <summary>
        /// The details of log shipping jobs.
        /// </summary>
        [NameInMap("tasks")]
        [Validation(Required=false)]
        public GetShipperStatusResponseBodyTasks Tasks { get; set; }
        public class GetShipperStatusResponseBodyTasks : TeaModel {
            /// <summary>
            /// The ID of the log shipping job.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The error code of the log shipping job.
            /// </summary>
            [NameInMap("taskCode")]
            [Validation(Required=false)]
            public string TaskCode { get; set; }

            /// <summary>
            /// The start time of the log shipping job. The value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("taskCreateTime")]
            [Validation(Required=false)]
            public long? TaskCreateTime { get; set; }

            /// <summary>
            /// The number of logs that are shipped in the log shipping job.
            /// </summary>
            [NameInMap("taskDataLines")]
            [Validation(Required=false)]
            public int? TaskDataLines { get; set; }

            /// <summary>
            /// The end time of the log shipping job. The value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("taskFinishTime")]
            [Validation(Required=false)]
            public long? TaskFinishTime { get; set; }

            /// <summary>
            /// The time when Simple Log Service receives the most recent log of the log shipping job. The value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("taskLastDataReceiveTime")]
            [Validation(Required=false)]
            public long? TaskLastDataReceiveTime { get; set; }

            /// <summary>
            /// The error message of the log shipping job.
            /// </summary>
            [NameInMap("taskMessage")]
            [Validation(Required=false)]
            public string TaskMessage { get; set; }

            /// <summary>
            /// The status of the log shipping job. Valid values: running, success, and fail.
            /// </summary>
            [NameInMap("taskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// The total number of log shipping jobs.
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
