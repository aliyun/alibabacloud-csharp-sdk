// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeL7UsKeepaliveResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39499F01-19D9-4EA4-A0E9-C6014BA5CDBE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The value of the Back-to-origin Persistent Connections parameter.</para>
        /// </summary>
        [NameInMap("RsKeepalive")]
        [Validation(Required=false)]
        public DescribeL7UsKeepaliveResponseBodyRsKeepalive RsKeepalive { get; set; }
        public class DescribeL7UsKeepaliveResponseBodyRsKeepalive : TeaModel {
            [NameInMap("DsKeepaliveTimeout")]
            [Validation(Required=false)]
            public long? DsKeepaliveTimeout { get; set; }

            /// <summary>
            /// <para>Indicates whether Back-to-origin Persistent Connections is turned on. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The number of requests that reuse persistent connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("KeepaliveRequests")]
            [Validation(Required=false)]
            public long? KeepaliveRequests { get; set; }

            /// <summary>
            /// <para>The timeout period of idle persistent connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("KeepaliveTimeout")]
            [Validation(Required=false)]
            public long? KeepaliveTimeout { get; set; }

        }

    }

}
