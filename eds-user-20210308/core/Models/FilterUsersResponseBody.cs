// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class FilterUsersResponseBody : TeaModel {
        /// <summary>
        /// The token that is used to query the next page. If not all results are returned in a query, a value is returned for the NextToken parameter. In this case, you can use the returned NextToken value to perform the next query.
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
        /// Details of the convenience users.
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<FilterUsersResponseBodyUsers> Users { get; set; }
        public class FilterUsersResponseBodyUsers : TeaModel {
            /// <summary>
            /// The number of cloud desktops that are assigned to the user.
            /// </summary>
            [NameInMap("DesktopCount")]
            [Validation(Required=false)]
            public long? DesktopCount { get; set; }

            /// <summary>
            /// The number of authorized desktop groups that are owned by the user. This value is returned if you set `IncludeDesktopGroupCount` to `true`.
            /// </summary>
            [NameInMap("DesktopGroupCount")]
            [Validation(Required=false)]
            public long? DesktopGroupCount { get; set; }

            /// <summary>
            /// The email address of the user.
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("EnableAdminAccess")]
            [Validation(Required=false)]
            public bool? EnableAdminAccess { get; set; }

            /// <summary>
            /// The name of the user.
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// The additional information about the user.
            /// </summary>
            [NameInMap("ExternalInfo")]
            [Validation(Required=false)]
            public FilterUsersResponseBodyUsersExternalInfo ExternalInfo { get; set; }
            public class FilterUsersResponseBodyUsersExternalInfo : TeaModel {
                /// <summary>
                /// The name of the external system account to which the user is connected.
                /// </summary>
                [NameInMap("ExternalName")]
                [Validation(Required=false)]
                public string ExternalName { get; set; }

                /// <summary>
                /// The student ID or employee ID of the external system account that is connected to the user.
                /// </summary>
                [NameInMap("JobNumber")]
                [Validation(Required=false)]
                public string JobNumber { get; set; }

            }

            /// <summary>
            /// The ID of the user.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// Specifies whether the user is a tenant administrator.
            /// </summary>
            [NameInMap("IsTenantManager")]
            [Validation(Required=false)]
            public bool? IsTenantManager { get; set; }

            /// <summary>
            /// The type of the account ownership.
            /// </summary>
            [NameInMap("OwnerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            /// <summary>
            /// The mobile number of the user.
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// The remarks of the user.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// The status of the user.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// Details of the user properties.
            /// </summary>
            [NameInMap("UserSetPropertiesModels")]
            [Validation(Required=false)]
            public List<FilterUsersResponseBodyUsersUserSetPropertiesModels> UserSetPropertiesModels { get; set; }
            public class FilterUsersResponseBodyUsersUserSetPropertiesModels : TeaModel {
                /// <summary>
                /// The ID of the property.
                /// </summary>
                [NameInMap("PropertyId")]
                [Validation(Required=false)]
                public long? PropertyId { get; set; }

                /// <summary>
                /// The name of the property.
                /// </summary>
                [NameInMap("PropertyKey")]
                [Validation(Required=false)]
                public string PropertyKey { get; set; }

                /// <summary>
                /// The ID of property.
                /// </summary>
                [NameInMap("PropertyType")]
                [Validation(Required=false)]
                public int? PropertyType { get; set; }

                /// <summary>
                /// Details of the property value.
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
                /// The ID of the user that is bound to the property.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                /// <summary>
                /// The name of the user that is bound to the property.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

    }

}
