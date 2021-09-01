// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListProjectMembersResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListProjectMembersResponseData Data { get; set; }
        public class ListProjectMembersResponseData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public int? TotalCount { get; set; }
            [NameInMap("ProjectMemberList")]
            [Validation(Required=true)]
            public List<ListProjectMembersResponseDataProjectMemberList> ProjectMemberList { get; set; }
            public class ListProjectMembersResponseDataProjectMemberList : TeaModel {
                public string Nick { get; set; }
                public string ProjectMemberId { get; set; }
                public string ProjectMemberName { get; set; }
                public string ProjectMemberType { get; set; }
                public string Status { get; set; }
                public List<ListProjectMembersResponseDataProjectMemberListProjectRoleList> ProjectRoleList { get; set; }
                public class ListProjectMembersResponseDataProjectMemberListProjectRoleList : TeaModel {
                    public string ProjectRoleCode { get; set; }
                    public int? ProjectRoleId { get; set; }
                    public string ProjectRoleName { get; set; }
                    public string ProjectRoleType { get; set; }
                }
            }
        };

    }

}
