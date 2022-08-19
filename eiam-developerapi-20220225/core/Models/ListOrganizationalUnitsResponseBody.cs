// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ListOrganizationalUnitsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListOrganizationalUnitsResponseBodyData> Data { get; set; }
        public class ListOrganizationalUnitsResponseBodyData : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("organizationalUnitExternalId")]
            [Validation(Required=false)]
            public string OrganizationalUnitExternalId { get; set; }

            [NameInMap("organizationalUnitId")]
            [Validation(Required=false)]
            public string OrganizationalUnitId { get; set; }

            [NameInMap("organizationalUnitName")]
            [Validation(Required=false)]
            public string OrganizationalUnitName { get; set; }

            [NameInMap("organizationalUnitSourceId")]
            [Validation(Required=false)]
            public string OrganizationalUnitSourceId { get; set; }

            [NameInMap("organizationalUnitSourceType")]
            [Validation(Required=false)]
            public string OrganizationalUnitSourceType { get; set; }

            [NameInMap("parentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
