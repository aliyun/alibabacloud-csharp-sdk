// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class BindAuthToMachineResponseBody : TeaModel {
        [NameInMap("BindCount")]
        [Validation(Required=false)]
        public int? BindCount { get; set; }

        [NameInMap("InsufficientCoreCount")]
        [Validation(Required=false)]
        public int? InsufficientCoreCount { get; set; }

        [NameInMap("InsufficientCount")]
        [Validation(Required=false)]
        public int? InsufficientCount { get; set; }

        [NameInMap("InsufficientEcsCount")]
        [Validation(Required=false)]
        public int? InsufficientEcsCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public int? ResultCode { get; set; }

        [NameInMap("UnBindCount")]
        [Validation(Required=false)]
        public int? UnBindCount { get; set; }

    }

}
