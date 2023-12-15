// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class CheckPointStructBody : TeaModel {
        [NameInMap("ErrorCount")]
        [Validation(Required=false)]
        public string ErrorCount { get; set; }

        [NameInMap("Height")]
        [Validation(Required=false)]
        public string Height { get; set; }

        [NameInMap("Index")]
        [Validation(Required=false)]
        public string Index { get; set; }

        [NameInMap("LastError")]
        [Validation(Required=false)]
        public string LastError { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
