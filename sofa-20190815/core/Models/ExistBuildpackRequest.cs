// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExistBuildpackRequest : TeaModel {
        [NameInMap("BuildpackId")]
        [Validation(Required=false)]
        public string BuildpackId { get; set; }

        [NameInMap("FullVersion")]
        [Validation(Required=false)]
        public string FullVersion { get; set; }

        [NameInMap("TechstackId")]
        [Validation(Required=false)]
        public long? TechstackId { get; set; }

    }

}
