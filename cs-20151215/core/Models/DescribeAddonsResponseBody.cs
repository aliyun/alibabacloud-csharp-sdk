// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeAddonsResponseBody : TeaModel {
        /// <summary>
        /// 组件分组信息，例如：存储类组件，网络组件等。
        /// </summary>
        [NameInMap("ComponentGroups")]
        [Validation(Required=false)]
        public List<DescribeAddonsResponseBodyComponentGroups> ComponentGroups { get; set; }
        public class DescribeAddonsResponseBodyComponentGroups : TeaModel {
            /// <summary>
            /// 组件组名称。
            /// </summary>
            [NameInMap("group_name")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// 组件列表
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<DescribeAddonsResponseBodyComponentGroupsItems> Items { get; set; }
            public class DescribeAddonsResponseBodyComponentGroupsItems : TeaModel {
                /// <summary>
                /// 组件名称。
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// 标准组件信息，包含各个组件的描述信息。
        /// </summary>
        [NameInMap("StandardComponents")]
        [Validation(Required=false)]
        public Dictionary<string, StandardComponentsValue> StandardComponents { get; set; }

    }

}
