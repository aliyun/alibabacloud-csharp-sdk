// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListUsersResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the response is truncated. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// The parameter that is used to obtain the truncated part. It takes effect only when `IsTruncated` is set to `true`.
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the information about the RAM user.
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public ListUsersResponseBodyUsers Users { get; set; }
        public class ListUsersResponseBodyUsers : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<ListUsersResponseBodyUsersUser> User { get; set; }
            public class ListUsersResponseBodyUsersUser : TeaModel {
                /// <summary>
                /// The description.
                /// </summary>
                [NameInMap("Comments")]
                [Validation(Required=false)]
                public string Comments { get; set; }

                /// <summary>
                /// The time when the RAM user was created.
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                /// <summary>
                /// The display name of the RAM user.
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// The email address of the RAM user.
                /// 
                /// >  This parameter is valid only on the China site (aliyun.com).
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// The last time when the RAM user logged on to the Alibaba Cloud Management Console.
                /// </summary>
                [NameInMap("LastLoginDate")]
                [Validation(Required=false)]
                public string LastLoginDate { get; set; }

                /// <summary>
                /// The mobile phone number of the RAM user.
                /// 
                /// >  This parameter is valid only on the China site (aliyun.com).
                /// </summary>
                [NameInMap("MobilePhone")]
                [Validation(Required=false)]
                public string MobilePhone { get; set; }

                /// <summary>
                /// The source of the RAM user. Valid values:
                /// 
                /// *   Manual: The RAM user is manually created in the RAM console.
                /// *   SCIM: The RAM user is mapped by using System for Cross-domain Identity Management (SCIM).
                /// *   CloudSSO: The RAM user is mapped from a CloudSSO user.
                /// </summary>
                [NameInMap("ProvisionType")]
                [Validation(Required=false)]
                public string ProvisionType { get; set; }

                /// <summary>
                /// An array that consists of tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public ListUsersResponseBodyUsersUserTags Tags { get; set; }
                public class ListUsersResponseBodyUsersUserTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<ListUsersResponseBodyUsersUserTagsTag> Tag { get; set; }
                    public class ListUsersResponseBodyUsersUserTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// The time when the information about the RAM user was updated.
                /// </summary>
                [NameInMap("UpdateDate")]
                [Validation(Required=false)]
                public string UpdateDate { get; set; }

                /// <summary>
                /// The ID of the RAM user.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// The logon name of the RAM user.
                /// </summary>
                [NameInMap("UserPrincipalName")]
                [Validation(Required=false)]
                public string UserPrincipalName { get; set; }

            }

        }

    }

}
