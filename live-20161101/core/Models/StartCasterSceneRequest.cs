// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class StartCasterSceneRequest : TeaModel {
        [NameInMap("CasterId")]
        [Validation(Required=true)]
        public string CasterId { get; set; }

        [NameInMap("SceneId")]
        [Validation(Required=true)]
        public string SceneId { get; set; }

    }

}
