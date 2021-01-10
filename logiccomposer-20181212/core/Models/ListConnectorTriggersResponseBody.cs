// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Logiccomposer20181212.Models
{
    public class ListConnectorTriggersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Triggers")]
        [Validation(Required=false)]
        public List<ListConnectorTriggersResponseBodyTriggers> Triggers { get; set; }
        public class ListConnectorTriggersResponseBodyTriggers : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Visibility")]
            [Validation(Required=false)]
            public string Visibility { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DocumentUrl")]
            [Validation(Required=false)]
            public string DocumentUrl { get; set; }

            [NameInMap("Connector")]
            [Validation(Required=false)]
            public ListConnectorTriggersResponseBodyTriggersConnector Connector { get; set; }
            public class ListConnectorTriggersResponseBodyTriggersConnector : TeaModel {
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }
                [NameInMap("FullName")]
                [Validation(Required=false)]
                public string FullName { get; set; }
                [NameInMap("BrandColor")]
                [Validation(Required=false)]
                public string BrandColor { get; set; }
                [NameInMap("Icon")]
                [Validation(Required=false)]
                public ListConnectorTriggersResponseBodyTriggersConnectorIcon Icon { get; set; }
                public class ListConnectorTriggersResponseBodyTriggersConnectorIcon : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }
            };

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("System")]
            [Validation(Required=false)]
            public bool? System { get; set; }

        }

    }

}
