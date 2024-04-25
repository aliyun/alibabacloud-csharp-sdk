// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListClientUsersResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListClientUsersResponseBodyData Data { get; set; }
        public class ListClientUsersResponseBodyData : TeaModel {
            [NameInMap("DataList")]
            [Validation(Required=false)]
            public List<ListClientUsersResponseBodyDataDataList> DataList { get; set; }
            public class ListClientUsersResponseBodyDataDataList : TeaModel {
                [NameInMap("Department")]
                [Validation(Required=false)]
                public ListClientUsersResponseBodyDataDataListDepartment Department { get; set; }
                public class ListClientUsersResponseBodyDataDataListDepartment : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("DepartmentId")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("IdpConfigId")]
                [Validation(Required=false)]
                public string IdpConfigId { get; set; }

                [NameInMap("MobileNumber")]
                [Validation(Required=false)]
                public string MobileNumber { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
