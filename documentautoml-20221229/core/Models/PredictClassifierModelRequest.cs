// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DocumentAutoml20221229.Models
{
    public class PredictClassifierModelRequest : TeaModel {
        [NameInMap("AutoPrediction")]
        [Validation(Required=false)]
        public bool? AutoPrediction { get; set; }

        [NameInMap("BinaryToText")]
        [Validation(Required=false)]
        public bool? BinaryToText { get; set; }

        [NameInMap("Body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        [NameInMap("ClassifierId")]
        [Validation(Required=false)]
        public long? ClassifierId { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

    }

}
