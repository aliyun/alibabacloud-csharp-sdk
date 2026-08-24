// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListTagResourcesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The token for the next query start position.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeb235b-xxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The resource ID. Up to 50 subkeys are supported. At least one of ResourceId and Tag must be provided. If both are empty, the API returns InvalidParameter.BothEmpty (400).</para>
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
        /// <para>The label list. Up to 20 subkeys are supported. At least one of ResourceId and Tag must be provided. If both are empty, the API returns InvalidParameter.BothEmpty (400).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;key&quot;:&quot;env&quot;,&quot;value&quot;:&quot;prod&quot;}]</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

    }

}
