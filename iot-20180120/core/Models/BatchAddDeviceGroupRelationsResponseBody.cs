// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchAddDeviceGroupRelationsResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the call was successful.
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("AlreadyRelatedGroupDeviceCount")]
        [Validation(Required=false)]
        public int? AlreadyRelatedGroupDeviceCount { get; set; }

        /// <summary>
        /// The number of valid devices that you specified.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The number of devices that exist in the group.
        /// </summary>
        [NameInMap("ExceedTenGroupDeviceCount")]
        [Validation(Required=false)]
        public int? ExceedTenGroupDeviceCount { get; set; }

        /// <summary>
        /// The number of the specified devices that are added to 10 or more groups. You can add a device to a maximum of 10 groups.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("SuccessAddedDeviceCount")]
        [Validation(Required=false)]
        public int? SuccessAddedDeviceCount { get; set; }

        /// <summary>
        /// The number of devices that are added to the group.
        /// </summary>
        [NameInMap("ValidDeviceCount")]
        [Validation(Required=false)]
        public int? ValidDeviceCount { get; set; }

    }

}
