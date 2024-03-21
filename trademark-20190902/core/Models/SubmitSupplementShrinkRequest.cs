// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class SubmitSupplementShrinkRequest : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("SupplementId")]
        [Validation(Required=false)]
        public long? SupplementId { get; set; }

        [NameInMap("UserFiles")]
        [Validation(Required=false)]
        public string UserFilesShrink { get; set; }

    }

}
