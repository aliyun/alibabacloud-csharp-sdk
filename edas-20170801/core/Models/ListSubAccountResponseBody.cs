// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListSubAccountResponseBody : TeaModel {
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

        /// <summary>
        /// The RAM users.
        /// </summary>
        [NameInMap("SubAccountList")]
        [Validation(Required=false)]
        public ListSubAccountResponseBodySubAccountList SubAccountList { get; set; }
        public class ListSubAccountResponseBodySubAccountList : TeaModel {
            [NameInMap("SubAccount")]
            [Validation(Required=false)]
            public List<ListSubAccountResponseBodySubAccountListSubAccount> SubAccount { get; set; }
            public class ListSubAccountResponseBodySubAccountListSubAccount : TeaModel {
                /// <summary>
                /// The ID of the Alibaba Cloud account. This ID is generated by EDAS.
                /// </summary>
                [NameInMap("AdminEdasId")]
                [Validation(Required=false)]
                public string AdminEdasId { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account.
                /// </summary>
                [NameInMap("AdminUserId")]
                [Validation(Required=false)]
                public string AdminUserId { get; set; }

                /// <summary>
                /// This parameter is the same as the AdminEdasId parameter. This parameter is deprecated.
                /// </summary>
                [NameInMap("AdminUserKp")]
                [Validation(Required=false)]
                public string AdminUserKp { get; set; }

                /// <summary>
                /// The email address of the RAM user.
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// The contact information of the RAM user.
                /// </summary>
                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// The ID of the RAM user. This ID is generated by Enterprise Distributed Application Service (EDAS).
                /// </summary>
                [NameInMap("SubEdasId")]
                [Validation(Required=false)]
                public string SubEdasId { get; set; }

                /// <summary>
                /// The ID of the RAM user.
                /// </summary>
                [NameInMap("SubUserId")]
                [Validation(Required=false)]
                public string SubUserId { get; set; }

                /// <summary>
                /// This parameter is the same as the SubEdasId parameter. This parameter is deprecated.
                /// </summary>
                [NameInMap("SubUserKp")]
                [Validation(Required=false)]
                public string SubUserKp { get; set; }

            }

        }

    }

}
