// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class AdjustPtsSceneSpeedRequest : TeaModel {
        [NameInMap("ApiSpeedList")]
        [Validation(Required=false)]
        public List<AdjustPtsSceneSpeedRequestApiSpeedList> ApiSpeedList { get; set; }
        public class AdjustPtsSceneSpeedRequestApiSpeedList : TeaModel {
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public string ApiId { get; set; }

            [NameInMap("Speed")]
            [Validation(Required=false)]
            public long? Speed { get; set; }

        }

        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

    }

}
