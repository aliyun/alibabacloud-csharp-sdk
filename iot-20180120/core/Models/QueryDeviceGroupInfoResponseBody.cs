// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceGroupInfoResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The group details returned if the call succeeds. This parameter includes the following parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceGroupInfoResponseBodyData Data { get; set; }
        public class QueryDeviceGroupInfoResponseBodyData : TeaModel {
            /// <summary>
            /// The number of activated devices.
            /// </summary>
            [NameInMap("DeviceActive")]
            [Validation(Required=false)]
            public int? DeviceActive { get; set; }

            /// <summary>
            /// The total number of devices.
            /// </summary>
            [NameInMap("DeviceCount")]
            [Validation(Required=false)]
            public int? DeviceCount { get; set; }

            /// <summary>
            /// The number of online devices.
            /// </summary>
            [NameInMap("DeviceOnline")]
            [Validation(Required=false)]
            public int? DeviceOnline { get; set; }

            /// <summary>
            /// The rule of the dynamic group. This parameter is returned if a dynamic group is queried.
            /// </summary>
            [NameInMap("DynamicGroupExpression")]
            [Validation(Required=false)]
            public string DynamicGroupExpression { get; set; }

            /// <summary>
            /// The description of the group.
            /// </summary>
            [NameInMap("GroupDesc")]
            [Validation(Required=false)]
            public string GroupDesc { get; set; }

            /// <summary>
            /// The ID of the group.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// The name of the group.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The time when the group was created.
            /// </summary>
            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }

        }

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

    }

}
