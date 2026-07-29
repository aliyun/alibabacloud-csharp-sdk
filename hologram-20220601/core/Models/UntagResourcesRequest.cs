// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>An array of instance IDs.</para>
        /// </summary>
        [NameInMap("resourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCe</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>An array of tag keys. To remove tags, you only need to provide the corresponding tag keys.</para>
        /// </summary>
        [NameInMap("tagKeys")]
        [Validation(Required=false)]
        public List<string> TagKeys { get; set; }

        /// <summary>
        /// <para>The account ID of the tag owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1062017779051424</para>
        /// </summary>
        [NameInMap("tagOwnerUid")]
        [Validation(Required=false)]
        public long? TagOwnerUid { get; set; }

    }

}
