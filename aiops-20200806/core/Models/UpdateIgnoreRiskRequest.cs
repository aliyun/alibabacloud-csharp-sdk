// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class UpdateIgnoreRiskRequest : TeaModel {
        [NameInMap("PatrolDetailIds")]
        [Validation(Required=false)]
        public string PatrolDetailIds { get; set; }

        [NameInMap("PatrolId")]
        [Validation(Required=false)]
        public long? PatrolId { get; set; }

        [NameInMap("SwitchFrontOperaUid")]
        [Validation(Required=false)]
        public string SwitchFrontOperaUid { get; set; }

    }

}
