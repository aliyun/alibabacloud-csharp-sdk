// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListProjectRolesResponseBody : TeaModel {
        [NameInMap("ProjectRoleList")]
        [Validation(Required=false)]
        public List<ListProjectRolesResponseBodyProjectRoleList> ProjectRoleList { get; set; }
        public class ListProjectRolesResponseBodyProjectRoleList : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
