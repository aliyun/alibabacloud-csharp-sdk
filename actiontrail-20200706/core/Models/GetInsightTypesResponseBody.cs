// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetInsightTypesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;ApiCallRateInsight\&quot;: \&quot;Enable\&quot;, \&quot;ApiErrorRateInsight\&quot;: \&quot;Enable\&quot;, \&quot;IpInsight\&quot;: \&quot;Enable\&quot;, \&quot;AkInsight\&quot;: \&quot;Enable\&quot;}</para>
        /// </summary>
        [NameInMap("InsightTypes")]
        [Validation(Required=false)]
        public Dictionary<string, object> InsightTypes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EC4A1F64-4927-5714-B205-5A0B16A2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
