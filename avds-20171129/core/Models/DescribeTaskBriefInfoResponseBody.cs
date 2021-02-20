// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avds20171129.Models
{
    public class DescribeTaskBriefInfoResponseBody : TeaModel {
        [NameInMap("RisksFacets")]
        [Validation(Required=false)]
        public DescribeTaskBriefInfoResponseBodyRisksFacets RisksFacets { get; set; }
        public class DescribeTaskBriefInfoResponseBodyRisksFacets : TeaModel {
            [NameInMap("Medium")]
            [Validation(Required=false)]
            public int? Medium { get; set; }
            [NameInMap("Low")]
            [Validation(Required=false)]
            public int? Low { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
            [NameInMap("High")]
            [Validation(Required=false)]
            public int? High { get; set; }
            [NameInMap("Info")]
            [Validation(Required=false)]
            public int? Info { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Brief")]
        [Validation(Required=false)]
        public DescribeTaskBriefInfoResponseBodyBrief Brief { get; set; }
        public class DescribeTaskBriefInfoResponseBodyBrief : TeaModel {
            [NameInMap("FinishedAt")]
            [Validation(Required=false)]
            public long? FinishedAt { get; set; }
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public float? Progress { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("ActionRunsFacet")]
            [Validation(Required=false)]
            public DescribeTaskBriefInfoResponseBodyBriefActionRunsFacet ActionRunsFacet { get; set; }
            public class DescribeTaskBriefInfoResponseBodyBriefActionRunsFacet : TeaModel {
                [NameInMap("Completed")]
                [Validation(Required=false)]
                public int? Completed { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }
        };

    }

}
