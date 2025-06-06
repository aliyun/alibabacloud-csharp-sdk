// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListEnterpriseAccelerateLogsResponseBody : TeaModel {
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<ListEnterpriseAccelerateLogsResponseBodyLogs> Logs { get; set; }
        public class ListEnterpriseAccelerateLogsResponseBodyLogs : TeaModel {
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>windows</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.bing.com:443">www.bing.com:443</a></para>
            /// </summary>
            [NameInMap("DstAddr")]
            [Validation(Required=false)]
            public string DstAddr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12299</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public string InBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2603</para>
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public string OutBytes { get; set; }

            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8.222.179.xxx:10015</para>
            /// </summary>
            [NameInMap("ProxyAddr")]
            [Validation(Required=false)]
            public string ProxyAddr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1748422797</para>
            /// </summary>
            [NameInMap("UnixTime")]
            [Validation(Required=false)]
            public string UnixTime { get; set; }

            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>43F07A6A-294D-56FB-85EB-6AD00C5B60FF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("TotalNumber")]
        [Validation(Required=false)]
        public int? TotalNumber { get; set; }

    }

}
