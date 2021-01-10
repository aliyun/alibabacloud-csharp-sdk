// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Logiccomposer20181212.Models
{
    public class DescribeConnectorAttributeResponseBody : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Capabilities")]
        [Validation(Required=false)]
        public DescribeConnectorAttributeResponseBodyCapabilities Capabilities { get; set; }
        public class DescribeConnectorAttributeResponseBodyCapabilities : TeaModel {
            [NameInMap("Actions")]
            [Validation(Required=false)]
            public List<DescribeConnectorAttributeResponseBodyCapabilitiesActions> Actions { get; set; }
            public class DescribeConnectorAttributeResponseBodyCapabilitiesActions : TeaModel {
                public string DisplayName { get; set; }
                public string Type { get; set; }
                public string Visibility { get; set; }
                public string Description { get; set; }
                public string DocumentUrl { get; set; }
                public string Name { get; set; }
                public bool? System { get; set; }
                public string DefaultActionName { get; set; }
            }
            [NameInMap("Triggers")]
            [Validation(Required=false)]
            public List<DescribeConnectorAttributeResponseBodyCapabilitiesTriggers> Triggers { get; set; }
            public class DescribeConnectorAttributeResponseBodyCapabilitiesTriggers : TeaModel {
                public string DisplayName { get; set; }
                public string Type { get; set; }
                public string Visibility { get; set; }
                public string Description { get; set; }
                public string DocumentUrl { get; set; }
                public string Name { get; set; }
                public bool? System { get; set; }
            }
        };

        [NameInMap("FullName")]
        [Validation(Required=false)]
        public string FullName { get; set; }

        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Icon")]
        [Validation(Required=false)]
        public DescribeConnectorAttributeResponseBodyIcon Icon { get; set; }
        public class DescribeConnectorAttributeResponseBodyIcon : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }
        };

        [NameInMap("BrandColor")]
        [Validation(Required=false)]
        public string BrandColor { get; set; }

        [NameInMap("StepResult")]
        [Validation(Required=false)]
        public DescribeConnectorAttributeResponseBodyStepResult StepResult { get; set; }
        public class DescribeConnectorAttributeResponseBodyStepResult : TeaModel {
            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }
        };

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ConnectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

    }

}
