// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class DeleteCommentByCreatorIdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DeleteCommentByCreatorIdResponseBodyResult Result { get; set; }
        public class DeleteCommentByCreatorIdResponseBodyResult : TeaModel {
            [NameInMap("DeleteResult")]
            [Validation(Required=false)]
            public bool? DeleteResult { get; set; }

        }

    }

}
