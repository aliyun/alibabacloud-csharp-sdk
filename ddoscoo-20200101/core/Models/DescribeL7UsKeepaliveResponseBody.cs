// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeL7UsKeepaliveResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39499F01-19D9-4EA4-A0E9-C6014BA5CDHE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The configured back-to-origin persistent connection parameters.</para>
        /// </summary>
        [NameInMap("RsKeepalive")]
        [Validation(Required=false)]
        public DescribeL7UsKeepaliveResponseBodyRsKeepalive RsKeepalive { get; set; }
        public class DescribeL7UsKeepaliveResponseBodyRsKeepalive : TeaModel {
            [NameInMap("DsKeepaliveTimeout")]
            [Validation(Required=false)]
            public long? DsKeepaliveTimeout { get; set; }

            /// <summary>
            /// <para>Indicates whether back-to-origin persistent connections are enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The number of requests that can reuse a persistent connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("KeepaliveRequests")]
            [Validation(Required=false)]
            public long? KeepaliveRequests { get; set; }

            /// <summary>
            /// <para>The idle timeout period of a persistent connection.</para>
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
