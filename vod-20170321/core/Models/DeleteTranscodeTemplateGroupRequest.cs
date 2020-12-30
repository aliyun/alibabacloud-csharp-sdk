// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteTranscodeTemplateGroupRequest : TeaModel {
        [NameInMap("TranscodeTemplateGroupId")]
        [Validation(Required=false)]
        public string TranscodeTemplateGroupId { get; set; }

        [NameInMap("TranscodeTemplateIds")]
        [Validation(Required=false)]
        public string TranscodeTemplateIds { get; set; }

        [NameInMap("ForceDelGroup")]
        [Validation(Required=false)]
        public string ForceDelGroup { get; set; }

    }

}
