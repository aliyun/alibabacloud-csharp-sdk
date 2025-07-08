// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class BatchDeleteTaskNewResponseBody : TeaModel {
        [NameInMap("FailList")]
        [Validation(Required=false)]
        public List<string> FailList { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessList")]
        [Validation(Required=false)]
        public List<string> SuccessList { get; set; }

    }

}
