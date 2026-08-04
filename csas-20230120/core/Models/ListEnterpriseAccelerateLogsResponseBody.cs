// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListEnterpriseAccelerateLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>List of logs.</para>
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<ListEnterpriseAccelerateLogsResponseBodyLogs> Logs { get; set; }
        public class ListEnterpriseAccelerateLogsResponseBodyLogs : TeaModel {
            /// <summary>
            /// <para>Department.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试部</para>
            /// </summary>
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            /// <summary>
            /// <para>Device type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>windows</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <para>Destination endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.bing.com:443">www.bing.com:443</a></para>
            /// </summary>
            [NameInMap("DstAddr")]
            [Validation(Required=false)]
            public string DstAddr { get; set; }

            /// <summary>
            /// <para>Inbound traffic, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12299</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public string InBytes { get; set; }

            /// <summary>
            /// <para>Outbound traffic, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2603</para>
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public string OutBytes { get; set; }

            /// <summary>
            /// <para>Enterprise acceleration policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>白名单加速</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>Enterprise acceleration instance address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.222.179.xxx:10015</para>
            /// </summary>
            [NameInMap("ProxyAddr")]
            [Validation(Required=false)]
            public string ProxyAddr { get; set; }

            /// <summary>
            /// <para>Time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1748422797</para>
            /// </summary>
            [NameInMap("UnixTime")]
            [Validation(Required=false)]
            public string UnixTime { get; set; }

            /// <summary>
            /// <para>Username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43F07A6A-294D-56FB-85EB-6AD00C5B60FF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("TotalNumber")]
        [Validation(Required=false)]
        public int? TotalNumber { get; set; }

    }

}
