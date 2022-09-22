// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeEcsScenarioFacadeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Scenarios")]
        [Validation(Required=false)]
        public List<DescribeEcsScenarioFacadeResponseBodyScenarios> Scenarios { get; set; }
        public class DescribeEcsScenarioFacadeResponseBodyScenarios : TeaModel {
            [NameInMap("Contents")]
            [Validation(Required=false)]
            public List<DescribeEcsScenarioFacadeResponseBodyScenariosContents> Contents { get; set; }
            public class DescribeEcsScenarioFacadeResponseBodyScenariosContents : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public Dictionary<string, string> Action { get; set; }

                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public Dictionary<string, string> Attributes { get; set; }

                [NameInMap("ColorLevel")]
                [Validation(Required=false)]
                public string ColorLevel { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EcsScenarioContentData")]
                [Validation(Required=false)]
                public List<DescribeEcsScenarioFacadeResponseBodyScenariosContentsEcsScenarioContentData> EcsScenarioContentData { get; set; }
                public class DescribeEcsScenarioFacadeResponseBodyScenariosContentsEcsScenarioContentData : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("SupportCancel")]
                [Validation(Required=false)]
                public string SupportCancel { get; set; }

                [NameInMap("Tips")]
                [Validation(Required=false)]
                public string Tips { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("Track")]
                [Validation(Required=false)]
                public Dictionary<string, string> Track { get; set; }

            }

            [NameInMap("Scenario")]
            [Validation(Required=false)]
            public string Scenario { get; set; }

        }

    }

}
