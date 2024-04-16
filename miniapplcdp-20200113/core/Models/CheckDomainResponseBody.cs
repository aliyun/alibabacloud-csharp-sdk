// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class CheckDomainResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CheckDomainResponseBodyData Data { get; set; }
        public class CheckDomainResponseBodyData : TeaModel {
            [NameInMap("Valid")]
            [Validation(Required=false)]
            public bool? Valid { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
