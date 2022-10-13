// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListBaselineConfigsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListBaselineConfigsResponseBodyData Data { get; set; }
        public class ListBaselineConfigsResponseBodyData : TeaModel {
            [NameInMap("Baselines")]
            [Validation(Required=false)]
            public List<ListBaselineConfigsResponseBodyDataBaselines> Baselines { get; set; }
            public class ListBaselineConfigsResponseBodyDataBaselines : TeaModel {
                [NameInMap("BaselineId")]
                [Validation(Required=false)]
                public long? BaselineId { get; set; }

                [NameInMap("BaselineName")]
                [Validation(Required=false)]
                public string BaselineName { get; set; }

                [NameInMap("BaselineType")]
                [Validation(Required=false)]
                public string BaselineType { get; set; }

                [NameInMap("ExpHour")]
                [Validation(Required=false)]
                public int? ExpHour { get; set; }

                [NameInMap("ExpMinu")]
                [Validation(Required=false)]
                public int? ExpMinu { get; set; }

                [NameInMap("HourExpDetail")]
                [Validation(Required=false)]
                public string HourExpDetail { get; set; }

                [NameInMap("HourSlaDetail")]
                [Validation(Required=false)]
                public string HourSlaDetail { get; set; }

                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                [NameInMap("SlaHour")]
                [Validation(Required=false)]
                public int? SlaHour { get; set; }

                [NameInMap("SlaMinu")]
                [Validation(Required=false)]
                public int? SlaMinu { get; set; }

                [NameInMap("UseFlag")]
                [Validation(Required=false)]
                public bool? UseFlag { get; set; }

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
