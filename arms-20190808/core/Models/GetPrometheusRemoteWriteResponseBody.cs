// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetPrometheusRemoteWriteResponseBody : TeaModel {
        /// <summary>
        /// The status code returned. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The queried remote write configuration.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPrometheusRemoteWriteResponseBodyData Data { get; set; }
        public class GetPrometheusRemoteWriteResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the Prometheus instance.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The name of the remote write configuration.
            /// </summary>
            [NameInMap("RemoteWriteName")]
            [Validation(Required=false)]
            public string RemoteWriteName { get; set; }

            /// <summary>
            /// The remote write configuration. The configuration is displayed in the YAML format.
            /// </summary>
            [NameInMap("RemoteWriteYaml")]
            [Validation(Required=false)]
            public string RemoteWriteYaml { get; set; }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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

}
