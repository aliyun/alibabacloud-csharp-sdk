// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ApplicationStatus : TeaModel {
        [NameInMap("instanceCount")]
        [Validation(Required=false)]
        public long? InstanceCount { get; set; }

        [NameInMap("scaleConfig")]
        [Validation(Required=false)]
        public ScaleConfig ScaleConfig { get; set; }

    }

}
