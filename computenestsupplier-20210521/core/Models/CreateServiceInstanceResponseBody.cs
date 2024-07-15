// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class CreateServiceInstanceResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the service instance.
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        /// <summary>
        /// The status of the service instance. Valid values:
        /// 
        /// *   Created
        /// *   Deploying
        /// *   DeployedFailed
        /// *   Deployed
        /// *   Upgrading
        /// *   Deleting
        /// *   Deleted
        /// *   DeletedFailed
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
