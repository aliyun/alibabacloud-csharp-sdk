// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchDeleteDcdnKvWithHighCapacityResponseBody : TeaModel {
        [NameInMap("FailKeys")]
        [Validation(Required=false)]
        public List<string> FailKeys { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessKeys")]
        [Validation(Required=false)]
        public List<string> SuccessKeys { get; set; }

    }

}
