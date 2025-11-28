// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LingMou20250527.Models
{
    public class BroadcastVideo : TeaModel {
        [NameInMap("alignmentFileURL")]
        [Validation(Required=false)]
        public string AlignmentFileURL { get; set; }

        [NameInMap("captionURL")]
        [Validation(Required=false)]
        public string CaptionURL { get; set; }

        [NameInMap("coverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("modifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("videoURL")]
        [Validation(Required=false)]
        public string VideoURL { get; set; }

    }

}
