// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgUserGroupAddOrUpdateRequest : TeaModel {
        /// <summary>
        /// The information about the user group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserGroups")]
        [Validation(Required=false)]
        public List<DsgUserGroupAddOrUpdateRequestUserGroups> UserGroups { get; set; }
        public class DsgUserGroupAddOrUpdateRequestUserGroups : TeaModel {
            /// <summary>
            /// The users in the group.
            /// 
            /// *   If a user group is created by using an Alibaba Cloud account and a RAM role, you can call the [DsgUserGroupQueryUserList](https://help.aliyun.com/document_detail/2786445.html) operation to query the users in the group.
            /// *   If a user group is created by using a MaxCompute role, you can call the [DsgUserGroupQueryUserList](https://help.aliyun.com/document_detail/2785695.html) operation to query the users in the group.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Accounts")]
            [Validation(Required=false)]
            public List<string> Accounts { get; set; }

            /// <summary>
            /// The user group ID.
            /// 
            /// *   If you do not configure this parameter, the current operation is to add a user group.
            /// *   If you configure this parameter, the current operation is to modify a user group. You can call the [DsgUserGroupQueryList](https://help.aliyun.com/document_detail/2786441.html) operation to query the user group ID.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the user group.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The owner of the user group.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// The name of the MaxCompute project. You must configure this parameter when you create a MaxCompute user group.
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// The type of the user group. Valid values:
            /// 
            /// *   1: Alibaba Cloud account
            /// *   2: RAM role
            /// *   3: MaxCompute role
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("UserGroupType")]
            [Validation(Required=false)]
            public int? UserGroupType { get; set; }

        }

    }

}
