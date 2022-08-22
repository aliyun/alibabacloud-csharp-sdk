// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class UpdateShareScreenLayoutRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("ClassId")]
        [Validation(Required=false)]
        public string ClassId { get; set; }

        [NameInMap("EnableOverlay")]
        [Validation(Required=false)]
        public bool? EnableOverlay { get; set; }

        [NameInMap("OverlayHeight")]
        [Validation(Required=false)]
        public float? OverlayHeight { get; set; }

        [NameInMap("OverlayWidth")]
        [Validation(Required=false)]
        public float? OverlayWidth { get; set; }

        [NameInMap("OverlayX")]
        [Validation(Required=false)]
        public float? OverlayX { get; set; }

        [NameInMap("OverlayY")]
        [Validation(Required=false)]
        public float? OverlayY { get; set; }

    }

}
