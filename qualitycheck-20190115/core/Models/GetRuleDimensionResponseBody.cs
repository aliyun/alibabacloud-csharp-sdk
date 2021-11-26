// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetRuleDimensionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CompSubTaskCount")]
        [Validation(Required=false)]
        public int? CompSubTaskCount { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRuleDimensionResponseBodyData Data { get; set; }
        public class GetRuleDimensionResponseBodyData : TeaModel {
            [NameInMap("RuleCountInfo")]
            [Validation(Required=false)]
            public List<GetRuleDimensionResponseBodyDataRuleCountInfo> RuleCountInfo { get; set; }
            public class GetRuleDimensionResponseBodyDataRuleCountInfo : TeaModel {
                public int? CheckNumber { get; set; }
                public string CreateEmpid { get; set; }
                public string CreateTime { get; set; }
                public int? HitNumber { get; set; }
                public float? HitRate { get; set; }
                public float? HitRealViolationRate { get; set; }
                public int? IsDelete { get; set; }
                public string LastUpdateEmpid { get; set; }
                public string LastUpdateTime { get; set; }
                public string Name { get; set; }
                public int? PreReviewNumber { get; set; }
                public int? RealViolationNumber { get; set; }
                public int? ReviewNumber { get; set; }
                public string Rid { get; set; }
                public bool? Select { get; set; }
                public int? Status { get; set; }
                public int? Type { get; set; }
                public string TypeName { get; set; }
            }
        };

        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public int? DataSize { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ReviewStatus")]
        [Validation(Required=false)]
        public int? ReviewStatus { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("TotalSubTaskCount")]
        [Validation(Required=false)]
        public int? TotalSubTaskCount { get; set; }

    }

}
