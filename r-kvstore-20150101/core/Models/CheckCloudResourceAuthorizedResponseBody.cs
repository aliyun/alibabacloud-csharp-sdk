// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CheckCloudResourceAuthorizedResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the instance is authorized to use KMS. Valid values:
        /// 
        /// *   **0**: The instance is authorized to use KMS.
        /// *   **1**: The instance is not authorized to use KMS.
        /// *   **2**: KMS is not activated. For more information, see [Activate KMS](~~153781~~).
        /// </summary>
        [NameInMap("AuthorizationState")]
        [Validation(Required=false)]
        public int? AuthorizationState { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
