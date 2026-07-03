// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListTagResourcesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The token that determines the start point of the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeb235b-xxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The resource ID. You can specify up to 50 subkeys.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;gw-xxx&quot;,&quot;gw-yyy&quot;]</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceIdShrink { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Gateway</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of labels to add. You can specify up to 20 subkeys.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;key&quot;:&quot;env&quot;,&quot;value&quot;:&quot;prod&quot;}]</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

    }

}
