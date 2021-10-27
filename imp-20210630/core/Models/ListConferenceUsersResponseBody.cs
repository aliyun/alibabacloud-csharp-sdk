// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListConferenceUsersResponseBody : TeaModel {
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
        public ListConferenceUsersResponseBodyResult Result { get; set; }
        public class ListConferenceUsersResponseBodyResult : TeaModel {
            [NameInMap("ConferenceUserList")]
            [Validation(Required=false)]
            public List<ListConferenceUsersResponseBodyResultConferenceUserList> ConferenceUserList { get; set; }
            public class ListConferenceUsersResponseBodyResultConferenceUserList : TeaModel {
                public string Status { get; set; }
                public string UserId { get; set; }
            }
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
