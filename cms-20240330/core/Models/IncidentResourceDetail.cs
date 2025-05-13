// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentResourceDetail : TeaModel {
        [NameInMap("extraId")]
        [Validation(Required=false)]
        public string ExtraId { get; set; }

        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public Dictionary<string, object> ResourceId { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
