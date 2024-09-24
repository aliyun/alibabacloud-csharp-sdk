// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeDomainResolveResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details about the DNS record of the domain name.</para>
        /// </summary>
        [NameInMap("ResolveResult")]
        [Validation(Required=false)]
        public DescribeDomainResolveResponseBodyResolveResult ResolveResult { get; set; }
        public class DescribeDomainResolveResponseBodyResolveResult : TeaModel {
            /// <summary>
            /// <para>The IP address to which the domain name is resolved. Multiple IP addresses are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>11.1.X.X,12.1.X.X</para>
            /// </summary>
            [NameInMap("IpAddrs")]
            [Validation(Required=false)]
            public string IpAddrs { get; set; }

            /// <summary>
            /// <para>The time when the domain name was resolved. The value of this parameter is a timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1579091739</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

    }

}
