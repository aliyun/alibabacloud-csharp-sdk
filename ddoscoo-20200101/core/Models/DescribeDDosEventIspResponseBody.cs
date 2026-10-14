// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosEventIspResponseBody : TeaModel {
        /// <summary>
        /// <para>The ISP information of attack sources.</para>
        /// </summary>
        [NameInMap("Isps")]
        [Validation(Required=false)]
        public List<DescribeDDosEventIspResponseBodyIsps> Isps { get; set; }
        public class DescribeDDosEventIspResponseBodyIsps : TeaModel {
            /// <summary>
            /// <para>The number of request packets from the ISP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>230</para>
            /// </summary>
            [NameInMap("InPkts")]
            [Validation(Required=false)]
            public long? InPkts { get; set; }

            /// <summary>
            /// <para>The code of the attack source ISP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>100017</b>: China Telecom</description></item>
            /// <item><description><b>100026</b>: China Unicom</description></item>
            /// <item><description><b>100025</b>: China Mobile</description></item>
            /// <item><description><b>100027</b>: CERNET</description></item>
            /// <item><description><b>100020</b>: China Tietong</description></item>
            /// <item><description><b>1000143</b>: Dr. Peng</description></item>
            /// <item><description><b>100080</b>: Gehua</description></item>
            /// <item><description><b>1000139</b>: China Broadcasting Network</description></item>
            /// <item><description><b>100023</b>: Youxiantong</description></item>
            /// <item><description><b>100063</b>: Founder Broadband</description></item>
            /// <item><description><b>1000337</b>: Haokuan Network</description></item>
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
            /// <para>1000323</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C4A3BCD1-4A32-4342-941A-4745AE69508C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
