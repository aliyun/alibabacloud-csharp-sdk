// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosEventSrcIpResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about attack source IP addresses.</para>
        /// </summary>
        [NameInMap("Ips")]
        [Validation(Required=false)]
        public List<DescribeDDosEventSrcIpResponseBodyIps> Ips { get; set; }
        public class DescribeDDosEventSrcIpResponseBodyIps : TeaModel {
            /// <summary>
            /// <para>The region code of the attack source. For more information, see <a href="https://help.aliyun.com/document_detail/167926.html">Region codes</a>. For example, <b>110000</b> indicates Beijing, China, and <b>us</b> indicates the United States.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110000</para>
            /// </summary>
            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            /// <summary>
            /// <para>The Internet service provider (ISP) of the attack source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>100017</b>: China Telecom</description></item>
            /// <item><description><b>100026</b>: China Unicom</description></item>
            /// <item><description><b>100025</b>: China Mobile</description></item>
            /// <item><description><b>100027</b>: CERNET</description></item>
            /// <item><description><b>100020</b>: China Tietong</description></item>
            /// <item><description><b>1000143</b>: Dr. Peng</description></item>
            /// <item><description><b>100080</b>: Gehua</description></item>
            /// <item><description><b>1000139</b>: China Broadcasting Network</description></item>
            /// <item><description><b>100023</b>: Wired</description></item>
            /// <item><description><b>100063</b>: Founder Broadband</description></item>
            /// <item><description><b>1000337</b>: Haonet</description></item>
            /// <item><description><b>100021</b>: 21Vianet</description></item>
            /// <item><description><b>1000333</b>: Wasu Media</description></item>
            /// <item><description><b>100093</b>: ChinaNetCenter</description></item>
            /// <item><description><b>1000401</b>: Tencent</description></item>
            /// <item><description><b>100099</b>: Baidu</description></item>
            /// <item><description><b>1000323</b>: Alibaba Cloud</description></item>
            /// <item><description><b>100098</b>: Alibaba</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>100026</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <para>The attack source IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>218.<em><b>.</b></em>.24</para>
            /// </summary>
            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38A0224E-FDBC-4733-A362-B391827FC1E9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
