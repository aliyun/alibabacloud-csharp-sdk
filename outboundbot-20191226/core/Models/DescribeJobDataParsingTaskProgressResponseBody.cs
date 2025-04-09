// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeJobDataParsingTaskProgressResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public DescribeJobDataParsingTaskProgressResponseBodyProgress Progress { get; set; }
        public class DescribeJobDataParsingTaskProgressResponseBodyProgress : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Permission.JobStatus</para>
            /// </summary>
            [NameInMap("FailErrorCode")]
            [Validation(Required=false)]
            public string FailErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CreateCorpus</para>
            /// </summary>
            [NameInMap("FailReason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

            [NameInMap("FeedbackUrl")]
            [Validation(Required=false)]
            public string FeedbackUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("HandledJobCount")]
            [Validation(Required=false)]
            public int? HandledJobCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalJobCount")]
            [Validation(Required=false)]
            public int? TotalJobCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
