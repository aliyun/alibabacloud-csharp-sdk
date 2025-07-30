// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetDomainDnsChallengeResponseBody : TeaModel {
        /// <summary>
        /// <para>The DNS challenge records.</para>
        /// </summary>
        [NameInMap("DomainDnsChallenge")]
        [Validation(Required=false)]
        public GetDomainDnsChallengeResponseBodyDomainDnsChallenge DomainDnsChallenge { get; set; }
        public class GetDomainDnsChallengeResponseBodyDomainDnsChallenge : TeaModel {
            /// <summary>
            /// <para>The name of the DNS challenge record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_idaas-challenge.${domain}</para>
            /// </summary>
            [NameInMap("DnsChallengeName")]
            [Validation(Required=false)]
            public string DnsChallengeName { get; set; }

            /// <summary>
            /// <para>The value of the DNS challenge record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exmple123xxx</para>
            /// </summary>
            [NameInMap("DnsChallengeValue")]
            [Validation(Required=false)]
            public string DnsChallengeValue { get; set; }

            /// <summary>
            /// <para>The type of the DNS challenge record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>txt</para>
            /// </summary>
            [NameInMap("DnsType")]
            [Validation(Required=false)]
            public string DnsType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
