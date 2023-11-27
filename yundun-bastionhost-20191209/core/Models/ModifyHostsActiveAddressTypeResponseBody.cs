// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyHostsActiveAddressTypeResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result of the call.
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<ModifyHostsActiveAddressTypeResponseBodyResults> Results { get; set; }
        public class ModifyHostsActiveAddressTypeResponseBodyResults : TeaModel {
            /// <summary>
            /// The return code that indicates whether the call was successful. Valid values:
            /// 
            /// *   **OK**: The call was successful.
            /// *   **UNEXPECTED**: An unknown error occurred.
            /// *   **INVALID_ARGUMENT**: A request parameter is invalid.
            /// *   **OBJECT_NOT_FOUND**: The specified object on which you want to perform the operation does not exist.
            /// *   **OBJECT_AlREADY_EXISTS**: The specified object on which you want to perform the operation already exists.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The ID of the host.
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

    }

}
