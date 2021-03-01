// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListRoleResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RoleList")]
        [Validation(Required=false)]
        public ListRoleResponseBodyRoleList RoleList { get; set; }
        public class ListRoleResponseBodyRoleList : TeaModel {
            [NameInMap("RoleItem")]
            [Validation(Required=false)]
            public List<ListRoleResponseBodyRoleListRoleItem> RoleItem { get; set; }
            public class ListRoleResponseBodyRoleListRoleItem : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public List<ListRoleResponseBodyRoleListRoleItemAction> Action { get; set; }
                public class ListRoleResponseBodyRoleListRoleItemAction : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
