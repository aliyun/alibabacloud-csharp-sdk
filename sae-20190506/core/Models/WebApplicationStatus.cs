// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebApplicationStatus : TeaModel {
        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public long? InstanceCount { get; set; }

        [NameInMap("WebScalingConfig")]
        [Validation(Required=false)]
        public WebScalingConfig WebScalingConfig { get; set; }

    }

}
