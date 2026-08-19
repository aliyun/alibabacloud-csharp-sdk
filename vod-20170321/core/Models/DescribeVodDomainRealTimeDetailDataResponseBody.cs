// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainRealTimeDetailDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data details. The data is returned as a JSON string. The following table describes the structure and fields:</para>
        /// <remarks>
        /// <para>If no data exists for a field, the field is not returned.</para>
        /// </remarks>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Field</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>domain_name</td>
        /// <td>String</td>
        /// <td>The accelerated domain name.</td>
        /// </tr>
        /// <tr>
        /// <td>isp</td>
        /// <td>String</td>
        /// <td>The ISP name.</td>
        /// </tr>
        /// <tr>
        /// <td>location</td>
        /// <td>String</td>
        /// <td>The region name.</td>
        /// </tr>
        /// <tr>
        /// <td>qps</td>
        /// <td>Long</td>
        /// <td>The queries per second (QPS).</td>
        /// </tr>
        /// <tr>
        /// <td>bps</td>
        /// <td>Long</td>
        /// <td>The bandwidth data. Unit: bit/s.</td>
        /// </tr>
        /// <tr>
        /// <td>http_code</td>
        /// <td>Map</td>
        /// <td>The HTTP status code details. The key is the status code name, and the value is the count of the status code.</td>
        /// </tr>
        /// <tr>
        /// <td>time_stp</td>
        /// <td>String</td>
        /// <td>The data timestamp. The time is in the ISO 8601 standard in UTC.</td>
        /// </tr>
        /// </tbody></table>
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
        /// <para>1710298E-8AFA-5F6D-A3E9-47103C52177D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
