// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListByUserGroupIdResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The user group query result is returned.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListByUserGroupIdResponseBodyResult Result { get; set; }
        public class ListByUserGroupIdResponseBodyResult : TeaModel {
            [NameInMap("FailedUserGroupIds")]
            [Validation(Required=false)]
            public List<string> FailedUserGroupIds { get; set; }

            /// <summary>
            /// The details of the user group that was queried.
            /// </summary>
            [NameInMap("UserGroupModels")]
            [Validation(Required=false)]
            public List<ListByUserGroupIdResponseBodyResultUserGroupModels> UserGroupModels { get; set; }
            public class ListByUserGroupIdResponseBodyResultUserGroupModels : TeaModel {
                /// <summary>
                /// The time when the Secret was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The UserID of the creator in the Quick BI.
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// The path of the user group.
                /// </summary>
                [NameInMap("IdentifiedPath")]
                [Validation(Required=false)]
                public string IdentifiedPath { get; set; }

                /// <summary>
                /// The time when the protection policy was last modified.
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// The UserID of the modifier in the Quick BI.
                /// </summary>
                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                /// <summary>
                /// The ID of the parent user group.
                /// </summary>
                [NameInMap("ParentUsergroupId")]
                [Validation(Required=false)]
                public string ParentUsergroupId { get; set; }

                /// <summary>
                /// The description of the user group.
                /// </summary>
                [NameInMap("UsergroupDesc")]
                [Validation(Required=false)]
                public string UsergroupDesc { get; set; }

                /// <summary>
                /// The ID of the user group.
                /// </summary>
                [NameInMap("UsergroupId")]
                [Validation(Required=false)]
                public string UsergroupId { get; set; }

                /// <summary>
                /// The name of the user group.
                /// </summary>
                [NameInMap("UsergroupName")]
                [Validation(Required=false)]
                public string UsergroupName { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
