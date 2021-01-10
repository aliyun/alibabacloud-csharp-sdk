// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Logiccomposer20181212.Models
{
    public class ListFlowConnectionsResponseBody : TeaModel {
        [NameInMap("Connections")]
        [Validation(Required=false)]
        public List<ListFlowConnectionsResponseBodyConnections> Connections { get; set; }
        public class ListFlowConnectionsResponseBodyConnections : TeaModel {
            [NameInMap("Definition")]
            [Validation(Required=false)]
            public string Definition { get; set; }

            [NameInMap("Actions")]
            [Validation(Required=false)]
            public List<ListFlowConnectionsResponseBodyConnectionsActions> Actions { get; set; }
            public class ListFlowConnectionsResponseBodyConnectionsActions : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("ActionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

            }

            [NameInMap("ConnectionName")]
            [Validation(Required=false)]
            public string ConnectionName { get; set; }

            [NameInMap("Connector")]
            [Validation(Required=false)]
            public ListFlowConnectionsResponseBodyConnectionsConnector Connector { get; set; }
            public class ListFlowConnectionsResponseBodyConnectionsConnector : TeaModel {
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }
                [NameInMap("BrandColor")]
                [Validation(Required=false)]
                public string BrandColor { get; set; }
                [NameInMap("Icon")]
                [Validation(Required=false)]
                public ListFlowConnectionsResponseBodyConnectionsConnectorIcon Icon { get; set; }
                public class ListFlowConnectionsResponseBodyConnectionsConnectorIcon : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
                [NameInMap("ConnectionParameters")]
                [Validation(Required=false)]
                public ListFlowConnectionsResponseBodyConnectionsConnectorConnectionParameters ConnectionParameters { get; set; }
                public class ListFlowConnectionsResponseBodyConnectionsConnectorConnectionParameters : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }
            };

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
