// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortCcAttackTopIPResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24F36D81-5E2D-52E5-9DB6-A3ED23CF271A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The top IP addresses from which most attacks are initiated.</para>
        /// </summary>
        [NameInMap("TopIp")]
        [Validation(Required=false)]
        public List<DescribePortCcAttackTopIPResponseBodyTopIp> TopIp { get; set; }
        public class DescribePortCcAttackTopIPResponseBodyTopIp : TeaModel {
            /// <summary>
            /// <para>The code of the location from which the attack is initiated. For more information, see <a href="https://help.aliyun.com/document_detail/167926.html">Codes of administrative regions in China and codes of countries and areas</a>. For example, <b>110000</b> indicates Beijing, China, and <b>us</b> indicates the United States.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            /// <summary>
            /// <para>The number of attacks from the IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33971</para>
            /// </summary>
            [NameInMap("Pv")]
            [Validation(Required=false)]
            public long? Pv { get; set; }

            /// <summary>
            /// <para>The source IP address of the attack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.18.XX.XX</para>
            /// </summary>
            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

        }

    }

}
