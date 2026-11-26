// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The list of resource IDs. You can specify up to 50 resource IDs in a single call.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Supported resource types include users and access configurations:</description></item>
        /// <item><description><list type="bullet">
        /// <item><description>If the resource type is user, specify the user ID.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>If the resource type is access configuration, specify the access configuration ID.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para><notice>If the DirectoryId parameter is not specified, you must add the prefix &quot;${DirectoryId}_&quot; to the resource ID.</notice></para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>user: User.</para>
        /// </description></item>
        /// <item><description><para>accessConfiguration: Access configuration.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tags. You can add up to 20 tags in a single call.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><list type="bullet">
            /// <item><description>The tag key cannot start with aliyun or acs: in any case.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>The tag key cannot contain http:// or https:// in any case.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>The tag key cannot be an empty string.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><list type="bullet">
            /// <item><description>The tag value cannot contain http:// or https:// in any case.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>The tag value cannot be an empty string.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
