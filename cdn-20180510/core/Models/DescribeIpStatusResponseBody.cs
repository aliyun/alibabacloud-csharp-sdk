// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeIpStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the IP addresses of the POPs.</para>
        /// </summary>
        [NameInMap("IpStatus")]
        [Validation(Required=false)]
        public List<DescribeIpStatusResponseBodyIpStatus> IpStatus { get; set; }
        public class DescribeIpStatusResponseBodyIpStatus : TeaModel {
            /// <summary>
            /// <para>The IP address of the POP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.10.10</para>
            /// </summary>
            [NameInMap("ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// <list type="bullet">
            /// <item><description><b>nonali</b>: not an Alibaba Cloud CDN POP</description></item>
            /// <item><description><b>normal</b>: an available Alibaba Cloud CDN POP</description></item>
            /// <item><description><b>abnormal</b>: an unavailable Alibaba Cloud CDN POP</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>abnormal</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F61CDR30-E83C-4FDA-BF73-9A94CDD44229</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
