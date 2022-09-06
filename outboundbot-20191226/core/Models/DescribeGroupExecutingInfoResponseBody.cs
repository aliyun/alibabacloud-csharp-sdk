// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeGroupExecutingInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ExecutingInfo")]
        [Validation(Required=false)]
        public DescribeGroupExecutingInfoResponseBodyExecutingInfo ExecutingInfo { get; set; }
        public class DescribeGroupExecutingInfoResponseBodyExecutingInfo : TeaModel {
            [NameInMap("CallFailedNum")]
            [Validation(Required=false)]
            public int? CallFailedNum { get; set; }

            [NameInMap("CallNum")]
            [Validation(Required=false)]
            public int? CallNum { get; set; }

            [NameInMap("CreatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("FinishedNum")]
            [Validation(Required=false)]
            public int? FinishedNum { get; set; }

            [NameInMap("HangUpByClientNum")]
            [Validation(Required=false)]
            public int? HangUpByClientNum { get; set; }

            [NameInMap("JobsProgress")]
            [Validation(Required=false)]
            public DescribeGroupExecutingInfoResponseBodyExecutingInfoJobsProgress JobsProgress { get; set; }
            public class DescribeGroupExecutingInfoResponseBodyExecutingInfoJobsProgress : TeaModel {
                [NameInMap("CancelledNum")]
                [Validation(Required=false)]
                public int? CancelledNum { get; set; }

                [NameInMap("ExecutingNum")]
                [Validation(Required=false)]
                public int? ExecutingNum { get; set; }

                [NameInMap("FailedNum")]
                [Validation(Required=false)]
                public int? FailedNum { get; set; }

                [NameInMap("PausedNum")]
                [Validation(Required=false)]
                public int? PausedNum { get; set; }

                [NameInMap("SchedulingNum")]
                [Validation(Required=false)]
                public int? SchedulingNum { get; set; }

                [NameInMap("TotalCompletedNum")]
                [Validation(Required=false)]
                public int? TotalCompletedNum { get; set; }

                [NameInMap("TotalJobs")]
                [Validation(Required=false)]
                public int? TotalJobs { get; set; }

                [NameInMap("TotalNotAnsweredNum")]
                [Validation(Required=false)]
                public int? TotalNotAnsweredNum { get; set; }

            }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("TransferByIntentNum")]
            [Validation(Required=false)]
            public int? TransferByIntentNum { get; set; }

            [NameInMap("TransferByNoAnswer")]
            [Validation(Required=false)]
            public int? TransferByNoAnswer { get; set; }

        }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
