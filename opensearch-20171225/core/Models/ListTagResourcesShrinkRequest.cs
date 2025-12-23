// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListTagResourcesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The token that is used to retrieve the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The resource IDs. You can specify a maximum number of 50 resource IDs.</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceIdShrink { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BIGDATA</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags. You can specify a maximum number of 20 tags.</para>
        /// </summary>
        [NameInMap("tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

    }

}
