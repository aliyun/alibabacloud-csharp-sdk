// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetDomainDnsChallengeResponseBody : TeaModel {
        [NameInMap("DomainDnsChallenge")]
        [Validation(Required=false)]
        public GetDomainDnsChallengeResponseBodyDomainDnsChallenge DomainDnsChallenge { get; set; }
        public class GetDomainDnsChallengeResponseBodyDomainDnsChallenge : TeaModel {
            /// <summary>
            /// DNS challenge名称。
            /// </summary>
            [NameInMap("DnsChallengeName")]
            [Validation(Required=false)]
            public string DnsChallengeName { get; set; }

            /// <summary>
            /// DNS challenge值。
            /// </summary>
            [NameInMap("DnsChallengeValue")]
            [Validation(Required=false)]
            public string DnsChallengeValue { get; set; }

            /// <summary>
            /// DNS记录类型。
            /// </summary>
            [NameInMap("DnsType")]
            [Validation(Required=false)]
            public string DnsType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
