// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListUsersResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListUsersResponseBodyData Data { get; set; }
        public class ListUsersResponseBodyData : TeaModel {
            [NameInMap("Success")]
            [Validation(Required=false)]
            public long? Success { get; set; }
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListUsersResponseBodyDataRecords> Records { get; set; }
            public class ListUsersResponseBodyDataRecords : TeaModel {
                public string IsvSubId { get; set; }
                public string Gender { get; set; }
                public string FaceImageUrl { get; set; }
                public int? UserGroupId { get; set; }
                public int? UserId { get; set; }
                public string MatchingRate { get; set; }
                public string BizId { get; set; }
                public string Attachment { get; set; }
                public string Age { get; set; }
                public string IdNumber { get; set; }
                public string PersonId { get; set; }
                public string UserName { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
