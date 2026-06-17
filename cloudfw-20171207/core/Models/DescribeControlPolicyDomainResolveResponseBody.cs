// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeControlPolicyDomainResolveResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F0F82705-CFC7-5F83-86C8-A063892F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The domain resolution results.</para>
        /// </summary>
        [NameInMap("ResolveResult")]
        [Validation(Required=false)]
        public List<DescribeControlPolicyDomainResolveResponseBodyResolveResult> ResolveResult { get; set; }
        public class DescribeControlPolicyDomainResolveResponseBodyResolveResult : TeaModel {
            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The list of ip addresses.</para>
            /// </summary>
            [NameInMap("IpAddrList")]
            [Validation(Required=false)]
            public List<string> IpAddrList { get; set; }

            /// <summary>
            /// <para>The supported ip version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public int? IpVersion { get; set; }

            /// <summary>
            /// <para>The update time, provided as a unix timestamp in seconds.</para>
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
