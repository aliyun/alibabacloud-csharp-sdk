// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ModelParameters : TeaModel {
        [NameInMap("frequencyPenalty")]
        [Validation(Required=false)]
        public float? FrequencyPenalty { get; set; }

        [NameInMap("maxTokens")]
        [Validation(Required=false)]
        public long? MaxTokens { get; set; }

        [NameInMap("presencePenalty")]
        [Validation(Required=false)]
        public float? PresencePenalty { get; set; }

        [NameInMap("stopSequences")]
        [Validation(Required=false)]
        public List<string> StopSequences { get; set; }

        [NameInMap("temperature")]
        [Validation(Required=false)]
        public float? Temperature { get; set; }

        [NameInMap("topK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        [NameInMap("topP")]
        [Validation(Required=false)]
        public float? TopP { get; set; }

    }

}
