// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ClearDeviceDesiredPropertyResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see the "**Error codes**" section of this topic.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned if the call is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ClearDeviceDesiredPropertyResponseBodyData Data { get; set; }
        public class ClearDeviceDesiredPropertyResponseBodyData : TeaModel {
            /// <summary>
            /// The latest version of the desired values of the properties after you call this operation to delete the specified desired property values.
            /// </summary>
            [NameInMap("Versions")]
            [Validation(Required=false)]
            public string Versions { get; set; }

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
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
