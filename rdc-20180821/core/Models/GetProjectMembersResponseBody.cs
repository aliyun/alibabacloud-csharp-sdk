// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rdc20180821.Models
{
    public class GetProjectMembersResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetProjectMembersResponseBodyData> Data { get; set; }
        public class GetProjectMembersResponseBodyData : TeaModel {
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("Users")]
            [Validation(Required=false)]
            public List<GetProjectMembersResponseBodyDataUsers> Users { get; set; }
            public class GetProjectMembersResponseBodyDataUsers : TeaModel {
                [NameInMap("Avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("RealName")]
                [Validation(Required=false)]
                public string RealName { get; set; }

                [NameInMap("StaffId")]
                [Validation(Required=false)]
                public string StaffId { get; set; }

                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
