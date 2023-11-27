// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class GetGroupMemberByIdsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetGroupMemberByIdsResponseBodyResult Result { get; set; }
        public class GetGroupMemberByIdsResponseBodyResult : TeaModel {
            [NameInMap("Members")]
            [Validation(Required=false)]
            public List<GetGroupMemberByIdsResponseBodyResultMembers> Members { get; set; }
            public class GetGroupMemberByIdsResponseBodyResultMembers : TeaModel {
                [NameInMap("AppUid")]
                [Validation(Required=false)]
                public string AppUid { get; set; }

                [NameInMap("Extensions")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extensions { get; set; }

                [NameInMap("JoinTime")]
                [Validation(Required=false)]
                public long? JoinTime { get; set; }

                [NameInMap("Nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public int? Role { get; set; }

            }

        }

    }

}
