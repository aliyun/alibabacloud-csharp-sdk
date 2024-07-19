// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceCronScalerResponseBody : TeaModel {
        /// <summary>
        /// The points in time that are excluded when you schedule a CronHPA job. The points in time must be specified by using a cron expression.
        /// </summary>
        [NameInMap("ExcludeDates")]
        [Validation(Required=false)]
        public List<string> ExcludeDates { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The CronHPA jobs.
        /// </summary>
        [NameInMap("ScaleJobs")]
        [Validation(Required=false)]
        public List<DescribeServiceCronScalerResponseBodyScaleJobs> ScaleJobs { get; set; }
        public class DescribeServiceCronScalerResponseBodyScaleJobs : TeaModel {
            /// <summary>
            /// The time when the most recent CronHPA job was created. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The time when the most recent CronHPA job ran. The time is displayed in UTC.
            /// </summary>
            [NameInMap("LastProbeTime")]
            [Validation(Required=false)]
            public string LastProbeTime { get; set; }

            /// <summary>
            /// The returned message.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The name of the CronHPA job.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The cron expression that is used to configure the execution time of the CronHPA job.
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

            /// <summary>
            /// The status of the most recent CronHPA job.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The number of instances that you expect to configure for the CronHPA job.
            /// </summary>
            [NameInMap("TargetSize")]
            [Validation(Required=false)]
            public int? TargetSize { get; set; }

        }

        /// <summary>
        /// The service name.
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
