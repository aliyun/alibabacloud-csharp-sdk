// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class PredImageRequest : TeaModel {
        [NameInMap("CorrectVertical")]
        [Validation(Required=false)]
        public bool? CorrectVertical { get; set; }

        [NameInMap("CountDetectDoor")]
        [Validation(Required=false)]
        public long? CountDetectDoor { get; set; }

        [NameInMap("DetectDoor")]
        [Validation(Required=false)]
        public bool? DetectDoor { get; set; }

        [NameInMap("SubSceneId")]
        [Validation(Required=false)]
        public string SubSceneId { get; set; }

    }

}
