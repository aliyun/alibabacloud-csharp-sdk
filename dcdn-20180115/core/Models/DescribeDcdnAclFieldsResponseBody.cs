// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnAclFieldsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the rules.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeDcdnAclFieldsResponseBodyContent> Content { get; set; }
        public class DescribeDcdnAclFieldsResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The rules and policies that were configured. The JSON string is decoded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>\&quot;fieldList\&quot;:[{\&quot;name\&quot;:\&quot;alert\&quot;,\&quot;display\&quot;:\&quot;observe\&quot;,\&quot;tip\&quot;:\&quot;mark the request in the log without blocking it\&quot;},{\&quot;name\&quot;:\&quot;bypass\&quot;,\&quot;display\&quot;:\&quot;bypass\&quot;,\&quot;tip\&quot;:\&quot;bypass security modules\&quot;}],\&quot;module\&quot;:[{\&quot;name\&quot;:\&quot;cc\&quot;,\&quot;display\&quot;:\&quot;Rate Limit\&quot;,\&quot;tip\&quot;:\&quot;bypass Rate Limit\&quot;},{\&quot;name\&quot;:\&quot;bot\&quot;,\&quot;display\&quot;:\&quot;Bot Traffic Management\&quot;,\&quot;tip\&quot;:\&quot;bypass Bot Manager\&quot;}]</para>
            /// </summary>
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public string Fields { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30A3A25A-86B3-4C1D-BAA8-12B8607A5CFD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
