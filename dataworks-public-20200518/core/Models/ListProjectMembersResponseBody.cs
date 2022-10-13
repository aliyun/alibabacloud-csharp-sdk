// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListProjectMembersResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListProjectMembersResponseBodyData Data { get; set; }
        public class ListProjectMembersResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("ProjectMemberList")]
            [Validation(Required=false)]
            public List<ListProjectMembersResponseBodyDataProjectMemberList> ProjectMemberList { get; set; }
            public class ListProjectMembersResponseBodyDataProjectMemberList : TeaModel {
                [NameInMap("Nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                [NameInMap("ProjectMemberId")]
                [Validation(Required=false)]
                public string ProjectMemberId { get; set; }

                [NameInMap("ProjectMemberName")]
                [Validation(Required=false)]
                public string ProjectMemberName { get; set; }

                [NameInMap("ProjectMemberType")]
                [Validation(Required=false)]
                public string ProjectMemberType { get; set; }

                [NameInMap("ProjectRoleList")]
                [Validation(Required=false)]
                public List<ListProjectMembersResponseBodyDataProjectMemberListProjectRoleList> ProjectRoleList { get; set; }
                public class ListProjectMembersResponseBodyDataProjectMemberListProjectRoleList : TeaModel {
                    [NameInMap("ProjectRoleCode")]
                    [Validation(Required=false)]
                    public string ProjectRoleCode { get; set; }

                    [NameInMap("ProjectRoleId")]
                    [Validation(Required=false)]
                    public int? ProjectRoleId { get; set; }

                    [NameInMap("ProjectRoleName")]
                    [Validation(Required=false)]
                    public string ProjectRoleName { get; set; }

                    [NameInMap("ProjectRoleType")]
                    [Validation(Required=false)]
                    public string ProjectRoleType { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
