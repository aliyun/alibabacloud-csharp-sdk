// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListRamUsersResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRamUsersResponseBodyData Data { get; set; }
        public class ListRamUsersResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListRamUsersResponseBodyDataList> List { get; set; }
            public class ListRamUsersResponseBodyDataList : TeaModel {
                public string DisplayName { get; set; }
                public string Email { get; set; }
                public string LoginName { get; set; }
                public string Mobile { get; set; }
                public long? AliyunUid { get; set; }
                public bool? Primary { get; set; }
                public string RamId { get; set; }
            }
        };

    }

}
