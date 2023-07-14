// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class AppendInstancesToPrometheusGlobalViewResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the array object.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AppendInstancesToPrometheusGlobalViewResponseBodyData Data { get; set; }
        public class AppendInstancesToPrometheusGlobalViewResponseBodyData : TeaModel {
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
            /// Indicates whether the call was successful. Valid values:
            /// 
            /// *   `true`: The call was successful.
            /// *   `false`: The call failed.
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

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
