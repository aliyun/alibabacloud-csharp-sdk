// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListAuthorityResponseBody : TeaModel {
        /// <summary>
        /// The permissions.
        /// </summary>
        [NameInMap("AuthorityList")]
        [Validation(Required=false)]
        public ListAuthorityResponseBodyAuthorityList AuthorityList { get; set; }
        public class ListAuthorityResponseBodyAuthorityList : TeaModel {
            [NameInMap("Authority")]
            [Validation(Required=false)]
            public List<ListAuthorityResponseBodyAuthorityListAuthority> Authority { get; set; }
            public class ListAuthorityResponseBodyAuthorityListAuthority : TeaModel {
                /// <summary>
                /// The set of permissions.
                /// </summary>
                [NameInMap("ActionList")]
                [Validation(Required=false)]
                public ListAuthorityResponseBodyAuthorityListAuthorityActionList ActionList { get; set; }
                public class ListAuthorityResponseBodyAuthorityListAuthorityActionList : TeaModel {
                    [NameInMap("Action")]
                    [Validation(Required=false)]
                    public List<ListAuthorityResponseBodyAuthorityListAuthorityActionListAction> Action { get; set; }
                    public class ListAuthorityResponseBodyAuthorityListAuthorityActionListAction : TeaModel {
                        /// <summary>
                        /// The code of the permission.
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// The description of the permission.
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// The ID of the permission group.
                        /// </summary>
                        [NameInMap("GroupId")]
                        [Validation(Required=false)]
                        public string GroupId { get; set; }

                        /// <summary>
                        /// The name of the permission.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                /// <summary>
                /// The description of the permission group.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the permission group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The name of the permission group.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
