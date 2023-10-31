// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20230601.Models
{
    public class CreateTextEmbeddingsShrinkRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("Input")]
        [Validation(Required=false)]
        public string InputShrink { get; set; }

        [NameInMap("TextType")]
        [Validation(Required=false)]
        public string TextType { get; set; }

    }

}
