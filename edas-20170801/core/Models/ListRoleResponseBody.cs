// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListRoleResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

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
                public ListRoleResponseBodyRoleListRoleItemActionList ActionList { get; set; }
                public class ListRoleResponseBodyRoleListRoleItemActionList : TeaModel {
                    [NameInMap("Action")]
                    [Validation(Required=false)]
                    public List<ListRoleResponseBodyRoleListRoleItemActionListAction> Action { get; set; }
                    public class ListRoleResponseBodyRoleListRoleItemActionListAction : TeaModel {
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("GroupId")]
                        [Validation(Required=false)]
                        public string GroupId { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }
                public ListRoleResponseBodyRoleListRoleItemRole Role { get; set; }
                public class ListRoleResponseBodyRoleListRoleItemRole : TeaModel {
                    [NameInMap("AdminUserId")]
                    [Validation(Required=false)]
                    public string AdminUserId { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public int? Id { get; set; }

                    [NameInMap("IsDefault")]
                    [Validation(Required=false)]
                    public bool? IsDefault { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                }
            }
        };

    }

}
