// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeAddonsResponseBody : TeaModel {
        [NameInMap("ComponentGroups")]
        [Validation(Required=false)]
        public List<DescribeAddonsResponseBodyComponentGroups> ComponentGroups { get; set; }
        public class DescribeAddonsResponseBodyComponentGroups : TeaModel {
            [NameInMap("group_name")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("items")]
            [Validation(Required=false)]
            public List<DescribeAddonsResponseBodyComponentGroupsItems> Items { get; set; }
            public class DescribeAddonsResponseBodyComponentGroupsItems : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        [NameInMap("StandardComponents")]
        [Validation(Required=false)]
        public Dictionary<string, StandardComponentsValue> StandardComponents { get; set; }

    }

}
