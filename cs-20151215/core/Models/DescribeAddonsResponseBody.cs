// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeAddonsResponseBody : TeaModel {
        /// <summary>
        /// The list of the returned components.
        /// </summary>
        [NameInMap("ComponentGroups")]
        [Validation(Required=false)]
        public List<DescribeAddonsResponseBodyComponentGroups> ComponentGroups { get; set; }
        public class DescribeAddonsResponseBodyComponentGroups : TeaModel {
            /// <summary>
            /// The name of the component group.
            /// </summary>
            [NameInMap("group_name")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The names of the components in the component group.
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<DescribeAddonsResponseBodyComponentGroupsItems> Items { get; set; }
            public class DescribeAddonsResponseBodyComponentGroupsItems : TeaModel {
                /// <summary>
                /// The name of the component.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// Standard components.
        /// </summary>
        [NameInMap("StandardComponents")]
        [Validation(Required=false)]
        public Dictionary<string, StandardComponentsValue> StandardComponents { get; set; }

    }

}
