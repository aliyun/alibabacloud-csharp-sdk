// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListUsersResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListUsersResponseData Data { get; set; }
        public class ListUsersResponseData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public long PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public long PageSize { get; set; }
            [NameInMap("Success")]
            [Validation(Required=true)]
            public long Success { get; set; }
            [NameInMap("Total")]
            [Validation(Required=true)]
            public long Total { get; set; }
            [NameInMap("Records")]
            [Validation(Required=true)]
            public List<ListUsersResponseDataRecords> Records { get; set; }
            public class ListUsersResponseDataRecords : TeaModel {
                public int? UserGroupId { get; set; }
                public string Age { get; set; }
                public string Attachment { get; set; }
                public string BizId { get; set; }
                public string FaceImageUrl { get; set; }
                public string Gender { get; set; }
                public string IdNumber { get; set; }
                public int? UserId { get; set; }
                public string UserName { get; set; }
                public string IsvSubId { get; set; }
                public string MatchingRate { get; set; }
                public string PersonId { get; set; }
            }
        };

    }

}
