// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Message : TeaModel {
        [NameInMap("AssistantType")]
        [Validation(Required=false)]
        public string AssistantType { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("Regenerate")]
        [Validation(Required=false)]
        public bool? Regenerate { get; set; }

        [NameInMap("Reply")]
        [Validation(Required=false)]
        public string Reply { get; set; }

        [NameInMap("Score")]
        [Validation(Required=false)]
        public double? Score { get; set; }

        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        [NameInMap("Suggestion")]
        [Validation(Required=false)]
        public string Suggestion { get; set; }

        [NameInMap("Tone")]
        [Validation(Required=false)]
        public string Tone { get; set; }

        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
