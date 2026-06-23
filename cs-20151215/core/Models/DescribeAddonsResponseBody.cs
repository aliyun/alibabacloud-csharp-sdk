// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeAddonsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of component groups.</para>
        /// </summary>
        [NameInMap("ComponentGroups")]
        [Validation(Required=false)]
        public List<DescribeAddonsResponseBodyComponentGroups> ComponentGroups { get; set; }
        public class DescribeAddonsResponseBodyComponentGroups : TeaModel {
            /// <summary>
            /// <para>The name of the component group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>storage</para>
            /// </summary>
            [NameInMap("group_name")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The component names included in this group.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<DescribeAddonsResponseBodyComponentGroupsItems> Items { get; set; }
            public class DescribeAddonsResponseBodyComponentGroupsItems : TeaModel {
                /// <summary>
                /// <para>The component name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>flexvolume</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The standard components.</para>
        /// </summary>
        [NameInMap("StandardComponents")]
        [Validation(Required=false)]
        public Dictionary<string, StandardComponentsValue> StandardComponents { get; set; }

    }

}
