// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateScheduledPreloadExecutionsResponseBody : TeaModel {
        [NameInMap("FailedExecutions")]
        [Validation(Required=false)]
        public List<CreateScheduledPreloadExecutionsResponseBodyFailedExecutions> FailedExecutions { get; set; }
        public class CreateScheduledPreloadExecutionsResponseBodyFailedExecutions : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("SliceLen")]
            [Validation(Required=false)]
            public int? SliceLen { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("FailedMessages")]
        [Validation(Required=false)]
        public List<string> FailedMessages { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

        [NameInMap("SuccessExecutions")]
        [Validation(Required=false)]
        public List<CreateScheduledPreloadExecutionsResponseBodySuccessExecutions> SuccessExecutions { get; set; }
        public class CreateScheduledPreloadExecutionsResponseBodySuccessExecutions : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("SliceLen")]
            [Validation(Required=false)]
            public int? SliceLen { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
