// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainTopAttackListResponseBody : TeaModel {
        [NameInMap("AttackList")]
        [Validation(Required=false)]
        public List<DescribeDomainTopAttackListResponseBodyAttackList> AttackList { get; set; }
        public class DescribeDomainTopAttackListResponseBodyAttackList : TeaModel {
            [NameInMap("Attack")]
            [Validation(Required=false)]
            public long? Attack { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
