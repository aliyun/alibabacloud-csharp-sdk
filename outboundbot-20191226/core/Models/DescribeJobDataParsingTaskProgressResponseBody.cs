// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeJobDataParsingTaskProgressResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Parsing progress.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public DescribeJobDataParsingTaskProgressResponseBodyProgress Progress { get; set; }
        public class DescribeJobDataParsingTaskProgressResponseBodyProgress : TeaModel {
            /// <summary>
            /// <para>Error code for a failed parsing task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Permission.JobStatus</para>
            /// </summary>
            [NameInMap("FailErrorCode")]
            [Validation(Required=false)]
            public string FailErrorCode { get; set; }

            /// <summary>
            /// <para>Reason for failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreateCorpus</para>
            /// </summary>
            [NameInMap("FailReason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

            /// <summary>
            /// <para>Download URL for the file that lists parsing failures. This field is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("FeedbackUrl")]
            [Validation(Required=false)]
            public string FeedbackUrl { get; set; }

            /// <summary>
            /// <para>Number of jobs processed so far.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("HandledJobCount")]
            [Validation(Required=false)]
            public int? HandledJobCount { get; set; }

            /// <summary>
            /// <para>Status of the job.</para>
            /// <list type="bullet">
            /// <item><description><para>Pending: The job is waiting to start.</para>
            /// </description></item>
            /// <item><description><para>InProgress: The job is running.</para>
            /// </description></item>
            /// <item><description><para>Finished: The job completed successfully.</para>
            /// </description></item>
            /// <item><description><para>PartialFinished: The job completed partially.</para>
            /// </description></item>
            /// <item><description><para>Failed: The job failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Total number of jobs in the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalJobCount")]
            [Validation(Required=false)]
            public int? TotalJobCount { get; set; }

        }

        /// <summary>
        /// <para>ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
