// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteFileResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request. You can troubleshoot errors based on the ID.
        /// </summary>
        [NameInMap("DeploymentId")]
        [Validation(Required=false)]
        public long? DeploymentId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   true: The request is successful.
        /// *   false: The request fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the deployment task that deploys the file. If the file has been committed, an asynchronous process is triggered to delete the file in the scheduling system. The value of this parameter is used to call the GetDeployment operation to poll the status of the asynchronous process.
        /// 
        /// If this parameter is empty, the file is deleted and the polling is not required.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
