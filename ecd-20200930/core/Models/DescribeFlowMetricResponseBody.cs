// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeFlowMetricResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;instanceId\&quot;: \&quot;np-4wrye3ishxi47****\&quot;, \&quot;requestId\&quot;: \&quot;4F0CD5B6-70D6-5115-A2F7-7EAC3981****\&quot;, \&quot;dataPoints\&quot;: [{\&quot;timeStamp\&quot;: 1636510320000, \&quot;Average\&quot;: 293752.0}]}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6857EDCB-631F-5405-BE95-45CBB4C3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
