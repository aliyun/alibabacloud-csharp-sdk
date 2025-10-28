// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListSummariesResponseBody : TeaModel {
        [NameInMap("CenterSummary")]
        [Validation(Required=false)]
        public ListSummariesResponseBodyCenterSummary CenterSummary { get; set; }
        public class ListSummariesResponseBodyCenterSummary : TeaModel {
            [NameInMap("RegisteredResourceTypeCount")]
            [Validation(Required=false)]
            public int? RegisteredResourceTypeCount { get; set; }

            [NameInMap("TemplateCount")]
            [Validation(Required=false)]
            public string TemplateCount { get; set; }

        }

        [NameInMap("RegionSummaries")]
        [Validation(Required=false)]
        public List<ListSummariesResponseBodyRegionSummaries> RegionSummaries { get; set; }
        public class ListSummariesResponseBodyRegionSummaries : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("StackCount")]
            [Validation(Required=false)]
            public string StackCount { get; set; }

            [NameInMap("StackDetails")]
            [Validation(Required=false)]
            public List<ListSummariesResponseBodyRegionSummariesStackDetails> StackDetails { get; set; }
            public class ListSummariesResponseBodyRegionSummariesStackDetails : TeaModel {
                [NameInMap("BriefStatus")]
                [Validation(Required=false)]
                public string BriefStatus { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public string Count { get; set; }

            }

            [NameInMap("StackGroupCount")]
            [Validation(Required=false)]
            public string StackGroupCount { get; set; }

            [NameInMap("TemplateScratchCount")]
            [Validation(Required=false)]
            public int? TemplateScratchCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
