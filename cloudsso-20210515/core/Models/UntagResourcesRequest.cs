// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove all tags. This parameter takes effect only when the list of tag keys is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

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
        /// <para>The resource type. Users and access configurations are supported.</para>
        /// <list type="bullet">
        /// <item><description><para>Set the value to user for users.</para>
        /// </description></item>
        /// <item><description><para>Set the value to accessConfiguration for access configurations.</para>
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
        /// <para>The list of tag keys. You can specify up to 20 tag keys in a single call.</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
