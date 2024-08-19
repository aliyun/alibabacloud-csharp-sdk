// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class UpdateServiceConfigRequest : TeaModel {
        [NameInMap("FileConfig")]
        [Validation(Required=false)]
        public string FileConfig { get; set; }

        [NameInMap("KeywordFilterLibs")]
        [Validation(Required=false)]
        public string KeywordFilterLibs { get; set; }

        [NameInMap("KeywordHitLibs")]
        [Validation(Required=false)]
        public string KeywordHitLibs { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("SceneConfig")]
        [Validation(Required=false)]
        public string SceneConfig { get; set; }

        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        [NameInMap("VideoConfig")]
        [Validation(Required=false)]
        public string VideoConfig { get; set; }

    }

}
