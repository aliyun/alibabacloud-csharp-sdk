// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkcard20210520.Models
{
    public class SetCardStopRuleRequest : TeaModel {
        [NameInMap("AutoRestore")]
        [Validation(Required=false)]
        public bool? AutoRestore { get; set; }

        [NameInMap("FlowLimit")]
        [Validation(Required=false)]
        public long? FlowLimit { get; set; }

        [NameInMap("Iccid")]
        [Validation(Required=false)]
        public string Iccid { get; set; }

    }

}
