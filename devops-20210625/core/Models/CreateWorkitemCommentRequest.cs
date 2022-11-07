// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateWorkitemCommentRequest : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("formatType")]
        [Validation(Required=false)]
        public string FormatType { get; set; }

        [NameInMap("parentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        [NameInMap("workitemIdentifier")]
        [Validation(Required=false)]
        public string WorkitemIdentifier { get; set; }

    }

}
