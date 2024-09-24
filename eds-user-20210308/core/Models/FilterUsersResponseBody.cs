// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class FilterUsersResponseBody : TeaModel {
        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. If not all results are returned in a query, a value is returned for the NextToken parameter. In this case, you can use the returned NextToken value to start the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the convenience user.
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<FilterUsersResponseBodyUsers> Users { get; set; }
        public class FilterUsersResponseBodyUsers : TeaModel {
            [NameInMap("AutoLockTime")]
            [Validation(Required=false)]
            public string AutoLockTime { get; set; }

            /// <summary>
            /// The number of cloud desktops that are assigned to the convenience user.
            /// </summary>
            [NameInMap("DesktopCount")]
            [Validation(Required=false)]
            public long? DesktopCount { get; set; }

            /// <summary>
            /// The number of cloud desktop pools that are assigned to the convenience user. This value is returned if you set `IncludeDesktopGroupCount` to `true`.
            /// </summary>
            [NameInMap("DesktopGroupCount")]
            [Validation(Required=false)]
            public long? DesktopGroupCount { get; set; }

            /// <summary>
            /// The email address of the convenience user.
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// Indicates whether the convenience user is a local administrator.
            /// 
            /// Valid values:
            /// 
            /// *   true
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   false
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("EnableAdminAccess")]
            [Validation(Required=false)]
            public bool? EnableAdminAccess { get; set; }

            /// <summary>
            /// The username of the convenience user.
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// The additional information about the convenience user.
            /// </summary>
            [NameInMap("ExternalInfo")]
            [Validation(Required=false)]
            public FilterUsersResponseBodyUsersExternalInfo ExternalInfo { get; set; }
            public class FilterUsersResponseBodyUsersExternalInfo : TeaModel {
                /// <summary>
                /// The account that is associated with the convenience user.
                /// </summary>
                [NameInMap("ExternalName")]
                [Validation(Required=false)]
                public string ExternalName { get; set; }

                /// <summary>
                /// The account, student ID, or employee ID that is associated with the convenience user.
                /// </summary>
                [NameInMap("JobNumber")]
                [Validation(Required=false)]
                public string JobNumber { get; set; }

            }

            /// <summary>
            /// The ID of the convenience user.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// Indicates whether the convenience user is a tenant administrator.
            /// 
            /// Valid values:
            /// 
            /// *   true
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   false
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("IsTenantManager")]
            [Validation(Required=false)]
            public bool? IsTenantManager { get; set; }

            /// <summary>
            /// The type of the account ownership.
            /// 
            /// Valid values:
            /// 
            /// *   CreateFromManager: administrator-activated
            /// *   Normal: user-activated
            /// </summary>
            [NameInMap("OwnerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            [NameInMap("PasswordExpireDays")]
            [Validation(Required=false)]
            public int? PasswordExpireDays { get; set; }

            [NameInMap("PasswordExpireRestDays")]
            [Validation(Required=false)]
            public int? PasswordExpireRestDays { get; set; }

            /// <summary>
            /// The mobile number of the convenience user.
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// The nickname of the convenience user.
            /// </summary>
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
            /// The information about the properties.
            /// </summary>
            [NameInMap("UserSetPropertiesModels")]
            [Validation(Required=false)]
            public List<FilterUsersResponseBodyUsersUserSetPropertiesModels> UserSetPropertiesModels { get; set; }
            public class FilterUsersResponseBodyUsersUserSetPropertiesModels : TeaModel {
                /// <summary>
                /// The property ID.
                /// </summary>
                [NameInMap("PropertyId")]
                [Validation(Required=false)]
                public long? PropertyId { get; set; }

                /// <summary>
                /// The property name.
                /// </summary>
                [NameInMap("PropertyKey")]
                [Validation(Required=false)]
                public string PropertyKey { get; set; }

                /// <summary>
                /// The property type.
                /// </summary>
                [NameInMap("PropertyType")]
                [Validation(Required=false)]
                public int? PropertyType { get; set; }

                /// <summary>
                /// The property values.
                /// </summary>
                [NameInMap("PropertyValues")]
                [Validation(Required=false)]
                public List<FilterUsersResponseBodyUsersUserSetPropertiesModelsPropertyValues> PropertyValues { get; set; }
                public class FilterUsersResponseBodyUsersUserSetPropertiesModelsPropertyValues : TeaModel {
                    /// <summary>
                    /// The property value.
                    /// </summary>
                    [NameInMap("PropertyValue")]
                    [Validation(Required=false)]
                    public string PropertyValue { get; set; }

                    /// <summary>
                    /// The ID of the property value.
                    /// </summary>
                    [NameInMap("PropertyValueId")]
                    [Validation(Required=false)]
                    public long? PropertyValueId { get; set; }

                }

                /// <summary>
                /// The ID of the convenience user that is bound to the property.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                /// <summary>
                /// The username of the convenience user that is bound to the property.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

    }

}
