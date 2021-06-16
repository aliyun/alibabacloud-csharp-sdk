// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class ListDevopsProjectsResponseBody : TeaModel {
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Successful")]
        [Validation(Required=false)]
        public bool? Successful { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Object")]
        [Validation(Required=false)]
        public ListDevopsProjectsResponseBodyObject Object { get; set; }
        public class ListDevopsProjectsResponseBodyObject : TeaModel {
            [NameInMap("NextPageToken")]
            [Validation(Required=false)]
            public string NextPageToken { get; set; }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListDevopsProjectsResponseBodyObjectResult> Result { get; set; }
            public class ListDevopsProjectsResponseBodyObjectResult : TeaModel {
                public string Logo { get; set; }
                public bool? IsStar { get; set; }
                public string CreatorId { get; set; }
                public int? MembersCount { get; set; }
                public string OrganizationId { get; set; }
                public string Visibility { get; set; }
                public bool? IsTemplate { get; set; }
                public string Description { get; set; }
                public string Updated { get; set; }
                public string Created { get; set; }
                public bool? IsArchived { get; set; }
                public string Name { get; set; }
                public bool? IsPublic { get; set; }
                public int? TasksCount { get; set; }
                public int? RoleId { get; set; }
                public string Id { get; set; }
            }
        };

    }

}
