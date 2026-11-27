// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to unbind all tags from the target file system.</para>
        /// <para>This parameter takes effect when TagKey.N is empty.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Unbinds all tags from the target file system. If a file system has no tags, no processing is performed and success is returned directly.</description></item>
        /// <item><description>false (default): Does not perform the operation and returns success directly.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The list of resource IDs.</para>
        /// <para>The ID of the target resource. Valid values of N: 1 to 50.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03e08484f0</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>filesystem: file system.</description></item>
        /// <item><description>accesspoint: access point.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>filesystem</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tag keys of the resource. You can enter up to 20 tag keys.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nastest</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
