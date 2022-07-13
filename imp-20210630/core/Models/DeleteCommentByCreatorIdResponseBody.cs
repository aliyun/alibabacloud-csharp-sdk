// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class DeleteCommentByCreatorIdResponseBody : TeaModel {
        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 调用删除直播间弹幕的返回结果。
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DeleteCommentByCreatorIdResponseBodyResult Result { get; set; }
        public class DeleteCommentByCreatorIdResponseBodyResult : TeaModel {
            [NameInMap("DeleteResult")]
            [Validation(Required=false)]
            public bool? DeleteResult { get; set; }
        };

    }

}
