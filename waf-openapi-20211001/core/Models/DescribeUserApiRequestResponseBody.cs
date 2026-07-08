// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeUserApiRequestResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D13E4540-4432-5AD7-B216-6369512514F4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of statistics.</para>
        /// </summary>
        [NameInMap("Requests")]
        [Validation(Required=false)]
        public List<DescribeUserApiRequestResponseBodyRequests> Requests { get; set; }
        public class DescribeUserApiRequestResponseBodyRequests : TeaModel {
            /// <summary>
            /// <para>The number of statistics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>76</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The statistics information. This includes:</para>
            /// <list type="bullet">
            /// <item><description><para><b>client_list</b>: the client tool.</para>
            /// </description></item>
            /// <item><description><para><b>ip</b>: the IP address information.</para>
            /// </description></item>
            /// <item><description><para><b>region_id</b>: the region.</para>
            /// </description></item>
            /// <item><description><para><b>country_id</b>: the country.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;client_list&quot;: [
            ///         &quot;Unknown&quot;
            ///     ],
            ///     &quot;ip&quot;: &quot;47.92.113.***&quot;,
            ///     &quot;region_id&quot;: &quot;110000&quot;,
            ///     &quot;country_id&quot;: &quot;CN&quot;
            /// }</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
