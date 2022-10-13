// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListBaselineStatusesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListBaselineStatusesResponseBodyData Data { get; set; }
        public class ListBaselineStatusesResponseBodyData : TeaModel {
            [NameInMap("BaselineStatuses")]
            [Validation(Required=false)]
            public List<ListBaselineStatusesResponseBodyDataBaselineStatuses> BaselineStatuses { get; set; }
            public class ListBaselineStatusesResponseBodyDataBaselineStatuses : TeaModel {
                [NameInMap("BaselineId")]
                [Validation(Required=false)]
                public long? BaselineId { get; set; }

                [NameInMap("BaselineName")]
                [Validation(Required=false)]
                public string BaselineName { get; set; }

                [NameInMap("Bizdate")]
                [Validation(Required=false)]
                public long? Bizdate { get; set; }

                [NameInMap("Buffer")]
                [Validation(Required=false)]
                public long? Buffer { get; set; }

                [NameInMap("EndCast")]
                [Validation(Required=false)]
                public long? EndCast { get; set; }

                [NameInMap("ExpTime")]
                [Validation(Required=false)]
                public long? ExpTime { get; set; }

                [NameInMap("FinishStatus")]
                [Validation(Required=false)]
                public string FinishStatus { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                [NameInMap("InGroupId")]
                [Validation(Required=false)]
                public int? InGroupId { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                [NameInMap("SlaTime")]
                [Validation(Required=false)]
                public long? SlaTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
