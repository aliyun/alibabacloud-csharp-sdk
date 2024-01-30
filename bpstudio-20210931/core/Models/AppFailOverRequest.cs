// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class AppFailOverRequest : TeaModel {
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        [NameInMap("FailZone")]
        [Validation(Required=false)]
        public string FailZone { get; set; }

    }

}
