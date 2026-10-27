// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeResourceGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68BA1DF7-8814-5AED-B844-F8F7F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of resource group information.</para>
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public List<DescribeResourceGroupsResponseBodyResourceGroup> ResourceGroup { get; set; }
        public class DescribeResourceGroupsResponseBodyResourceGroup : TeaModel {
            /// <summary>
            /// <para>The agent subtype of the DesktopAgent resource group. Valid values: JVSClaw and HermesAgent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JVSClaw</para>
            /// </summary>
            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-123456</para>
            /// </summary>
            [NameInMap("AliyunResourceGroupId")]
            [Validation(Required=false)]
            public string AliyunResourceGroupId { get; set; }

            /// <summary>
            /// <para>The list of application rules associated with the resource group.</para>
            /// </summary>
            [NameInMap("AppRules")]
            [Validation(Required=false)]
            public List<DescribeResourceGroupsResponseBodyResourceGroupAppRules> AppRules { get; set; }
            public class DescribeResourceGroupsResponseBodyResourceGroupAppRules : TeaModel {
                /// <summary>
                /// <para>The ID of the application rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ruleId1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the application rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ruleName1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the application rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// <para>The number of administrators authorized for the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AuthCount")]
            [Validation(Required=false)]
            public string AuthCount { get; set; }

            /// <summary>
            /// <para>The creation time in ISO 8601 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-29T17:25:40.000000000Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>The policies associated with the resource group.</para>
            /// <list type="bullet">
            /// <item><description>The associated policies take effect on the cloud computers in the resource group. If multiple policies exist, they take effect based on their priorities.</description></item>
            /// <item><description>If a cloud computer in the resource group is already assigned another policy, the policy associated with the resource group takes precedence.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("Policies")]
            [Validation(Required=false)]
            public List<DescribeResourceGroupsResponseBodyResourceGroupPolicies> Policies { get; set; }
            public class DescribeResourceGroupsResponseBodyResourceGroupPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pl-a8jnatl8kjasb***</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Specifies whether the policy is the default policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>False</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <para>The policy name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test policy 123</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The resource count in the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>119</para>
            /// </summary>
            [NameInMap("ResourceCount")]
            [Validation(Required=false)]
            public string ResourceCount { get; set; }

            /// <summary>
            /// <para>The description of the resource group. If not set, an empty string is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Department A resource group</para>
            /// </summary>
            [NameInMap("ResourceGroupDescription")]
            [Validation(Required=false)]
            public string ResourceGroupDescription { get; set; }

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
            /// 
            /// <b>Example:</b>
            /// <para>Test resource group</para>
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>The scheduled tasks associated with the resource group.</para>
            /// <list type="bullet">
            /// <item><description>The associated scheduled tasks take effect on the cloud computers in the resource group. If a cloud computer in the resource group is already associated with another scheduled task, the task associated with the resource group takes precedence.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("Timers")]
            [Validation(Required=false)]
            public List<DescribeResourceGroupsResponseBodyResourceGroupTimers> Timers { get; set; }
            public class DescribeResourceGroupsResponseBodyResourceGroupTimers : TeaModel {
                /// <summary>
                /// <para>The association status between the scheduled task and the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BIND</para>
                /// </summary>
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
                /// 
                /// <b>Example:</b>
                /// <para>Test task 123</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The running status of the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AVAILABLE</para>
                /// </summary>
                [NameInMap("TimerStatus")]
                [Validation(Required=false)]
                public string TimerStatus { get; set; }

                /// <summary>
                /// <para>The type of the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TIMER</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

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
