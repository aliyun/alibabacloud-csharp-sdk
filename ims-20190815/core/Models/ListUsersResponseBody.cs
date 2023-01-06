// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListUsersResponseBody : TeaModel {
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public ListUsersResponseBodyUsers Users { get; set; }
        public class ListUsersResponseBodyUsers : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<ListUsersResponseBodyUsersUser> User { get; set; }
            public class ListUsersResponseBodyUsersUser : TeaModel {
                [NameInMap("Comments")]
                [Validation(Required=false)]
                public string Comments { get; set; }

                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("LastLoginDate")]
                [Validation(Required=false)]
                public string LastLoginDate { get; set; }

                [NameInMap("MobilePhone")]
                [Validation(Required=false)]
                public string MobilePhone { get; set; }

                [NameInMap("ProvisionType")]
                [Validation(Required=false)]
                public string ProvisionType { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public ListUsersResponseBodyUsersUserTags Tags { get; set; }
                public class ListUsersResponseBodyUsersUserTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<ListUsersResponseBodyUsersUserTagsTag> Tag { get; set; }
                    public class ListUsersResponseBodyUsersUserTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                [NameInMap("UpdateDate")]
                [Validation(Required=false)]
                public string UpdateDate { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("UserPrincipalName")]
                [Validation(Required=false)]
                public string UserPrincipalName { get; set; }

            }

        }

    }

}
