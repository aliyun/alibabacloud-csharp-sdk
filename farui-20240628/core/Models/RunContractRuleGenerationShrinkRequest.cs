// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class RunContractRuleGenerationShrinkRequest : TeaModel {
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("assistant")]
        [Validation(Required=false)]
        public string AssistantShrink { get; set; }

        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

    }

}
