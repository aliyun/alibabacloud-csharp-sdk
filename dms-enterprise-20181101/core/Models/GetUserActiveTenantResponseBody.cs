// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetUserActiveTenantResponseBody : TeaModel {
        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**: The request is successful.
        /// *   **false**: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The details of the tenant.
        /// </summary>
        [NameInMap("Tenant")]
        [Validation(Required=false)]
        public GetUserActiveTenantResponseBodyTenant Tenant { get; set; }
        public class GetUserActiveTenantResponseBodyTenant : TeaModel {
            /// <summary>
            /// The status of the tenant. Valid values:
            /// 
            /// *   **ACTIVE**: The tenant is used to access DMS.
            /// *   **IN_ACTIVE**: The tenant is not used.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The name of the tenant.
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// The ID of the tenant.
            /// </summary>
            [NameInMap("Tid")]
            [Validation(Required=false)]
            public long? Tid { get; set; }

        }

    }

}
