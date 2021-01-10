// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CheckLinkeBahamutIterationunitnextstagecheckRequest : TeaModel {
        [NameInMap("FromStageId")]
        [Validation(Required=false)]
        public string FromStageId { get; set; }

        [NameInMap("IterationUnitId")]
        [Validation(Required=false)]
        public string IterationUnitId { get; set; }

        [NameInMap("ToStageId")]
        [Validation(Required=false)]
        public string ToStageId { get; set; }

        [NameInMap("UserAccount")]
        [Validation(Required=false)]
        public string UserAccount { get; set; }

    }

}
