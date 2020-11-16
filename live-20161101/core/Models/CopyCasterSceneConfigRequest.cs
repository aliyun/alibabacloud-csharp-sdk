// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CopyCasterSceneConfigRequest : TeaModel {
        [NameInMap("CasterId")]
        [Validation(Required=true)]
        public string CasterId { get; set; }

        [NameInMap("FromSceneId")]
        [Validation(Required=true)]
        public string FromSceneId { get; set; }

        [NameInMap("ToSceneId")]
        [Validation(Required=true)]
        public string ToSceneId { get; set; }

    }

}
