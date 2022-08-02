// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class IndexDocument : TeaModel {
        [NameInMap("Suffix")]
        [Validation(Required=false)]
        public string Suffix { get; set; }

        [NameInMap("SupportSubDir")]
        [Validation(Required=false)]
        public bool? SupportSubDir { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
