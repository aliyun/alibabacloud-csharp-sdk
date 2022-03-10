// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class SetDataLevelPermissionExtraConfigRequest : TeaModel {
        [NameInMap("CubeId")]
        [Validation(Required=false)]
        public string CubeId { get; set; }

        [NameInMap("MissHitPolicy")]
        [Validation(Required=false)]
        public string MissHitPolicy { get; set; }

        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

    }

}
