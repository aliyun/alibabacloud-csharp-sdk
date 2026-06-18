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
        /// <para>A list of resource groups.</para>
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public List<DescribeResourceGroupsResponseBodyResourceGroup> ResourceGroup { get; set; }
        public class DescribeResourceGroupsResponseBodyResourceGroup : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-123456</para>
            /// </summary>
            [NameInMap("AliyunResourceGroupId")]
            [Validation(Required=false)]
            public string AliyunResourceGroupId { get; set; }

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
            /// <para>The number of administrators authorized for the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AuthCount")]
            [Validation(Required=false)]
            public string AuthCount { get; set; }

            /// <summary>
            /// <para>The time the resource group was created.</para>
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
            /// <item><description><para>These policies apply to the cloud computers in the resource group. If multiple policies are associated, they are applied in order of priority.</para>
            /// </description></item>
            /// <item><description><para>Policies associated with the resource group take precedence over policies assigned to individual cloud computers.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
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
                /// <para>Specifies whether this is the default policy.</para>
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
                /// <para>测试策略123</para>
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
            /// <para>The resource group ID.</para>
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
            /// <para>测试资源组</para>
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>The scheduled tasks associated with the resource group.</para>
            /// <list type="bullet">
            /// <item><description>These scheduled tasks apply to cloud computers in the resource group and take precedence over any tasks associated with individual cloud computers.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("Timers")]
            [Validation(Required=false)]
            public List<DescribeResourceGroupsResponseBodyResourceGroupTimers> Timers { get; set; }
            public class DescribeResourceGroupsResponseBodyResourceGroupTimers : TeaModel {
                [NameInMap("BindStatus")]
                [Validation(Required=false)]
                public string BindStatus { get; set; }

                /// <summary>
                /// <para>The scheduled task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t-asdzx0mbjhg***</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The scheduled task name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试任务123</para>
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
