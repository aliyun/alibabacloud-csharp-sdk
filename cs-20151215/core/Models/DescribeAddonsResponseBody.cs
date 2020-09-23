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
            /// 默认组件组。
            /// </summary>
            [NameInMap("default")]
            [Validation(Required=false)]
            public List<string> Default { get; set; }

            /// <summary>
            /// 组件组名称。
            /// </summary>
            [NameInMap("group_name")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// 组件清单。
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<DescribeAddonsResponseBodyComponentGroupsItems> Items { get; set; }
            public class DescribeAddonsResponseBodyComponentGroupsItems : TeaModel {
                /// <summary>
                /// 组件描述信息。
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// 是否禁止默认安装。
                /// </summary>
                [NameInMap("disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                /// <summary>
                /// 组件名称。
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 是否为必需组件。
                /// </summary>
                [NameInMap("required")]
                [Validation(Required=false)]
                public string Required { get; set; }

                /// <summary>
                /// 组件版本。
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// 标准组件信息，包含各个组件的描述信息。
        /// </summary>
        [NameInMap("StandardComponents")]
        [Validation(Required=false)]
        public DescribeAddonsResponseBodyStandardComponents StandardComponents { get; set; }
        public class DescribeAddonsResponseBodyStandardComponents : TeaModel {
            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public Dictionary<string, string> ComponentName { get; set; }
        };

    }

}
