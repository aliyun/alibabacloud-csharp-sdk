// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class LoggingEnabled : TeaModel {
        [NameInMap("TargetBucket")]
        [Validation(Required=false)]
        public string TargetBucket { get; set; }

        [NameInMap("TargetPrefix")]
        [Validation(Required=false)]
        public string TargetPrefix { get; set; }

    }

}
