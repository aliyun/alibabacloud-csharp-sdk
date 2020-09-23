// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListProjectRolesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ProjectRoleList")]
        [Validation(Required=true)]
        public List<ListProjectRolesResponseProjectRoleList> ProjectRoleList { get; set; }
        public class ListProjectRolesResponseProjectRoleList : TeaModel {
            [NameInMap("ProjectRoleCode")]
            [Validation(Required=true)]
            public string ProjectRoleCode { get; set; }

            [NameInMap("ProjectRoleId")]
            [Validation(Required=true)]
            public int? ProjectRoleId { get; set; }

            [NameInMap("ProjectRoleName")]
            [Validation(Required=true)]
            public string ProjectRoleName { get; set; }

            [NameInMap("ProjectRoleType")]
            [Validation(Required=true)]
            public string ProjectRoleType { get; set; }

        }

    }

}
