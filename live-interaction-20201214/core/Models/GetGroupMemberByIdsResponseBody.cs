// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class GetGroupMemberByIdsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetGroupMemberByIdsResponseBodyResult Result { get; set; }
        public class GetGroupMemberByIdsResponseBodyResult : TeaModel {
            [NameInMap("Members")]
            [Validation(Required=false)]
            public List<GetGroupMemberByIdsResponseBodyResultMembers> Members { get; set; }
            public class GetGroupMemberByIdsResponseBodyResultMembers : TeaModel {
                public string AppUid { get; set; }
                public int? Role { get; set; }
                public string Nick { get; set; }
                public long? JoinTime { get; set; }
                public Dictionary<string, string> Extensions { get; set; }
            }
        };

    }

}
