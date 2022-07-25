// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class LabelBuildRequest : TeaModel {
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("ModelStyle")]
        [Validation(Required=false)]
        public string ModelStyle { get; set; }

        [NameInMap("OptimizeWallWidth")]
        [Validation(Required=false)]
        public string OptimizeWallWidth { get; set; }

        [NameInMap("PlanStyle")]
        [Validation(Required=false)]
        public string PlanStyle { get; set; }

        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        [NameInMap("WallHeight")]
        [Validation(Required=false)]
        public long? WallHeight { get; set; }

    }

}
