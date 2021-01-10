// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CheckLinkeBahamutStctaskRequest : TeaModel {
        [NameInMap("IterationUnitId")]
        [Validation(Required=false)]
        public string IterationUnitId { get; set; }

        [NameInMap("Memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        [NameInMap("StageId")]
        [Validation(Required=false)]
        public string StageId { get; set; }

    }

}
