// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebApplicationWithInstanceCount : TeaModel {
        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public long? InstanceCount { get; set; }

        [NameInMap("WebApplication")]
        [Validation(Required=false)]
        public WebApplication WebApplication { get; set; }

    }

}
