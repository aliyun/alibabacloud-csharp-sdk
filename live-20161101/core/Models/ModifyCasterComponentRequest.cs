// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyCasterComponentRequest : TeaModel {
        [NameInMap("CasterId")]
        [Validation(Required=true)]
        public string CasterId { get; set; }

        [NameInMap("ComponentId")]
        [Validation(Required=true)]
        public string ComponentId { get; set; }

        [NameInMap("ComponentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        [NameInMap("ComponentType")]
        [Validation(Required=false)]
        public string ComponentType { get; set; }

        [NameInMap("Effect")]
        [Validation(Required=false)]
        public string Effect { get; set; }

        [NameInMap("ComponentLayer")]
        [Validation(Required=false)]
        public string ComponentLayer { get; set; }

        [NameInMap("TextLayerContent")]
        [Validation(Required=false)]
        public string TextLayerContent { get; set; }

        [NameInMap("ImageLayerContent")]
        [Validation(Required=false)]
        public string ImageLayerContent { get; set; }

        [NameInMap("CaptionLayerContent")]
        [Validation(Required=false)]
        public string CaptionLayerContent { get; set; }

    }

}
