// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeUsersInGroupResponseBody : TeaModel {
        /// <summary>
        /// The list of authorized users.
        /// </summary>
        [NameInMap("EndUsers")]
        [Validation(Required=false)]
        public List<DescribeUsersInGroupResponseBodyEndUsers> EndUsers { get; set; }
        public class DescribeUsersInGroupResponseBodyEndUsers : TeaModel {
            /// <summary>
            /// The connection status.
            /// 
            /// Valid values:
            /// 
            /// *   0: disconnected
            /// *   1: connecting
            /// </summary>
            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            /// <summary>
            /// The ID of the cloud computer.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// The name of the cloud computer.
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// The display name of the enterprise AD account.
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// The email address of the authorized user.
            /// </summary>
            [NameInMap("EndUserEmail")]
            [Validation(Required=false)]
            public string EndUserEmail { get; set; }

            /// <summary>
            /// The ID of the authorized user.
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// The username of the authorized user.
            /// </summary>
            [NameInMap("EndUserName")]
            [Validation(Required=false)]
            public string EndUserName { get; set; }

            /// <summary>
            /// The mobile number of the authorized user.
            /// </summary>
            [NameInMap("EndUserPhone")]
            [Validation(Required=false)]
            public string EndUserPhone { get; set; }

            /// <summary>
            /// The remarks.
            /// </summary>
            [NameInMap("EndUserRemark")]
            [Validation(Required=false)]
            public string EndUserRemark { get; set; }

            /// <summary>
            /// The user account type.
            /// 
            /// Valid values:
            /// 
            /// *   SIMPLE: convenience account
            /// *   AD_CONNECTOR: enterprise Active Directory (AD) account
            /// </summary>
            [NameInMap("EndUserType")]
            [Validation(Required=false)]
            public string EndUserType { get; set; }

            /// <summary>
            /// The appended information.
            /// </summary>
            [NameInMap("ExternalInfo")]
            [Validation(Required=false)]
            public DescribeUsersInGroupResponseBodyEndUsersExternalInfo ExternalInfo { get; set; }
            public class DescribeUsersInGroupResponseBodyEndUsersExternalInfo : TeaModel {
                /// <summary>
                /// The external name.
                /// </summary>
                [NameInMap("ExternalName")]
                [Validation(Required=false)]
                public string ExternalName { get; set; }

                /// <summary>
                /// The employee ID.
                /// </summary>
                [NameInMap("JobNumber")]
                [Validation(Required=false)]
                public string JobNumber { get; set; }

            }

            /// <summary>
            /// The ID of the cloud computer that is used by the user.
            /// </summary>
            [NameInMap("UserDesktopId")]
            [Validation(Required=false)]
            public string UserDesktopId { get; set; }

            /// <summary>
            /// Details about the seats of users.
            /// </summary>
            [NameInMap("UserSetPropertiesModels")]
            [Validation(Required=false)]
            public List<DescribeUsersInGroupResponseBodyEndUsersUserSetPropertiesModels> UserSetPropertiesModels { get; set; }
            public class DescribeUsersInGroupResponseBodyEndUsersUserSetPropertiesModels : TeaModel {
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
                /// 
                /// Valid values:
                /// 
                /// *   1: system property
                /// *   2: custom property
                /// </summary>
                [NameInMap("PropertyType")]
                [Validation(Required=false)]
                public int? PropertyType { get; set; }

                /// <summary>
                /// Details about property values.
                /// </summary>
                [NameInMap("PropertyValues")]
                [Validation(Required=false)]
                public List<DescribeUsersInGroupResponseBodyEndUsersUserSetPropertiesModelsPropertyValues> PropertyValues { get; set; }
                public class DescribeUsersInGroupResponseBodyEndUsersUserSetPropertiesModelsPropertyValues : TeaModel {
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
                /// The user ID.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                /// <summary>
                /// The username.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

        /// <summary>
        /// The token that is used to start the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The total number of authorized users that is connected to cloud computers in the cloud computer pool.
        /// </summary>
        [NameInMap("OnlineUsersCount")]
        [Validation(Required=false)]
        public int? OnlineUsersCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of authorized users of the cloud computer pool.
        /// </summary>
        [NameInMap("UsersCount")]
        [Validation(Required=false)]
        public int? UsersCount { get; set; }

    }

}
