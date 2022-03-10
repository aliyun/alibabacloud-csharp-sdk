// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateDataLevelPermissionStatusRequest : TeaModel {
        [NameInMap("CubeId")]
        [Validation(Required=false)]
        public string CubeId { get; set; }

        [NameInMap("IsOpen")]
        [Validation(Required=false)]
        public int? IsOpen { get; set; }

        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

    }

}
