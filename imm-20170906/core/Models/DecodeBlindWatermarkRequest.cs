// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class DecodeBlindWatermarkRequest : TeaModel {
        [NameInMap("ImageQuality")]
        [Validation(Required=false)]
        public int? ImageQuality { get; set; }

        [NameInMap("ImageUri")]
        [Validation(Required=false)]
        public string ImageUri { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("OriginalImageUri")]
        [Validation(Required=false)]
        public string OriginalImageUri { get; set; }

        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("TargetUri")]
        [Validation(Required=false)]
        public string TargetUri { get; set; }

    }

}
