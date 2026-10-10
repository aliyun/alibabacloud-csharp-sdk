// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove all tags from the resources. This parameter and TagKey are mutually exclusive.</para>
        /// </summary>
        [NameInMap("all")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The list of data catalog IDs from which to remove tags. The value is a JSON array. Maximum: 50.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;clg-paimon-0424965be0c240acb4159688c9e2c4b6&quot;]</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid value: CATALOGRESOURCE.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CATALOGRESOURCE</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tag keys to remove. The value is a JSON array. This parameter and All are mutually exclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;team&quot;]</para>
        /// </summary>
        [NameInMap("tagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
