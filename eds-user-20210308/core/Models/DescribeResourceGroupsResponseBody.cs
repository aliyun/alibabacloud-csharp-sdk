// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeResourceGroupsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>68BA1DF7-8814-5AED-B844-F8F7F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public List<DescribeResourceGroupsResponseBodyResourceGroup> ResourceGroup { get; set; }
        public class DescribeResourceGroupsResponseBodyResourceGroup : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AuthCount")]
            [Validation(Required=false)]
            public string AuthCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-11-29T17:25:40.000000000Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Policies")]
            [Validation(Required=false)]
            public List<DescribeResourceGroupsResponseBodyResourceGroupPolicies> Policies { get; set; }
            public class DescribeResourceGroupsResponseBodyResourceGroupPolicies : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>pl-a8jnatl8kjasb***</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>False</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>119</para>
            /// </summary>
            [NameInMap("ResourceCount")]
            [Validation(Required=false)]
            public string ResourceCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-cyo0il2pzge1***</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            [NameInMap("Timers")]
            [Validation(Required=false)]
            public List<DescribeResourceGroupsResponseBodyResourceGroupTimers> Timers { get; set; }
            public class DescribeResourceGroupsResponseBodyResourceGroupTimers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>t-asdzx0mbjhg***</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
