// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeGroupExecutingInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ExecutingInfo")]
        [Validation(Required=false)]
        public DescribeGroupExecutingInfoResponseBodyExecutingInfo ExecutingInfo { get; set; }
        public class DescribeGroupExecutingInfoResponseBodyExecutingInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("CallFailedNum")]
            [Validation(Required=false)]
            public int? CallFailedNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("CallNum")]
            [Validation(Required=false)]
            public int? CallNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("CreatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1640087774563</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("FinishedNum")]
            [Validation(Required=false)]
            public int? FinishedNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("HangUpByClientNum")]
            [Validation(Required=false)]
            public int? HangUpByClientNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("JobsProgress")]
            [Validation(Required=false)]
            public DescribeGroupExecutingInfoResponseBodyExecutingInfoJobsProgress JobsProgress { get; set; }
            public class DescribeGroupExecutingInfoResponseBodyExecutingInfoJobsProgress : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("CancelledNum")]
                [Validation(Required=false)]
                public int? CancelledNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ExecutingNum")]
                [Validation(Required=false)]
                public int? ExecutingNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("FailedNum")]
                [Validation(Required=false)]
                public int? FailedNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("PausedNum")]
                [Validation(Required=false)]
                public int? PausedNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("SchedulingNum")]
                [Validation(Required=false)]
                public int? SchedulingNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TotalCompletedNum")]
                [Validation(Required=false)]
                public int? TotalCompletedNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TotalJobs")]
                [Validation(Required=false)]
                public int? TotalJobs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TotalNotAnsweredNum")]
                [Validation(Required=false)]
                public int? TotalNotAnsweredNum { get; set; }

            }

            [NameInMap("NoInteractionNum")]
            [Validation(Required=false)]
            public int? NoInteractionNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1640087774563</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TransferByIntentNum")]
            [Validation(Required=false)]
            public int? TransferByIntentNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TransferByNoAnswer")]
            [Validation(Required=false)]
            public int? TransferByNoAnswer { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>b24d321a-2a74-4dd1-a0ba-4ab09cef6652</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c46001bc-3ead-4bfd-9a69-4b5b66a4a3f4</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
