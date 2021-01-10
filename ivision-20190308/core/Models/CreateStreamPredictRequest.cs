// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivision20190308.Models
{
    public class CreateStreamPredictRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ShowLog")]
        [Validation(Required=false)]
        public string ShowLog { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("StreamType")]
        [Validation(Required=false)]
        public string StreamType { get; set; }

        [NameInMap("StreamId")]
        [Validation(Required=false)]
        public string StreamId { get; set; }

        [NameInMap("PredictTemplateId")]
        [Validation(Required=false)]
        public string PredictTemplateId { get; set; }

        [NameInMap("ModelIds")]
        [Validation(Required=false)]
        public string ModelIds { get; set; }

        [NameInMap("ProbabilityThresholds")]
        [Validation(Required=false)]
        public string ProbabilityThresholds { get; set; }

        [NameInMap("DetectIntervals")]
        [Validation(Required=false)]
        public string DetectIntervals { get; set; }

        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        [NameInMap("Notify")]
        [Validation(Required=false)]
        public string Notify { get; set; }

        [NameInMap("AutoStart")]
        [Validation(Required=false)]
        public string AutoStart { get; set; }

        [NameInMap("FaceGroupId")]
        [Validation(Required=false)]
        public string FaceGroupId { get; set; }

        [NameInMap("ModelUserData")]
        [Validation(Required=false)]
        public string ModelUserData { get; set; }

    }

}
