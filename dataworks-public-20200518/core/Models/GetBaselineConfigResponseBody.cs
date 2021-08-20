// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetBaselineConfigResponseBody : TeaModel {
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
        public GetBaselineConfigResponseBodyData Data { get; set; }
        public class GetBaselineConfigResponseBodyData : TeaModel {
            [NameInMap("HourSlaDetail")]
            [Validation(Required=false)]
            public string HourSlaDetail { get; set; }
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }
            [NameInMap("SlaMinu")]
            [Validation(Required=false)]
            public int? SlaMinu { get; set; }
            [NameInMap("SlaHour")]
            [Validation(Required=false)]
            public int? SlaHour { get; set; }
            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public long? BaselineId { get; set; }
            [NameInMap("BaselineName")]
            [Validation(Required=false)]
            public string BaselineName { get; set; }
            [NameInMap("HourExpDetail")]
            [Validation(Required=false)]
            public string HourExpDetail { get; set; }
            [NameInMap("UseFlag")]
            [Validation(Required=false)]
            public bool? UseFlag { get; set; }
            [NameInMap("ExpHour")]
            [Validation(Required=false)]
            public int? ExpHour { get; set; }
            [NameInMap("BaselineType")]
            [Validation(Required=false)]
            public string BaselineType { get; set; }
            [NameInMap("ExpMinu")]
            [Validation(Required=false)]
            public int? ExpMinu { get; set; }
        };

    }

}
