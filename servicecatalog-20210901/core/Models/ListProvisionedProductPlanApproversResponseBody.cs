// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ListProvisionedProductPlanApproversResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of reviewers.
        /// </summary>
        [NameInMap("Approvers")]
        [Validation(Required=false)]
        public List<ListProvisionedProductPlanApproversResponseBodyApprovers> Approvers { get; set; }
        public class ListProvisionedProductPlanApproversResponseBodyApprovers : TeaModel {
            /// <summary>
            /// The name of the reviewer.
            /// </summary>
            [NameInMap("PrincipalName")]
            [Validation(Required=false)]
            public string PrincipalName { get; set; }

            /// <summary>
            /// The type of the Resource Access Management (RAM) entity of the reviewer. Valid values:
            /// 
            /// *   RamUser: a RAM user
            /// *   RamRole: a RAM role
            /// </summary>
            [NameInMap("PrincipalType")]
            [Validation(Required=false)]
            public string PrincipalType { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
