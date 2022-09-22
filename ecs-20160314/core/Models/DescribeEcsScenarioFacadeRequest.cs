// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeEcsScenarioFacadeRequest : TeaModel {
        [NameInMap("ExtMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtMap { get; set; }

        [NameInMap("ExtParam")]
        [Validation(Required=false)]
        public string ExtParam { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("ScenarioList")]
        [Validation(Required=false)]
        public List<DescribeEcsScenarioFacadeRequestScenarioList> ScenarioList { get; set; }
        public class DescribeEcsScenarioFacadeRequestScenarioList : TeaModel {
            [NameInMap("Scenario")]
            [Validation(Required=false)]
            public string Scenario { get; set; }

            [NameInMap("ScenarioResources")]
            [Validation(Required=false)]
            public List<DescribeEcsScenarioFacadeRequestScenarioListScenarioResources> ScenarioResources { get; set; }
            public class DescribeEcsScenarioFacadeRequestScenarioListScenarioResources : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

        }

    }

}
