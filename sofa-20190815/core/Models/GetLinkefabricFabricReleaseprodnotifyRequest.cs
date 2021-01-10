// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkefabricFabricReleaseprodnotifyRequest : TeaModel {
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("ReleaseId")]
        [Validation(Required=false)]
        public string ReleaseId { get; set; }

        [NameInMap("ReleaseStatus")]
        [Validation(Required=false)]
        public string ReleaseStatus { get; set; }

        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

    }

}
