// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowCooperatorsResponseBody : TeaModel {
        /// <summary>
        /// The users that are involved in the task flow.
        /// </summary>
        [NameInMap("CooperatorList")]
        [Validation(Required=false)]
        public ListTaskFlowCooperatorsResponseBodyCooperatorList CooperatorList { get; set; }
        public class ListTaskFlowCooperatorsResponseBodyCooperatorList : TeaModel {
            [NameInMap("Cooperator")]
            [Validation(Required=false)]
            public List<ListTaskFlowCooperatorsResponseBodyCooperatorListCooperator> Cooperator { get; set; }
            public class ListTaskFlowCooperatorsResponseBodyCooperatorListCooperator : TeaModel {
                /// <summary>
                /// The email address of the user.
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// The username.
                /// </summary>
                [NameInMap("LoginName")]
                [Validation(Required=false)]
                public string LoginName { get; set; }

                /// <summary>
                /// The alias of the user.
                /// </summary>
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request. You can use the ID to locate logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
