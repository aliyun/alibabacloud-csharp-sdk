// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicTemplateCache : TeaModel {
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("imageDigest")]
        [Validation(Required=false)]
        public string ImageDigest { get; set; }

        [NameInMap("imageSizeMB")]
        [Validation(Required=false)]
        public int? ImageSizeMB { get; set; }

        [NameInMap("progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        [NameInMap("readyTime")]
        [Validation(Required=false)]
        public string ReadyTime { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("statusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        [NameInMap("templateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

    }

}
