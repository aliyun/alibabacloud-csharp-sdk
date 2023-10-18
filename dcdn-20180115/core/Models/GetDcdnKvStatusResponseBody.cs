// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class GetDcdnKvStatusResponseBody : TeaModel {
        [NameInMap("Complete")]
        [Validation(Required=false)]
        public bool? Complete { get; set; }

        [NameInMap("Expire")]
        [Validation(Required=false)]
        public string Expire { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
