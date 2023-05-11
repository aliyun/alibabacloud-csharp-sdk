// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchDeleteDeviceGroupRelationsResponseBody : TeaModel {
        /// <summary>
        /// The number of devices that exist in the group.
        /// </summary>
        [NameInMap("AlreadyRelatedGroupDeviceCount")]
        [Validation(Required=false)]
        public int? AlreadyRelatedGroupDeviceCount { get; set; }

        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message returned if the call fails.
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
        /// Indicates whether the call was successful.
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The number of devices that are removed from the group.
        /// </summary>
        [NameInMap("SuccessDeviceCount")]
        [Validation(Required=false)]
        public int? SuccessDeviceCount { get; set; }

        /// <summary>
        /// The number of valid devices that you specified.
        /// </summary>
        [NameInMap("ValidDeviceCount")]
        [Validation(Required=false)]
        public int? ValidDeviceCount { get; set; }

    }

}
