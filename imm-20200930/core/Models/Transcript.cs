// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Transcript : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("SpeakerId")]
        [Validation(Required=false)]
        public string SpeakerId { get; set; }

        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public List<long?> TimeRange { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
