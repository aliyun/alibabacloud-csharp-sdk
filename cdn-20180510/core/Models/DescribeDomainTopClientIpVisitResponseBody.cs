// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainTopClientIpVisitResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of client IP addresses.</para>
        /// </summary>
        [NameInMap("ClientIpList")]
        [Validation(Required=false)]
        public List<DescribeDomainTopClientIpVisitResponseBodyClientIpList> ClientIpList { get; set; }
        public class DescribeDomainTopClientIpVisitResponseBodyClientIpList : TeaModel {
            /// <summary>
            /// <para>The total number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>256</para>
            /// </summary>
            [NameInMap("Acc")]
            [Validation(Required=false)]
            public long? Acc { get; set; }

            /// <summary>
            /// <para>The client IP address returned. Only IPv4 addressed are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.xxx</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// <para>The ranking of the client IP address returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Rank")]
            [Validation(Required=false)]
            public int? Rank { get; set; }

            /// <summary>
            /// <para>The total amount of network traffic consumed. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Traffic")]
            [Validation(Required=false)]
            public long? Traffic { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64D28B53-5902-409B-94F6-FD46680144FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
