// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetThingScriptResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned if the call is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetThingScriptResponseBodyData Data { get; set; }
        public class GetThingScriptResponseBodyData : TeaModel {
            /// <summary>
            /// The type of the script. Valid values:
            /// 
            /// *   JavaScript
            /// *   Python\_27: Python 2.7
            /// *   PHP\_72: PHP 7.2
            /// </summary>
            [NameInMap("ScriptType")]
            [Validation(Required=false)]
            public string ScriptType { get; set; }

            /// <summary>
            /// The URL of the script payload.
            /// </summary>
            [NameInMap("ScriptUrl")]
            [Validation(Required=false)]
            public string ScriptUrl { get; set; }

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
