// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeGuestApplicationsResponseBody : TeaModel {
        /// <summary>
        /// The details of the applications.
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<DescribeGuestApplicationsResponseBodyApplications> Applications { get; set; }
        public class DescribeGuestApplicationsResponseBodyApplications : TeaModel {
            /// <summary>
            /// The application name.
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// The application version.
            /// </summary>
            [NameInMap("ApplicationVersion")]
            [Validation(Required=false)]
            public string ApplicationVersion { get; set; }

            /// <summary>
            /// The CPU utilization (%).
            /// </summary>
            [NameInMap("CpuPercent")]
            [Validation(Required=false)]
            public double? CpuPercent { get; set; }

            /// <summary>
            /// The GPU utilization (%).
            /// </summary>
            [NameInMap("GpuPercent")]
            [Validation(Required=false)]
            public double? GpuPercent { get; set; }

            /// <summary>
            /// The icon URL of the application.
            /// </summary>
            [NameInMap("IconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            /// <summary>
            /// The I/O read and write performance.
            /// </summary>
            [NameInMap("IoSpeed")]
            [Validation(Required=false)]
            public double? IoSpeed { get; set; }

            /// <summary>
            /// The memory utilization (%).
            /// </summary>
            [NameInMap("MemPercent")]
            [Validation(Required=false)]
            public double? MemPercent { get; set; }

            /// <summary>
            /// The process ID (PID).
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public int? Pid { get; set; }

            /// <summary>
            /// The process information.
            /// </summary>
            [NameInMap("ProcessData")]
            [Validation(Required=false)]
            public List<DescribeGuestApplicationsResponseBodyApplicationsProcessData> ProcessData { get; set; }
            public class DescribeGuestApplicationsResponseBodyApplicationsProcessData : TeaModel {
                /// <summary>
                /// The application name.
                /// </summary>
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

                /// <summary>
                /// The application version.
                /// </summary>
                [NameInMap("ApplicationVersion")]
                [Validation(Required=false)]
                public string ApplicationVersion { get; set; }

                /// <summary>
                /// The CPU utilization (%).
                /// </summary>
                [NameInMap("CpuPercent")]
                [Validation(Required=false)]
                public double? CpuPercent { get; set; }

                /// <summary>
                /// The GPU utilization (%).
                /// </summary>
                [NameInMap("GpuPercent")]
                [Validation(Required=false)]
                public double? GpuPercent { get; set; }

                /// <summary>
                /// The I/O read and write performance.
                /// </summary>
                [NameInMap("Iospeed")]
                [Validation(Required=false)]
                public double? Iospeed { get; set; }

                /// <summary>
                /// The memory utilization (%).
                /// </summary>
                [NameInMap("MemPercent")]
                [Validation(Required=false)]
                public double? MemPercent { get; set; }

                /// <summary>
                /// The PID.
                /// </summary>
                [NameInMap("Pid")]
                [Validation(Required=false)]
                public int? Pid { get; set; }

                /// <summary>
                /// The path to the process.
                /// </summary>
                [NameInMap("ProcessPath")]
                [Validation(Required=false)]
                public string ProcessPath { get; set; }

            }

            /// <summary>
            /// The path to the process.
            /// </summary>
            [NameInMap("ProcessPath")]
            [Validation(Required=false)]
            public string ProcessPath { get; set; }

            /// <summary>
            /// The application status.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
