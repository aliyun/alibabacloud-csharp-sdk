// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class MakeTaskFlowInstanceSuccessRequest : TeaModel {
        /// <summary>
        /// The ID of the request. You can use the ID to query logs and troubleshoot issues.
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// {
        ///     "RequestId": "028BF827-3801-5869-8548-F4A039256304",
        ///     "ErrorCode": "UnknownError",
        ///     "ErrorMessage": "UnknownError",
        ///     "Success": true
        /// }
        /// </summary>
        [NameInMap("DagInstanceId")]
        [Validation(Required=false)]
        public long? DagInstanceId { get; set; }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
