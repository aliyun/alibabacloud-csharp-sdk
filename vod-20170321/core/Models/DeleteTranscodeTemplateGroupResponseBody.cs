// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteTranscodeTemplateGroupResponseBody : TeaModel {
        /// <summary>
        /// The IDs of transcoding templates that were not found.
        /// </summary>
        [NameInMap("NonExistTranscodeTemplateIds")]
        [Validation(Required=false)]
        public List<string> NonExistTranscodeTemplateIds { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
