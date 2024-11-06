// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainRealTimeDetailDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The information returned.</para>
        /// <remarks>
        /// <para>The value of this parameter is a JSON string. The following table describes the fields in Data.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///     {
        ///       &quot;time_stp&quot;: &quot;2018-06-05T20:00:00Z&quot;,
        ///       &quot;domain_name&quot;: &quot;example.com&quot;,
        ///       &quot;location&quot;: &quot;Guangdong&quot;,
        ///       &quot;isp&quot;: &quot;telecom&quot;,
        ///       &quot;qps&quot;: 10.0
        ///     },
        ///     {
        ///       &quot;time_stp&quot;: &quot;2018-06-05T20:00:00Z&quot;,
        ///       &quot;domain_name&quot;: &quot;example.com&quot;,
        ///       &quot;location&quot;: &quot;Jiangsu&quot;,
        ///       &quot;isp&quot;: &quot;unicom&quot;,
        ///       &quot;qps&quot;: 11.1
        ///     }
        ///   ]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A603F324-7A05-4FB3-ADF3-2563233D26CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
