// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainTopAttackListResponseBody : TeaModel {
        /// <summary>
        /// The peak QPS of the website.
        /// </summary>
        [NameInMap("AttackList")]
        [Validation(Required=false)]
        public List<DescribeDomainTopAttackListResponseBodyAttackList> AttackList { get; set; }
        public class DescribeDomainTopAttackListResponseBodyAttackList : TeaModel {
            /// <summary>
            /// The attack QPS. Unit: QPS
            /// </summary>
            [NameInMap("Attack")]
            [Validation(Required=false)]
            public long? Attack { get; set; }

            /// <summary>
            /// The number of all QPS, which includes normal and attack QPS. Unit: QPS.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The domain name of the website.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
