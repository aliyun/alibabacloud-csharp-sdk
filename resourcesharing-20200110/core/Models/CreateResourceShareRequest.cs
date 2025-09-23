// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class CreateResourceShareRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether resources in the resource share can be shared with accounts outside the resource directory. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): Resources in the resource share can be shared only with accounts in the resource directory.</description></item>
        /// <item><description>true: Resources in the resource share can be shared with both accounts in the resource directory and accounts outside the resource directory.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowExternalTargets")]
        [Validation(Required=false)]
        public bool? AllowExternalTargets { get; set; }

        /// <summary>
        /// <para>The information about the permissions. If you do not configure this parameter, the system automatically associates the default permission for the specified resource type with the resource share. For more information, see <a href="https://help.aliyun.com/document_detail/465474.html">Permission library</a>.</para>
        /// </summary>
        [NameInMap("PermissionNames")]
        [Validation(Required=false)]
        public List<string> PermissionNames { get; set; }

        [NameInMap("ResourceArns")]
        [Validation(Required=false)]
        public List<string> ResourceArns { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekz5nlvlak****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the resource share.</para>
        /// <para>The name must be 1 to 50 characters in length.</para>
        /// <para>The name can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ResourceShareName")]
        [Validation(Required=false)]
        public string ResourceShareName { get; set; }

        /// <summary>
        /// <para>The information about the shared resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<CreateResourceShareRequestResources> Resources { get; set; }
        public class CreateResourceShareRequestResources : TeaModel {
            /// <summary>
            /// <para>The ID of a shared resource.</para>
            /// <para>Valid values of N: 1 to 5. This indicates that a maximum of five shared resources can be specified at a time.</para>
            /// <remarks>
            /// <para> <c>Resources.N.ResourceId</c> and <c>Resources.N.ResourceType</c> must be used in pairs.</para>
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
        /// <para>The tags. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateResourceShareRequestTag> Tag { get; set; }
        public class CreateResourceShareRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <remarks>
            /// <para> The tag key can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. The tag key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <remarks>
            /// <para> The tag value can be up to 128 characters in length and cannot start with <c>acs:</c>. The tag value cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The properties of the principal.</para>
        /// <remarks>
        /// <para> This parameter is available only when you specify an Alibaba Cloud service as a principal.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TargetProperties")]
        [Validation(Required=false)]
        public List<CreateResourceShareRequestTargetProperties> TargetProperties { get; set; }
        public class CreateResourceShareRequestTargetProperties : TeaModel {
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
