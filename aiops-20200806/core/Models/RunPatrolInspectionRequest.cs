// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class RunPatrolInspectionRequest : TeaModel {
        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

        [NameInMap("ProductCodes")]
        [Validation(Required=false)]
        public string ProductCodes { get; set; }

        [NameInMap("RiskCodeList")]
        [Validation(Required=false)]
        public string RiskCodeList { get; set; }

    }

}
