// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicTemplateStatus : TeaModel {
        [NameInMap("finishedAt")]
        [Validation(Required=false)]
        public string FinishedAt { get; set; }

        [NameInMap("reason")]
        [Validation(Required=false)]
        public PublicTemplateStatusReason Reason { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
