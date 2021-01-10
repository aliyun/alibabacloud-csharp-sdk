// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CheckLinkeBahamutFabricconfigRequest : TeaModel {
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        [NameInMap("FromDevStage")]
        [Validation(Required=false)]
        public string FromDevStage { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("ReleaseId")]
        [Validation(Required=false)]
        public string ReleaseId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("ToDevStage")]
        [Validation(Required=false)]
        public string ToDevStage { get; set; }

    }

}
