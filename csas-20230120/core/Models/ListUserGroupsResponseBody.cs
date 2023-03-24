// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListUserGroupsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        [NameInMap("UserGroups")]
        [Validation(Required=false)]
        public List<ListUserGroupsResponseBodyUserGroups> UserGroups { get; set; }
        public class ListUserGroupsResponseBodyUserGroups : TeaModel {
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<ListUserGroupsResponseBodyUserGroupsAttributes> Attributes { get; set; }
            public class ListUserGroupsResponseBodyUserGroupsAttributes : TeaModel {
                [NameInMap("IdpId")]
                [Validation(Required=false)]
                public int? IdpId { get; set; }

                [NameInMap("Relation")]
                [Validation(Required=false)]
                public string Relation { get; set; }

                [NameInMap("UserGroupType")]
                [Validation(Required=false)]
                public string UserGroupType { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

        }

    }

}
