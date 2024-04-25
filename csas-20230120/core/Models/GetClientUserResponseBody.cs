// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetClientUserResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetClientUserResponseBodyData Data { get; set; }
        public class GetClientUserResponseBodyData : TeaModel {
            [NameInMap("Department")]
            [Validation(Required=false)]
            public GetClientUserResponseBodyDataDepartment Department { get; set; }
            public class GetClientUserResponseBodyDataDepartment : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
