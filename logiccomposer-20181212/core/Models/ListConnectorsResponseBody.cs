// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Logiccomposer20181212.Models
{
    public class ListConnectorsResponseBody : TeaModel {
        [NameInMap("Connectors")]
        [Validation(Required=false)]
        public List<ListConnectorsResponseBodyConnectors> Connectors { get; set; }
        public class ListConnectorsResponseBodyConnectors : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("Capabilities")]
            [Validation(Required=false)]
            public List<string> Capabilities { get; set; }

            [NameInMap("ParentConnector")]
            [Validation(Required=false)]
            public string ParentConnector { get; set; }

            [NameInMap("FullName")]
            [Validation(Required=false)]
            public string FullName { get; set; }

            [NameInMap("Icon")]
            [Validation(Required=false)]
            public ListConnectorsResponseBodyConnectorsIcon Icon { get; set; }
            public class ListConnectorsResponseBodyConnectorsIcon : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }
            };

            [NameInMap("ConnectorId")]
            [Validation(Required=false)]
            public string ConnectorId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

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
            public ListConnectorsResponseBodyConnectorsConnectionParameters ConnectionParameters { get; set; }
            public class ListConnectorsResponseBodyConnectorsConnectionParameters : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }
            };

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
