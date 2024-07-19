// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class AddTextFeedbackRequest : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("quality")]
        [Validation(Required=false)]
        public int? Quality { get; set; }

        [NameInMap("textId")]
        [Validation(Required=false)]
        public long? TextId { get; set; }

    }

}
