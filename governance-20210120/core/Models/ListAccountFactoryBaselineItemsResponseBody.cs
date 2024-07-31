// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListAccountFactoryBaselineItemsResponseBody : TeaModel {
        [NameInMap("BaselineItems")]
        [Validation(Required=false)]
        public List<ListAccountFactoryBaselineItemsResponseBodyBaselineItems> BaselineItems { get; set; }
        public class ListAccountFactoryBaselineItemsResponseBodyBaselineItems : TeaModel {
            [NameInMap("DependsOn")]
            [Validation(Required=false)]
            public List<ListAccountFactoryBaselineItemsResponseBodyBaselineItemsDependsOn> DependsOn { get; set; }
            public class ListAccountFactoryBaselineItemsResponseBodyBaselineItemsDependsOn : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
