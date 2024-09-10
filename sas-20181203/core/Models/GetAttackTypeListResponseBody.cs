// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAttackTypeListResponseBody : TeaModel {
        [NameInMap("AttackTypeList")]
        [Validation(Required=false)]
        public List<GetAttackTypeListResponseBodyAttackTypeList> AttackTypeList { get; set; }
        public class GetAttackTypeListResponseBodyAttackTypeList : TeaModel {
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("Status_Type")]
            [Validation(Required=false)]
            public string StatusType { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
