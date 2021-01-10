// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkefabricFabricAllzonebydevstageenvRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("DevStage")]
        [Validation(Required=false)]
        public string DevStage { get; set; }

        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        [NameInMap("EnvId")]
        [Validation(Required=false)]
        public long? EnvId { get; set; }

        [NameInMap("IsStandard")]
        [Validation(Required=false)]
        public bool? IsStandard { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

    }

}
