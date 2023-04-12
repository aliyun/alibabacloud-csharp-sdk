// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteAggregateRemediationsResponseBody : TeaModel {
        /// <summary>
        /// The results of the delete operation.
        /// </summary>
        [NameInMap("RemediationDeleteResults")]
        [Validation(Required=false)]
        public List<DeleteAggregateRemediationsResponseBodyRemediationDeleteResults> RemediationDeleteResults { get; set; }
        public class DeleteAggregateRemediationsResponseBodyRemediationDeleteResults : TeaModel {
            /// <summary>
            /// The error code.
            /// 
            /// *   If the remediation setting is deleted, no error code is returned.
            /// *   If the remediation setting fails to be deleted, an error code is returned. For more information about error codes, visit the [API Error Center](https://error-center.alibabacloud.com/status/product/Config).
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The ID of the remediation setting.
            /// </summary>
            [NameInMap("RemediationId")]
            [Validation(Required=false)]
            public string RemediationId { get; set; }

            /// <summary>
            /// Indicates whether the call is successful. Valid values:
            /// 
            /// *   true: The call is successful.
            /// *   false: The call fails.
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
