// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class WorkitemAttachmentCreateRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("fileKey")]
        [Validation(Required=false)]
        public string FileKey { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("originalFilename")]
        [Validation(Required=false)]
        public string OriginalFilename { get; set; }

    }

}
