// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterComponentRequest : TeaModel {
        [NameInMap("CasterId")]
        [Validation(Required=true)]
        public string CasterId { get; set; }

        [NameInMap("ComponentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        [NameInMap("LocationId")]
        [Validation(Required=true)]
        public string LocationId { get; set; }

        [NameInMap("ComponentType")]
        [Validation(Required=true)]
        public string ComponentType { get; set; }

        [NameInMap("Effect")]
        [Validation(Required=false)]
        public string Effect { get; set; }

        [NameInMap("ComponentLayer")]
        [Validation(Required=true)]
        public string ComponentLayer { get; set; }

        [NameInMap("LayerOrder")]
        [Validation(Required=false)]
        public string LayerOrder { get; set; }

        [NameInMap("TextLayerContent")]
        [Validation(Required=false)]
        public string TextLayerContent { get; set; }

        [NameInMap("ImageLayerContent")]
        [Validation(Required=false)]
        public string ImageLayerContent { get; set; }

        [NameInMap("CaptionLayerContent")]
        [Validation(Required=false)]
        public string CaptionLayerContent { get; set; }

        [NameInMap("HtmlLayerContent")]
        [Validation(Required=false)]
        public string HtmlLayerContent { get; set; }

    }

}
