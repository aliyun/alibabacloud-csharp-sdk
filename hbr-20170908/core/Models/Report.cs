// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class Report : TeaModel {
        [NameInMap("FailedFiles")]
        [Validation(Required=false)]
        public string FailedFiles { get; set; }

        [NameInMap("SkippedFiles")]
        [Validation(Required=false)]
        public string SkippedFiles { get; set; }

        [NameInMap("SuccessFiles")]
        [Validation(Required=false)]
        public string SuccessFiles { get; set; }

        [NameInMap("TotalFiles")]
        [Validation(Required=false)]
        public string TotalFiles { get; set; }

    }

}
