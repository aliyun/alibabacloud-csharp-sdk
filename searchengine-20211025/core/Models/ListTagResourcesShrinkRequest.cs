// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListTagResourcesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600********33</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The IDs of the resources. You can specify up to 50 resource IDs.</para>
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
        /// <para>A list of up to 20 tags to add.</para>
        /// </summary>
        [NameInMap("tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

    }

}
