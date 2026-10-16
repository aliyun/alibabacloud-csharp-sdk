// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListTagKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether a next query token is available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If NextToken is empty, that is, <c>&quot;NextToken&quot;: &quot;&quot;</c>, no additional results exist.</description></item>
        /// <item><description>If NextToken has a value, the value is the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cm****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC09A6AA-2713-4E10-A2E9-E6C5C43A8842</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The tag key information.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListTagKeysResponseBodyTags> Tags { get; set; }
        public class ListTagKeysResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>team</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

        }

    }

}
