// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class SaveHotspotTagListRequest : TeaModel {
        [NameInMap("HotspotListJson")]
        [Validation(Required=false)]
        public string HotspotListJson { get; set; }

        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

    }

}
