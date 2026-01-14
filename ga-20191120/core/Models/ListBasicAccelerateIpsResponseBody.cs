// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListBasicAccelerateIpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The accelerated IP addresses of the basic GA instance.</para>
        /// </summary>
        [NameInMap("AccelerateIps")]
        [Validation(Required=false)]
        public List<ListBasicAccelerateIpsResponseBodyAccelerateIps> AccelerateIps { get; set; }
        public class ListBasicAccelerateIpsResponseBodyAccelerateIps : TeaModel {
            /// <summary>
            /// <para>The accelerated IP address of the basic GA instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>116.132.XX.XX</para>
            /// </summary>
            [NameInMap("AccelerateIpAddress")]
            [Validation(Required=false)]
            public string AccelerateIpAddress { get; set; }

            /// <summary>
            /// <para>The ID of the accelerated IP address of the basic GA instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gaip-bp1****</para>
            /// </summary>
            [NameInMap("AccelerateIpId")]
            [Validation(Required=false)]
            public string AccelerateIpId { get; set; }

            /// <summary>
            /// <para>The ID of the basic GA instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga-bp17frjjh0udz4qz****</para>
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// <para>The ID of the acceleration region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ips-bp11r5jb8ogp122xl****</para>
            /// </summary>
            [NameInMap("IpSetId")]
            [Validation(Required=false)]
            public string IpSetId { get; set; }

            /// <summary>
            /// <para>The status of the accelerated IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>active</b>: The accelerated IP address is available.</description></item>
            /// <item><description><b>binding</b>: The accelerated IP address is being associated.</description></item>
            /// <item><description><b>bound</b>: The accelerated IP address is associated.</description></item>
            /// <item><description><b>unbinding</b>: The accelerated IP address is being disassociated.</description></item>
            /// <item><description><b>deleting</b>: The accelerated IP address is being deleted.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is unavailable when the accelerated IP address is being created.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> was not returned, it indicates that no additional results exist.</description></item>
        /// <item><description>If <b>NextToken</b> was returned in the previous query, specify the value to obtain the next set of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
