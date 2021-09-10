// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListBaselineConfigsResponseBody : TeaModel {
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListBaselineConfigsResponseBodyData Data { get; set; }
        public class ListBaselineConfigsResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("Baselines")]
            [Validation(Required=false)]
            public List<ListBaselineConfigsResponseBodyDataBaselines> Baselines { get; set; }
            public class ListBaselineConfigsResponseBodyDataBaselines : TeaModel {
                public string HourSlaDetail { get; set; }
                public bool? IsDefault { get; set; }
                public string Owner { get; set; }
                public long? ProjectId { get; set; }
                public int? Priority { get; set; }
                public int? SlaMinu { get; set; }
                public int? SlaHour { get; set; }
                public long? BaselineId { get; set; }
                public string BaselineName { get; set; }
                public string HourExpDetail { get; set; }
                public bool? UseFlag { get; set; }
                public int? ExpHour { get; set; }
                public string BaselineType { get; set; }
                public int? ExpMinu { get; set; }
            }
        };

    }

}
