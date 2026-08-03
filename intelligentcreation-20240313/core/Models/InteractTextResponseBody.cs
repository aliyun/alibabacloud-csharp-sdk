// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class InteractTextResponseBody : TeaModel {
        [NameInMap("end")]
        [Validation(Required=false)]
        public bool? End { get; set; }

        [NameInMap("index")]
        [Validation(Required=false)]
        public int? Index { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("relatedImages")]
        [Validation(Required=false)]
        public List<string> RelatedImages { get; set; }

        [NameInMap("relatedVideos")]
        [Validation(Required=false)]
        public List<string> RelatedVideos { get; set; }

        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
