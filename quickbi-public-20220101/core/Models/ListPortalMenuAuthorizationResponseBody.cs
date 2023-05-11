// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListPortalMenuAuthorizationResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of authorization details of the portal menu.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListPortalMenuAuthorizationResponseBodyResult> Result { get; set; }
        public class ListPortalMenuAuthorizationResponseBodyResult : TeaModel {
            /// <summary>
            /// The menu ID of the BI portal leaf node.
            /// </summary>
            [NameInMap("MenuId")]
            [Validation(Required=false)]
            public string MenuId { get; set; }

            /// <summary>
            /// The details of the object to which the menu is authorized.
            /// </summary>
            [NameInMap("Receivers")]
            [Validation(Required=false)]
            public List<ListPortalMenuAuthorizationResponseBodyResultReceivers> Receivers { get; set; }
            public class ListPortalMenuAuthorizationResponseBodyResultReceivers : TeaModel {
                /// <summary>
                /// The ID of the authorization object.
                /// </summary>
                [NameInMap("ReceiverId")]
                [Validation(Required=false)]
                public string ReceiverId { get; set; }

                /// <summary>
                /// The type of the authorization object. Valid values:
                /// 
                /// *   0: user
                /// *   1: user group
                /// </summary>
                [NameInMap("ReceiverType")]
                [Validation(Required=false)]
                public int? ReceiverType { get; set; }

            }

            /// <summary>
            /// Whether only authorization is visible. Valid values:
            /// 
            /// *   true: Only the authorization is visible.
            /// *   false: Both are visible.
            /// </summary>
            [NameInMap("ShowOnlyWithAccess")]
            [Validation(Required=false)]
            public bool? ShowOnlyWithAccess { get; set; }

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
