// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListTagKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>The information of the tag keys.</para>
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public ListTagKeysResponseBodyKeys Keys { get; set; }
        public class ListTagKeysResponseBodyKeys : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public List<ListTagKeysResponseBodyKeysKey> Key { get; set; }
            public class ListTagKeysResponseBodyKeysKey : TeaModel {
                /// <summary>
                /// <para>The type of the resource tag. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>custom</description></item>
                /// <item><description>system</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>custom</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The description of the tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Business team</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

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

        /// <summary>
        /// <para>Indicates whether the next query is required. The value of this parameter may be empty.</para>
        /// <list type="bullet">
        /// <item><description>If the value of this parameter is empty (<c>&quot;NextToken&quot;: &quot;&quot;</c>), all results are returned, and the next query is not required.</description></item>
        /// <item><description>If the value of this parameter is not empty, the next query is required, and the value is the token used to start the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC09A6AA-2713-4E10-A2E9-E6C5C43A8842</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
