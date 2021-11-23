// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class UpdatePtsSceneBaseLineShrinkRequest : TeaModel {
        [NameInMap("ApiBaselines")]
        [Validation(Required=false)]
        public string ApiBaselinesShrink { get; set; }

        [NameInMap("SceneBaseline")]
        [Validation(Required=false)]
        public string SceneBaselineShrink { get; set; }

        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

    }

}
