// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateDecodeBlindWatermarkTaskShrinkRequest : TeaModel {
        [NameInMap("ImageQuality")]
        [Validation(Required=false)]
        public int? ImageQuality { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("Notification")]
        [Validation(Required=false)]
        public string NotificationShrink { get; set; }

        [NameInMap("OriginalImageURI")]
        [Validation(Required=false)]
        public string OriginalImageURI { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        [NameInMap("StrengthLevel")]
        [Validation(Required=false)]
        public string StrengthLevel { get; set; }

        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        [NameInMap("WatermarkType")]
        [Validation(Required=false)]
        public string WatermarkType { get; set; }

    }

}
