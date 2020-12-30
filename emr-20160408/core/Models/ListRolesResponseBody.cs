// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListRolesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Paging")]
        [Validation(Required=false)]
        public bool? Paging { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRolesResponseBodyData Data { get; set; }
        public class ListRolesResponseBodyData : TeaModel {
            [NameInMap("roleDTO")]
            [Validation(Required=false)]
            public List<ListRolesResponseBodyDataRoleDTO> RoleDTO { get; set; }
            public class ListRolesResponseBodyDataRoleDTO : TeaModel {
                public string ResourceType { get; set; }
                public string Description { get; set; }
                public string GmtCreate { get; set; }
                public string Name { get; set; }
                public string GmtModified { get; set; }
                public long? Id { get; set; }
            }
        };

    }

}
