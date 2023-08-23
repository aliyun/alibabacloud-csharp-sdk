// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class PrecheckForConsolidatedBillingAccountResponseBody : TeaModel {
        [NameInMap("Reasons")]
        [Validation(Required=false)]
        public List<PrecheckForConsolidatedBillingAccountResponseBodyReasons> Reasons { get; set; }
        public class PrecheckForConsolidatedBillingAccountResponseBodyReasons : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

    }

}
