// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyTaskInfoResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorTaskId")]
        [Validation(Required=false)]
        public string ErrorTaskId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public string SuccessCount { get; set; }

    }

}
