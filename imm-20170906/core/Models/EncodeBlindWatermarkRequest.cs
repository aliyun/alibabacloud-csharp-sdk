// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class EncodeBlindWatermarkRequest : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("ImageQuality")]
        [Validation(Required=false)]
        public string ImageQuality { get; set; }

        [NameInMap("ImageUri")]
        [Validation(Required=false)]
        public string ImageUri { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("TargetImageType")]
        [Validation(Required=false)]
        public string TargetImageType { get; set; }

        [NameInMap("TargetUri")]
        [Validation(Required=false)]
        public string TargetUri { get; set; }

        [NameInMap("WatermarkUri")]
        [Validation(Required=false)]
        public string WatermarkUri { get; set; }

    }

}
