// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CheckCloudResourceAuthorizedResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether KMS keys are authorized to ApsaraDB for MongoDB instances. Valid values:
        /// 
        /// *   **0**: KMS keys are not authorized.
        /// *   **1**: KMS keys are authorized.
        /// *   **2**: KMS is not enabled.
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

        /// <summary>
        /// The role information of the authorized Alibaba Resource Name (ARN).
        /// 
        /// >  This parameter is returned only when the value of the **AuthorizationState** parameter is **1**.
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

    }

}
