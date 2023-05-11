// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserGroupListByParentIdResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the sub-user group.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryUserGroupListByParentIdResponseBodyResult> Result { get; set; }
        public class QueryUserGroupListByParentIdResponseBodyResult : TeaModel {
            /// <summary>
            /// The time when the sub-user group was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The creator of the sub-user group. The UserID of the Quick BI is used instead of the UID of Alibaba Cloud.
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// Directory level of the sub-user group.
            /// </summary>
            [NameInMap("IdentifiedPath")]
            [Validation(Required=false)]
            public string IdentifiedPath { get; set; }

            /// <summary>
            /// The time when the sub-user group was last modified.
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// The user who modified the subgroup. The UserID of the Quick BI is used instead of the UID of Alibaba Cloud.
            /// </summary>
            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            /// <summary>
            /// The ID of the parent user group.
            /// </summary>
            [NameInMap("ParentUserGroupId")]
            [Validation(Required=false)]
            public string ParentUserGroupId { get; set; }

            /// <summary>
            /// The description of the sub-user group.
            /// </summary>
            [NameInMap("UserGroupDescription")]
            [Validation(Required=false)]
            public string UserGroupDescription { get; set; }

            /// <summary>
            /// The ID of the sub-user group.
            /// </summary>
            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

            /// <summary>
            /// The name of the sub-user group.
            /// </summary>
            [NameInMap("UserGroupName")]
            [Validation(Required=false)]
            public string UserGroupName { get; set; }

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
