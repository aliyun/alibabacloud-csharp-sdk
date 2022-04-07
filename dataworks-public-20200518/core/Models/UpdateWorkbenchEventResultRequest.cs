// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateWorkbenchEventResultRequest : TeaModel {
        [NameInMap("CheckResult")]
        [Validation(Required=false)]
        public string CheckResult { get; set; }

        [NameInMap("CheckResultTip")]
        [Validation(Required=false)]
        public string CheckResultTip { get; set; }

        [NameInMap("ExtensionCode")]
        [Validation(Required=false)]
        public string ExtensionCode { get; set; }

        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

    }

}
