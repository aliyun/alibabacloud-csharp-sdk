// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosEventSrcIpResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of information about the source IP address of the volumetric attack.</para>
        /// </summary>
        [NameInMap("Ips")]
        [Validation(Required=false)]
        public List<DescribeDDosEventSrcIpResponseBodyIps> Ips { get; set; }
        public class DescribeDDosEventSrcIpResponseBodyIps : TeaModel {
            /// <summary>
            /// <para>The code or ID of the source region. For more information, see <a href="https://help.aliyun.com/document_detail/167926.html">Codes of administrative regions in China and codes of countries and areas</a>. For example, <b>110000</b> indicates Beijing, China, and <b>us</b> indicates the United States.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110000</para>
            /// </summary>
            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            /// <summary>
            /// <para>The Internet service provider (ISP) for the volumetric attack. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>100017</b>: China Telecom</description></item>
            /// <item><description><b>100026</b>: China Unicom</description></item>
            /// <item><description><b>100025</b>: China Mobile</description></item>
            /// <item><description><b>100027</b>: China Education and Research Network</description></item>
            /// <item><description><b>100020</b>: China Mobile Tietong</description></item>
            /// <item><description><b>1000143</b>: Dr.Peng Telecom &amp; Media Group</description></item>
            /// <item><description><b>100080</b>: Beijing Gehua CATV Network</description></item>
            /// <item><description><b>1000139</b>: National Radio and Television Administration</description></item>
            /// <item><description><b>100023</b>: Oriental Cable Network</description></item>
            /// <item><description><b>100063</b>: Founder Broadband</description></item>
            /// <item><description><b>1000337</b>: China Internet Exchange</description></item>
            /// <item><description><b>100021</b>: 21Vianet Group</description></item>
            /// <item><description><b>1000333</b>: Wasu Media Holding</description></item>
            /// <item><description><b>100093</b>: Wangsu Science &amp; Technology</description></item>
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
            /// <para>The source IP address of the volumetric attack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>218.<em><b>.</b></em>.24</para>
            /// </summary>
            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38A0224E-FDBC-4733-A362-B391827FC1E9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
