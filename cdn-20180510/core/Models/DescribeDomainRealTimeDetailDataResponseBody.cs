// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainRealTimeDetailDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The monitoring data of each ISP in each region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///       {
        ///             &quot;time_stp&quot;: &quot;2018-06-05T20:00:00Z&quot;,
        ///             &quot;domain_name&quot;: &quot;example.com&quot;,
        ///             &quot;location&quot;: &quot;Guangdong&quot;,
        ///             &quot;isp&quot;: &quot;telecom&quot;,
        ///             &quot;qps&quot;: 10
        ///       },
        ///       {
        ///             &quot;time_stp&quot;: &quot;2018-06-05T20:00:00Z&quot;,
        ///             &quot;domain_name&quot;: &quot;example.com&quot;,
        ///             &quot;location&quot;: &quot;Jiangsu&quot;,
        ///             &quot;isp&quot;: &quot;unicom&quot;,
        ///             &quot;qps&quot;: 11.1
        ///       }
        /// ]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B49E6DDA-F413-422B-B58E-2FA23F286726</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
