// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class AddAliClusterIdsToPrometheusGlobalViewResponseBody : TeaModel {
        /// <summary>
        /// Status code. 200 is success, other status codes are exceptions.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the array object.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddAliClusterIdsToPrometheusGlobalViewResponseBodyData Data { get; set; }
        public class AddAliClusterIdsToPrometheusGlobalViewResponseBodyData : TeaModel {
            /// <summary>
            /// The Info-level information.
            /// </summary>
            [NameInMap("Info")]
            [Validation(Required=false)]
            public string Info { get; set; }

            /// <summary>
            /// The additional information.
            /// </summary>
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// Indicates whether the request was successful.
            /// 
            /// *   `true`: The request was successful.
            /// *   `false`: The request failed.
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// Returns a hint message for the result.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID. You can use the ID to query logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
