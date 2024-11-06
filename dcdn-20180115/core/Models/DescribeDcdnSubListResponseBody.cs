// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnSubListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the custom report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;data&quot;: [{&quot;subId&quot;: 336,&quot;reportId&quot;: [6,8],&quot;createTime&quot;: &quot;2021-07-05T06:18:46Z&quot;,&quot;domains&quot;: [&quot;example.com&quot;],&quot;effectiveFrom&quot;: &quot;2021-07-05T06:18:46Z&quot;,&quot;effectiveEnd&quot;: &quot;2021-10-05T06:18:46Z&quot;,&quot;status&quot;: &quot;enable&quot;}]</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3250A51D-C11D-46BA-B6B3-95348EEDE652</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
