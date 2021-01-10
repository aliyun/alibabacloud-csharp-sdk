// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Logiccomposer20181212.Models
{
    public class DescribeConnectorCapabilityResponseBody : TeaModel {
        [NameInMap("Connections")]
        [Validation(Required=false)]
        public List<DescribeConnectorCapabilityResponseBodyConnections> Connections { get; set; }
        public class DescribeConnectorCapabilityResponseBodyConnections : TeaModel {
            [NameInMap("Definition")]
            [Validation(Required=false)]
            public string Definition { get; set; }

            [NameInMap("ConnectionName")]
            [Validation(Required=false)]
            public string ConnectionName { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

        }

        [NameInMap("Connector")]
        [Validation(Required=false)]
        public DescribeConnectorCapabilityResponseBodyConnector Connector { get; set; }
        public class DescribeConnectorCapabilityResponseBodyConnector : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
            [NameInMap("DefaultPolicy")]
            [Validation(Required=false)]
            public List<string> DefaultPolicy { get; set; }
            [NameInMap("FullName")]
            [Validation(Required=false)]
            public string FullName { get; set; }
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public DescribeConnectorCapabilityResponseBodyConnectorIcon Icon { get; set; }
            public class DescribeConnectorCapabilityResponseBodyConnectorIcon : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }
            [NameInMap("ConnectorId")]
            [Validation(Required=false)]
            public string ConnectorId { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("RamMap")]
            [Validation(Required=false)]
            public string RamMap { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("BrandColor")]
            [Validation(Required=false)]
            public string BrandColor { get; set; }
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }
            [NameInMap("ConnectionParameters")]
            [Validation(Required=false)]
            public DescribeConnectorCapabilityResponseBodyConnectorConnectionParameters ConnectionParameters { get; set; }
            public class DescribeConnectorCapabilityResponseBodyConnectorConnectionParameters : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
        };

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<DescribeConnectorCapabilityResponseBodyParameters> Parameters { get; set; }
        public class DescribeConnectorCapabilityResponseBodyParameters : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("PlaceHolder")]
            [Validation(Required=false)]
            public string PlaceHolder { get; set; }

            [NameInMap("ReadOnly")]
            [Validation(Required=false)]
            public bool? ReadOnly { get; set; }

            [NameInMap("Example")]
            [Validation(Required=false)]
            public string Example { get; set; }

            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            [NameInMap("SubType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            [NameInMap("EnumDisplayName")]
            [Validation(Required=false)]
            public List<string> EnumDisplayName { get; set; }

            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Position")]
            [Validation(Required=false)]
            public string Position { get; set; }

            [NameInMap("Enum")]
            [Validation(Required=false)]
            public List<string> Enum { get; set; }

            [NameInMap("SubParameters")]
            [Validation(Required=false)]
            public List<DescribeConnectorCapabilityResponseBodyParametersSubParameters> SubParameters { get; set; }
            public class DescribeConnectorCapabilityResponseBodyParametersSubParameters : TeaModel {
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("DocumentUrl")]
        [Validation(Required=false)]
        public string DocumentUrl { get; set; }

        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        [NameInMap("DefaultInputs")]
        [Validation(Required=false)]
        public string DefaultInputs { get; set; }

        [NameInMap("System")]
        [Validation(Required=false)]
        public bool? System { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Responses")]
        [Validation(Required=false)]
        public List<DescribeConnectorCapabilityResponseBodyResponses> Responses { get; set; }
        public class DescribeConnectorCapabilityResponseBodyResponses : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            [NameInMap("Example")]
            [Validation(Required=false)]
            public string Example { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
