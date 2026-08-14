// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosEventAttackTypeResponseBody : TeaModel {
        [NameInMap("AttackTypes")]
        [Validation(Required=false)]
        public List<DescribeDDosEventAttackTypeResponseBodyAttackTypes> AttackTypes { get; set; }
        public class DescribeDDosEventAttackTypeResponseBodyAttackTypes : TeaModel {
            [NameInMap("AttackType")]
            [Validation(Required=false)]
            public string AttackType { get; set; }

            [NameInMap("InPkts")]
            [Validation(Required=false)]
            public long? InPkts { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
