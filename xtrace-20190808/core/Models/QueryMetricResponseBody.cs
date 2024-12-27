// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class QueryMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned statistics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{   &quot;RequestId&quot;: &quot;E2373982-D8CD-413D-B991-8EB678******&quot;,   &quot;Data&quot;: &quot;{\&quot;data\&quot;:[{\&quot;date\&quot;:1583686800000,\&quot;count\&quot;:0,\&quot;rt\&quot;:0,\&quot;rpc\&quot;:\&quot;childSpan3\&quot;}}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1E2B6A4C-6B83-4062-8B6F-AEEC1F******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
