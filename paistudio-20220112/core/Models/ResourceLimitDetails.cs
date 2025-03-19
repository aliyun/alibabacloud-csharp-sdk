// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ResourceLimitDetails : TeaModel {
        [NameInMap("GCLevel")]
        [Validation(Required=false)]
        public string GCLevel { get; set; }

        [NameInMap("ResourceLimit")]
        [Validation(Required=false)]
        public Dictionary<string, object> ResourceLimit { get; set; }

        [NameInMap("ShouldIgnoreResourceCheck")]
        [Validation(Required=false)]
        public bool? ShouldIgnoreResourceCheck { get; set; }

    }

}
