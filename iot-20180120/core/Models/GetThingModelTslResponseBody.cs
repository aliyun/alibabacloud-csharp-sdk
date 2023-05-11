// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetThingModelTslResponseBody : TeaModel {
        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The URI that is used to store the TSL data in Object Storage Service (OSS). The URI is valid for 60 minutes.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetThingModelTslResponseBodyData Data { get; set; }
        public class GetThingModelTslResponseBodyData : TeaModel {
            [NameInMap("TslStr")]
            [Validation(Required=false)]
            public string TslStr { get; set; }

            /// <summary>
            /// The string of the TSL model.
            /// </summary>
            [NameInMap("TslUri")]
            [Validation(Required=false)]
            public string TslUri { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The TSL data returned if the call is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
