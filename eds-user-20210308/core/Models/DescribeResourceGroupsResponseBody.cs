// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeResourceGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68BA1DF7-8814-5AED-B844-F8F7F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource groups.</para>
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public List<DescribeResourceGroupsResponseBodyResourceGroup> ResourceGroup { get; set; }
        public class DescribeResourceGroupsResponseBodyResourceGroup : TeaModel {
            [NameInMap("AppRules")]
            [Validation(Required=false)]
            public List<DescribeResourceGroupsResponseBodyResourceGroupAppRules> AppRules { get; set; }
            public class DescribeResourceGroupsResponseBodyResourceGroupAppRules : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// <para>The number of administrators that are authorized to access the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AuthCount")]
            [Validation(Required=false)]
            public string AuthCount { get; set; }

            /// <summary>
            /// <para>The time when the resource group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-29T17:25:40.000000000Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> The policy that is associated with the resource group.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>The policy applies to cloud computers in the resource group. If multiple policies exist, they are enforced in order of priority.</para>
            /// </description></item>
            /// <item><description><para>If any of these cloud computers are already associated with other policies, the resource group\&quot;s policy takes precedence.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("Policies")]
            [Validation(Required=false)]
            public List<DescribeResourceGroupsResponseBodyResourceGroupPolicies> Policies { get; set; }
            public class DescribeResourceGroupsResponseBodyResourceGroupPolicies : TeaModel {
                /// <summary>
                /// <para>The policy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pl-a8jnatl8kjasb***</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Specifies whether to use the default policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>False</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <para>The policy name.</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The number of resources in the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>119</para>
            /// </summary>
            [NameInMap("ResourceCount")]
            [Validation(Required=false)]
            public string ResourceCount { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-cyo0il2pzge1***</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The name of the resource group.</para>
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> The associated scheduled task.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>The scheduled task applies to all cloud computers in the resource group. If any of these cloud computers are already associated with other scheduled tasks, the resource group\&quot;s scheduled task takes precedence.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Timers")]
            [Validation(Required=false)]
            public List<DescribeResourceGroupsResponseBodyResourceGroupTimers> Timers { get; set; }
            public class DescribeResourceGroupsResponseBodyResourceGroupTimers : TeaModel {
                [NameInMap("BindStatus")]
                [Validation(Required=false)]
                public string BindStatus { get; set; }

                /// <summary>
                /// <para>The ID of the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t-asdzx0mbjhg***</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the scheduled task.</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("TimerStatus")]
                [Validation(Required=false)]
                public string TimerStatus { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of resource groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
