// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateGreyTagRouteRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DubboRules")]
        [Validation(Required=false)]
        public string DubboRules { get; set; }

        [NameInMap("GreyTagRouteId")]
        [Validation(Required=false)]
        public long? GreyTagRouteId { get; set; }

        [NameInMap("ScRules")]
        [Validation(Required=false)]
        public string ScRules { get; set; }

    }

}
