// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebApplicationWithStatus : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public WebApplicationStatus Status { get; set; }

        [NameInMap("WebApplication")]
        [Validation(Required=false)]
        public WebApplication WebApplication { get; set; }

    }

}
