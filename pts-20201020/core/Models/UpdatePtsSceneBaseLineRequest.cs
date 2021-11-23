// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class UpdatePtsSceneBaseLineRequest : TeaModel {
        [NameInMap("ApiBaselines")]
        [Validation(Required=false)]
        public Dictionary<string, object> ApiBaselines { get; set; }

        [NameInMap("SceneBaseline")]
        [Validation(Required=false)]
        public Dictionary<string, object> SceneBaseline { get; set; }

        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

    }

}
