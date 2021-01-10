// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkefabricFabricExistdrmresourcetplRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("DevStage")]
        [Validation(Required=false)]
        public string DevStage { get; set; }

        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        [NameInMap("IsStandard")]
        [Validation(Required=false)]
        public string IsStandard { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
