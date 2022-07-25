// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class RectVerticalRequest : TeaModel {
        [NameInMap("CountDetectDoor")]
        [Validation(Required=false)]
        public int? CountDetectDoor { get; set; }

        [NameInMap("DetectDoor")]
        [Validation(Required=false)]
        public bool? DetectDoor { get; set; }

        [NameInMap("SubSceneId")]
        [Validation(Required=false)]
        public string SubSceneId { get; set; }

        [NameInMap("VerticalRect")]
        [Validation(Required=false)]
        public string VerticalRect { get; set; }

    }

}
