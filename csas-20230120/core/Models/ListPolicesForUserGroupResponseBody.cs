// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPolicesForUserGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserGroups")]
        [Validation(Required=false)]
        public List<ListPolicesForUserGroupResponseBodyUserGroups> UserGroups { get; set; }
        public class ListPolicesForUserGroupResponseBodyUserGroups : TeaModel {
            [NameInMap("Polices")]
            [Validation(Required=false)]
            public List<ListPolicesForUserGroupResponseBodyUserGroupsPolices> Polices { get; set; }
            public class ListPolicesForUserGroupResponseBodyUserGroupsPolices : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

            }

            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

        }

    }

}
