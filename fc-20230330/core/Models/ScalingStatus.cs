// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ScalingStatus : TeaModel {
        [NameInMap("currentError")]
        [Validation(Required=false)]
        public string CurrentError { get; set; }

        [NameInMap("resourceCount")]
        [Validation(Required=false)]
        public long? ResourceCount { get; set; }

    }

}
