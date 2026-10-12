// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The token used to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeb235b-xxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The resource IDs. You can specify up to 50 resource IDs. You must specify at least one of ResourceId and Tag. If both are empty, the API returns InvalidParameter.BothEmpty(400).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;gw-xxx&quot;,&quot;gw-yyy&quot;]</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Note: Although the documentation indicates a default value of Gateway, you must explicitly specify this parameter when you call the API. Otherwise, the API returns InvalidParameter.UnsupportedTagResourceType(400). Valid values: Gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Gateway</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tags. You can specify up to 20 tags. You must specify at least one of ResourceId and Tag. If both are empty, the API returns InvalidParameter.BothEmpty(400).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;key&quot;:&quot;env&quot;,&quot;value&quot;:&quot;prod&quot;}]</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
