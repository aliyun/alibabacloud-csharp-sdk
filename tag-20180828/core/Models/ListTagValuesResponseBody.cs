// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListTagValuesResponseBody : TeaModel {
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
        /// <para>8989CA7E-D2E0-4B6D-8282-311106E80150</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of the tag values.</para>
        /// </summary>
        [NameInMap("Values")]
        [Validation(Required=false)]
        public ListTagValuesResponseBodyValues Values { get; set; }
        public class ListTagValuesResponseBodyValues : TeaModel {
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

    }

}
