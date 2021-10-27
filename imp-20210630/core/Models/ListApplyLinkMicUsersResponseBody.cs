// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListApplyLinkMicUsersResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListApplyLinkMicUsersResponseBodyResult Result { get; set; }
        public class ListApplyLinkMicUsersResponseBodyResult : TeaModel {
            [NameInMap("ApplyLinkMicUserList")]
            [Validation(Required=false)]
            public List<string> ApplyLinkMicUserList { get; set; }
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }
            [NameInMap("PageTotal")]
            [Validation(Required=false)]
            public int? PageTotal { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

    }

}
