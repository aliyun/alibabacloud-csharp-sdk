// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketModelFeature : TeaModel {
        [NameInMap("enableMultiModal")]
        [Validation(Required=false)]
        public bool? EnableMultiModal { get; set; }

        [NameInMap("enableThinking")]
        [Validation(Required=false)]
        public bool? EnableThinking { get; set; }

        [NameInMap("maxTokens")]
        [Validation(Required=false)]
        public int? MaxTokens { get; set; }

        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("streaming")]
        [Validation(Required=false)]
        public bool? Streaming { get; set; }

        [NameInMap("temperature")]
        [Validation(Required=false)]
        public float? Temperature { get; set; }

        [NameInMap("webSearch")]
        [Validation(Required=false)]
        public bool? WebSearch { get; set; }

    }

}
