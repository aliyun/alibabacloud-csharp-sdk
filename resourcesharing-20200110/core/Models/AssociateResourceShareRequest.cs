// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class AssociateResourceShareRequest : TeaModel {
        /// <summary>
        /// <para>The information about the permissions. If you do not configure this parameter, the system automatically associates the default permission for the specified resource type with the resource share. For more information, see <a href="https://help.aliyun.com/document_detail/465474.html">Permission library</a>.</para>
        /// </summary>
        [NameInMap("PermissionNames")]
        [Validation(Required=false)]
        public List<string> PermissionNames { get; set; }

        /// <summary>
        /// <para>The ID of the resource share.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rs-6GRmdD3X****</para>
        /// </summary>
        [NameInMap("ResourceShareId")]
        [Validation(Required=false)]
        public string ResourceShareId { get; set; }

        /// <summary>
        /// <para>The information about the resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<AssociateResourceShareRequestResources> Resources { get; set; }
        public class AssociateResourceShareRequestResources : TeaModel {
            /// <summary>
            /// <para>The ID of a shared resource.</para>
            /// <para>Valid values of N: 1 to 5. This indicates that a maximum of five shared resources can be specified at a time.</para>
            /// <remarks>
            /// <para> Resources.N.ResourceId and Resources.N.ResourceType must be used in pairs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp183p93qs667muql****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The type of a shared resource.</para>
            /// <para>Valid values of N: 1 to 5. This indicates that a maximum of five shared resources can be specified at a time.</para>
            /// <para>For more information about the types of resources that can be shared, see <a href="https://help.aliyun.com/document_detail/450526.html">Services that work with Resource Sharing</a>.</para>
            /// <remarks>
            /// <para> <c>Resources.N.ResourceId</c> and <c>Resources.N.ResourceType</c> must be used in pairs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>VSwitch</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The properties of the principal.</para>
        /// <remarks>
        /// <para> This parameter is available only when you specify an Alibaba Cloud service as a principal.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TargetProperties")]
        [Validation(Required=false)]
        public List<AssociateResourceShareRequestTargetProperties> TargetProperties { get; set; }
        public class AssociateResourceShareRequestTargetProperties : TeaModel {
            /// <summary>
            /// <para>The property parameter of the principal. For example, you can specify a parameter that indicates the time range for resource sharing. Valid values of <c>timeRangeType</c>:</para>
            /// <list type="bullet">
            /// <item><description>timeRange: a specific time range</description></item>
            /// <item><description>day: all day</description></item>
            /// </list>
            /// <remarks>
            /// <para> <c>TargetProperties.N.TargetId</c> and <c>TargetProperties.N.Property</c> must be used in pairs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;timeRange&quot;:{
            ///         &quot;timeRangeType&quot;:&quot;timeRange&quot;,
            ///         &quot;beginAtTime&quot;:&quot;00:00&quot;,
            ///         &quot;timezone&quot;:&quot;UTC+8&quot;,
            ///         &quot;endAtTime&quot;:&quot;19:59&quot;
            ///     }
            /// }</para>
            /// </summary>
            [NameInMap("Property")]
            [Validation(Required=false)]
            public string Property { get; set; }

            /// <summary>
            /// <para>The ID of the principal.</para>
            /// <remarks>
            /// <para> <c>TargetProperties.N.TargetId</c> and <c>TargetProperties.N.Property</c> must be used in pairs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>172050525300****</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

        }

        /// <summary>
        /// <para>The information about the principals.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172050525300****</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<string> Targets { get; set; }

    }

}
