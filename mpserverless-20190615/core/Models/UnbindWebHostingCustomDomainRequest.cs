// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class UnbindWebHostingCustomDomainRequest : TeaModel {
        [NameInMap("CustomDomain")]
        [Validation(Required=false)]
        public string CustomDomain { get; set; }

        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

    }

}
