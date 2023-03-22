// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DocumentAutoml20221229.Models
{
    public class PredictTemplateModelRequest : TeaModel {
        [NameInMap("BinaryToText")]
        [Validation(Required=false)]
        public bool? BinaryToText { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
