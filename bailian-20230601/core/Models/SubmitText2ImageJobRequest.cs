// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20230601.Models
{
    public class SubmitText2ImageJobRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("N")]
        [Validation(Required=false)]
        public int? N { get; set; }

        [NameInMap("NegativePrompt")]
        [Validation(Required=false)]
        public string NegativePrompt { get; set; }

        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        [NameInMap("Seed")]
        [Validation(Required=false)]
        public int? Seed { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public string Size { get; set; }

        [NameInMap("Style")]
        [Validation(Required=false)]
        public string Style { get; set; }

    }

}
