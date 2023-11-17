// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class TriggerSophonPlaybookRequest : TeaModel {
        [NameInMap("CommandName")]
        [Validation(Required=false)]
        public string CommandName { get; set; }

        [NameInMap("InputParams")]
        [Validation(Required=false)]
        public string InputParams { get; set; }

        [NameInMap("SophonTaskId")]
        [Validation(Required=false)]
        public string SophonTaskId { get; set; }

        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
