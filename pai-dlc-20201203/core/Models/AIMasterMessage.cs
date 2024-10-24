// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class AIMasterMessage : TeaModel {
        [NameInMap("Extended")]
        [Validation(Required=false)]
        public string Extended { get; set; }

        [NameInMap("JobRestartCount")]
        [Validation(Required=false)]
        public int? JobRestartCount { get; set; }

        [NameInMap("MessageContent")]
        [Validation(Required=false)]
        public string MessageContent { get; set; }

        [NameInMap("MessageEvent")]
        [Validation(Required=false)]
        public string MessageEvent { get; set; }

        [NameInMap("MessageVersion")]
        [Validation(Required=false)]
        public int? MessageVersion { get; set; }

        [NameInMap("RestartType")]
        [Validation(Required=false)]
        public string RestartType { get; set; }

    }

}
