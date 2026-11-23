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
        /// <para>Specifies whether the resource is the default resource. Currently, you can set this parameter only to true. The value false is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// <para>The collection of resource tags. If multiple tags are specified, only resources that have all the specified tags are returned.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<UpdateWorkspaceResourceRequestLabels> Labels { get; set; }
        public class UpdateWorkspaceResourceRequestLabels : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system.******</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para><b>[Deprecated]</b> This field is deprecated and will be taken offline. Use the ResourceType field instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The collection of resource IDs. GroupName and ResourceIds cannot be both empty, but they can be both specified. If both are specified, the GroupName of each resource ID in the collection must be the same.</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The list of resource types. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MaxCompute: MaxCompute big data compute EPS resources</description></item>
        /// <item><description>ECS: general-purpose compute resources</description></item>
        /// <item><description>Lingjun: Lingjun AI computing resources</description></item>
        /// <item><description>ACS: ACS compute resources</description></item>
        /// <item><description>FLINK: Flink resources</description></item>
        /// <item><description>SelfManagedAckPro: ACK Pro unified management cluster resources</description></item>
        /// <item><description>SelfManagedAckLingjun: ACK Lingjun unified management cluster resources</description></item>
        /// <item><description>SelfManagedASI: ASI unified management cluster resources (third-party cloud)</description></item>
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
