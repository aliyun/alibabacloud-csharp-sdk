// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteTranscodeTemplatesResponseBody : TeaModel {
        [NameInMap("NonExistTranscodeTemplateIds")]
        [Validation(Required=false)]
        public List<string> NonExistTranscodeTemplateIds { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
