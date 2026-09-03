// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeGuestApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The applications.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<DescribeGuestApplicationsResponseBodyApplications> Applications { get; set; }
        public class DescribeGuestApplicationsResponseBodyApplications : TeaModel {
            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Google Chrome</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The application version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>115.0.5790.110</para>
            /// </summary>
            [NameInMap("ApplicationVersion")]
            [Validation(Required=false)]
            public string ApplicationVersion { get; set; }

            /// <summary>
            /// <para>The CPU utilization (%).</para>
            /// 
            /// <b>Example:</b>
            /// <para>89</para>
            /// </summary>
            [NameInMap("CpuPercent")]
            [Validation(Required=false)]
            public double? CpuPercent { get; set; }

            /// <summary>
            /// <para>The GPU utilization (%).</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("GpuPercent")]
            [Validation(Required=false)]
            public double? GpuPercent { get; set; }

            /// <summary>
            /// <para>The icon URL of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://app-center-icon-prod-shanghai.oss-cn-shanghai.aliyuncs.com/market/preload/default****.png">https://app-center-icon-prod-shanghai.oss-cn-shanghai.aliyuncs.com/market/preload/default****.png</a></para>
            /// </summary>
            [NameInMap("IconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            /// <summary>
            /// <para>The I/O read and write performance. Unit: byte/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>124906.0</para>
            /// </summary>
            [NameInMap("IoSpeed")]
            [Validation(Required=false)]
            public double? IoSpeed { get; set; }

            /// <summary>
            /// <para>The memory utilization (%).</para>
            /// 
            /// <b>Example:</b>
            /// <para>34</para>
            /// </summary>
            [NameInMap("MemPercent")]
            [Validation(Required=false)]
            public double? MemPercent { get; set; }

            /// <summary>
            /// <para>The process ID (PID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1357</para>
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public int? Pid { get; set; }

            /// <summary>
            /// <para>The processes.</para>
            /// </summary>
            [NameInMap("ProcessData")]
            [Validation(Required=false)]
            public List<DescribeGuestApplicationsResponseBodyApplicationsProcessData> ProcessData { get; set; }
            public class DescribeGuestApplicationsResponseBodyApplicationsProcessData : TeaModel {
                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Google Chrome</para>
                /// </summary>
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

                /// <summary>
                /// <para>The application version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>115.0.5790.110</para>
                /// </summary>
                [NameInMap("ApplicationVersion")]
                [Validation(Required=false)]
                public string ApplicationVersion { get; set; }

                /// <summary>
                /// <para>The CPU utilization (%).</para>
                /// 
                /// <b>Example:</b>
                /// <para>89</para>
                /// </summary>
                [NameInMap("CpuPercent")]
                [Validation(Required=false)]
                public double? CpuPercent { get; set; }

                /// <summary>
                /// <para>The GPU usage (%).</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("GpuPercent")]
                [Validation(Required=false)]
                public double? GpuPercent { get; set; }

                /// <summary>
                /// <para>The I/O read and write performance. Unit: byte/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>124906.0</para>
                /// </summary>
                [NameInMap("Iospeed")]
                [Validation(Required=false)]
                public double? Iospeed { get; set; }

                /// <summary>
                /// <para>The memory usage (%).</para>
                /// 
                /// <b>Example:</b>
                /// <para>34</para>
                /// </summary>
                [NameInMap("MemPercent")]
                [Validation(Required=false)]
                public double? MemPercent { get; set; }

                /// <summary>
                /// <para>The PID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1357</para>
                /// </summary>
                [NameInMap("Pid")]
                [Validation(Required=false)]
                public int? Pid { get; set; }

                /// <summary>
                /// <para>The path to the process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>C:\\Program Files\\Google\\Chrome\\Application\\ch****.exe</para>
                /// </summary>
                [NameInMap("ProcessPath")]
                [Validation(Required=false)]
                public string ProcessPath { get; set; }

            }

            /// <summary>
            /// <para>The path to the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C:\\Program Files\\Google\\Chrome\\Application\\ch****.exe</para>
            /// </summary>
            [NameInMap("ProcessPath")]
            [Validation(Required=false)]
            public string ProcessPath { get; set; }

            /// <summary>
            /// <para>The status of the application.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>Idle: The application is installed in the cloud computer but is not running.</description></item>
            /// <item><description>Running: The application has been installed in the cloud computer and is running.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>272CF39E-B5DE-5BE3-A09B-B43F1026****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
