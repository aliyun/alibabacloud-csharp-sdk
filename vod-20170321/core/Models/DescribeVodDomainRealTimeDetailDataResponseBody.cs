// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainRealTimeDetailDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned results.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710298E-8AFA-5F6D-A3E9-47103C52177D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
