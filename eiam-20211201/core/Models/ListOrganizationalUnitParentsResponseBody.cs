// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListOrganizationalUnitParentsResponseBody : TeaModel {
        [NameInMap("Parents")]
        [Validation(Required=false)]
        public List<ListOrganizationalUnitParentsResponseBodyParents> Parents { get; set; }
        public class ListOrganizationalUnitParentsResponseBodyParents : TeaModel {
            /// <summary>
            /// 组织ID
            /// </summary>
            [NameInMap("OrganizationalUnitId")]
            [Validation(Required=false)]
            public string OrganizationalUnitId { get; set; }

            /// <summary>
            /// 父组织ID
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
