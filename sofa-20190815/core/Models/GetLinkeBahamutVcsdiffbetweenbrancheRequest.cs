// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutVcsdiffbetweenbrancheRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("MrSourceBranch")]
        [Validation(Required=false)]
        public string MrSourceBranch { get; set; }

        [NameInMap("MrTargetBranch")]
        [Validation(Required=false)]
        public string MrTargetBranch { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
