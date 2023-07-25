// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteRemediationsResponseBody : TeaModel {
        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("RemediationDeleteResults")]
        [Validation(Required=false)]
        public List<DeleteRemediationsResponseBodyRemediationDeleteResults> RemediationDeleteResults { get; set; }
        public class DeleteRemediationsResponseBodyRemediationDeleteResults : TeaModel {
            /// <summary>
            /// The error code returned.
            /// 
            /// *   If the remediation template is deleted, no error code is returned.
            /// *   If the remediation template fails to be deleted, an error code is returned. For more information about error codes, see [Error codes](https://error-center.alibabacloud.com/status/product/Config).
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The ID of the remediation template.
            /// </summary>
            [NameInMap("RemediationId")]
            [Validation(Required=false)]
            public string RemediationId { get; set; }

            /// <summary>
            /// Indicates whether the request was successful. Valid values:
            /// 
            /// *   true: The request was successful.
            /// *   false: The request failed.
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
