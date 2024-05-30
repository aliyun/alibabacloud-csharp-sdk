// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class RemoveAliClusterIdsFromPrometheusGlobalViewResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RemoveAliClusterIdsFromPrometheusGlobalViewResponseBodyData Data { get; set; }
        public class RemoveAliClusterIdsFromPrometheusGlobalViewResponseBodyData : TeaModel {
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
            /// Indicates whether the request was successful. Valid values:
            /// 
            /// *   `true`
            /// *   `false`
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// The message returned.
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
