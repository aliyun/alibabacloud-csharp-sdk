// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListUsersResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListUsersResponseBodyData Data { get; set; }
        public class ListUsersResponseBodyData : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<ListUsersResponseBodyDataUser> User { get; set; }
            public class ListUsersResponseBodyDataUser : TeaModel {
                public string AliUid { get; set; }
                public string CreateTime { get; set; }
                public string Description { get; set; }
                public string DisplayName { get; set; }
                public long? Id { get; set; }
                public int? LoginUserType { get; set; }
                public string RoleName { get; set; }
                public string UpdateTime { get; set; }
                public string UserName { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
