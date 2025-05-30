// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class ModelInputContentSyncDetectShrinkRequest : TeaModel {
        [NameInMap("BodyData")]
        [Validation(Required=false)]
        public string BodyDataShrink { get; set; }

        [NameInMap("PolicyIdentifier")]
        [Validation(Required=false)]
        public string PolicyIdentifier { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
