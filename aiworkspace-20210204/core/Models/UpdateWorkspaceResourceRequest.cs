// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateWorkspaceResourceRequest : TeaModel {
        /// <summary>
        /// <para>The group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group-kjds******sd</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>Specifies whether to set the resource as the default resource for the workspace. Currently, only <c>true</c> is a valid value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// <para>An array of tags. The update affects only resources that have all of the specified tags.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<UpdateWorkspaceResourceRequestLabels> Labels { get; set; }
        public class UpdateWorkspaceResourceRequestLabels : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system.******</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para><b>This parameter is deprecated. Use <c>ResourceType</c> instead.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>An array of resource IDs.</para>
        /// <para>You cannot leave both <c>GroupName</c> and <c>ResourceIds</c> empty. If you specify both parameters, the group name must be the same for all specified resource IDs.</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para>MaxCompute: MaxCompute resources.</para>
        /// </description></item>
        /// <item><description><para>ECS: General-purpose computing resources.</para>
        /// </description></item>
        /// <item><description><para>Lingjun: Lingjun intelligent computing resources.</para>
        /// </description></item>
        /// <item><description><para>ACS: ACS computing resources.</para>
        /// </description></item>
        /// <item><description><para>Flink: Flink resources.</para>
        /// </description></item>
        /// <item><description><para>SelfManagedAckPro: Resources for self-managed ACK Pro clusters.</para>
        /// </description></item>
        /// <item><description><para>SelfManagedAckLingjun: Resources for self-managed ACK Lingjun clusters.</para>
        /// </description></item>
        /// <item><description><para>SelfManagedASI: Resources for self-managed clusters on third-party clouds.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The specifications of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;clusterType&quot;: &quot;share&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public Dictionary<string, object> Spec { get; set; }

    }

}
