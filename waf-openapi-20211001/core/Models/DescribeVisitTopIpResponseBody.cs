// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeVisitTopIpResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5D2B8DAE-A761-58CB-A68D-74989E4831DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The array of the top 10 IP addresses from which requests are sent.</para>
        /// </summary>
        [NameInMap("TopIp")]
        [Validation(Required=false)]
        public List<DescribeVisitTopIpResponseBodyTopIp> TopIp { get; set; }
        public class DescribeVisitTopIpResponseBodyTopIp : TeaModel {
            /// <summary>
            /// <para>The ordinal number of the area to which the IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>310000</para>
            /// </summary>
            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            /// <summary>
            /// <para>The total number of requests that are sent from the IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2622</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The ISP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AAA</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

        }

    }

}
