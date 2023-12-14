// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListRdUsersResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListRdUsersResponseBodyData> Data { get; set; }
        public class ListRdUsersResponseBodyData : TeaModel {
            [NameInMap("DelegatedOrNot")]
            [Validation(Required=false)]
            public bool? DelegatedOrNot { get; set; }

            [NameInMap("Joined")]
            [Validation(Required=false)]
            public bool? Joined { get; set; }

            [NameInMap("JoinedTime")]
            [Validation(Required=false)]
            public string JoinedTime { get; set; }

            [NameInMap("MainUserId")]
            [Validation(Required=false)]
            public long? MainUserId { get; set; }

            [NameInMap("SubUserId")]
            [Validation(Required=false)]
            public long? SubUserId { get; set; }

            [NameInMap("SubUserName")]
            [Validation(Required=false)]
            public string SubUserName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
