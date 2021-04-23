// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddStudioLayoutRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        [NameInMap("LayoutName")]
        [Validation(Required=false)]
        public string LayoutName { get; set; }

        [NameInMap("LayoutType")]
        [Validation(Required=false)]
        public string LayoutType { get; set; }

        [NameInMap("CommonConfig")]
        [Validation(Required=false)]
        public string CommonConfig { get; set; }

        [NameInMap("BgImageConfig")]
        [Validation(Required=false)]
        public string BgImageConfig { get; set; }

        [NameInMap("ScreenInputConfigList")]
        [Validation(Required=false)]
        public string ScreenInputConfigList { get; set; }

        [NameInMap("MediaInputConfigList")]
        [Validation(Required=false)]
        public string MediaInputConfigList { get; set; }

        [NameInMap("LayerOrderConfigList")]
        [Validation(Required=false)]
        public string LayerOrderConfigList { get; set; }

    }

}
