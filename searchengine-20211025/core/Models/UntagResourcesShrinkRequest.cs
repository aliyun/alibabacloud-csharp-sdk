// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class UntagResourcesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove all tags. This parameter is valid only when the \<c>tagKey\\</c> parameter is empty. Valid values: \<c>true\\</c> and \<c>false\\</c>. The default value is \<c>false\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("all")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The IDs of the resources. You can specify up to 50 resource IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceIdShrink { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tag keys. You can include up to 20 tag keys.</para>
        /// </summary>
        [NameInMap("tagKey")]
        [Validation(Required=false)]
        public string TagKeyShrink { get; set; }

    }

}
