// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeUsersResponseBody : TeaModel {
        /// <summary>
        /// The token that determines the start point of the next query. If this parameter is left empty, all results are returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the convenience users.
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<DescribeUsersResponseBodyUsers> Users { get; set; }
        public class DescribeUsersResponseBodyUsers : TeaModel {
            /// <summary>
            /// The work address of the convenience user.
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// The profile picture of the convenience user.
            /// </summary>
            [NameInMap("Avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }

            /// <summary>
            /// The email address of the convenience user.
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// The username of the convenience user.
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            [NameInMap("Extras")]
            [Validation(Required=false)]
            public DescribeUsersResponseBodyUsersExtras Extras { get; set; }
            public class DescribeUsersResponseBodyUsersExtras : TeaModel {
                [NameInMap("AssignedResourceCount")]
                [Validation(Required=false)]
                public Dictionary<string, object> AssignedResourceCount { get; set; }

            }

            /// <summary>
            /// The user groups to which the convenience user belongs.
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<DescribeUsersResponseBodyUsersGroups> Groups { get; set; }
            public class DescribeUsersResponseBodyUsersGroups : TeaModel {
                /// <summary>
                /// The ID of the user group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The name of the user group.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

            /// <summary>
            /// The ID of the convenience user.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// Indicates whether the convenience user is an administrator. If the convenience user is of the administrator-activated type, you must specify a user administrator. Notifications such as password reset on a client are sent to the email address or mobile number of the user administrator. For more information, see [Create a convenience user](https://help.aliyun.com/document_detail/214472.html).
            /// </summary>
            [NameInMap("IsTenantManager")]
            [Validation(Required=false)]
            public bool? IsTenantManager { get; set; }

            /// <summary>
            /// The employee number of the convenience user.
            /// </summary>
            [NameInMap("JobNumber")]
            [Validation(Required=false)]
            public string JobNumber { get; set; }

            /// <summary>
            /// The nickname of the convenience user.
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// The ID of the organization to which the convenience user belongs.
            /// 
            /// >  This parameter will be deprecated in the future.
            /// </summary>
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            /// <summary>
            /// The organizations to which the convenience user belongs.
            /// </summary>
            [NameInMap("Orgs")]
            [Validation(Required=false)]
            public List<DescribeUsersResponseBodyUsersOrgs> Orgs { get; set; }
            public class DescribeUsersResponseBodyUsersOrgs : TeaModel {
                /// <summary>
                /// The organization ID.
                /// </summary>
                [NameInMap("OrgId")]
                [Validation(Required=false)]
                public string OrgId { get; set; }

                /// <summary>
                /// The organization name.
                /// </summary>
                [NameInMap("OrgName")]
                [Validation(Required=false)]
                public string OrgName { get; set; }

            }

            /// <summary>
            /// The type of the convenience account.
            /// 
            /// *   Administrator-activated type: The administrator specifies the username and password of the convenience account. User notifications such as password reset notifications are sent to the email address or mobile number of the administrator.
            /// *   User-activated type: The administrator specifies the username and the email address or mobile number of a convenience user. Notifications such as activation notifications that contain the default password are sent to the email address or mobile number of the convenience user.
            /// 
            /// Valid values:
            /// 
            /// *   CreateFromManager
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     administrator-activated
            /// 
            ///     <!-- -->
            /// 
            /// *   Normal
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     user-activated
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("OwnerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            /// <summary>
            /// The mobile number of the convenience user. If you leave this parameter empty, the value of this parameter is not returned.
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("RealNickName")]
            [Validation(Required=false)]
            public string RealNickName { get; set; }

            /// <summary>
            /// The remarks on the convenience user.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// The status of the convenience user.
            /// 
            /// Valid values:
            /// 
            /// *   0: The convenience user is normal.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   9: The convenience user is locked.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// The globally unique ID of the convenience user.
            /// </summary>
            [NameInMap("WyId")]
            [Validation(Required=false)]
            public string WyId { get; set; }

        }

    }

}
