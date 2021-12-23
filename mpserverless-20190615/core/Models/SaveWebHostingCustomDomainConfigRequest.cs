// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class SaveWebHostingCustomDomainConfigRequest : TeaModel {
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("ForceRedirectType")]
        [Validation(Required=false)]
        public string ForceRedirectType { get; set; }

        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

    }

}
