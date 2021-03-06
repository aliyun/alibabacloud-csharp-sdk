// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
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
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListUsersResponseBodyDataItems> Items { get; set; }
            public class ListUsersResponseBodyDataItems : TeaModel {
                public string RamUsername { get; set; }
                public string Email { get; set; }
                public string PhoneNumber { get; set; }
                public List<ListUsersResponseBodyDataItemsDepartments> Departments { get; set; }
                public class ListUsersResponseBodyDataItemsDepartments : TeaModel {
                    public string Description { get; set; }
                    public string CreatedAt { get; set; }
                    public string UpdatedAt { get; set; }
                    public string Name { get; set; }
                    public string Id { get; set; }
                }
                public string CreatedAt { get; set; }
                public string UpdatedAt { get; set; }
                public string Source { get; set; }
                public string Role { get; set; }
                public string Name { get; set; }
                public string Id { get; set; }
                public string Username { get; set; }
            }
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }
            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public long? TotalElements { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
