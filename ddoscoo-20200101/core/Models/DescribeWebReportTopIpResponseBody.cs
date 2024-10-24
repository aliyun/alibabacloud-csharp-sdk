// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebReportTopIpResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeWebReportTopIpResponseBodyDataList> DataList { get; set; }
        public class DescribeWebReportTopIpResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The ID of the location.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90998690</para>
            /// </summary>
            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            /// <summary>
            /// <para>The number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The Internet service provider (ISP) for the attack. Valid values:</para>
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
            /// <para>100017</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <para>The source IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>117.186.XX.XX</para>
            /// </summary>
            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D21BE0C4-8E83-5E32-86C6-AA6BE9B1B5BD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
