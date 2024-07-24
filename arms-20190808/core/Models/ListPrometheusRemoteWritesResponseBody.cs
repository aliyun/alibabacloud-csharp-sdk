// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListPrometheusRemoteWritesResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned. The HTTP status code 200 indicates that the call was successful. Otherwise, the call fails.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The remote write configuration items returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListPrometheusRemoteWritesResponseBodyData> Data { get; set; }
        public class ListPrometheusRemoteWritesResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the Prometheus instance.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The name of the remote write configuration item.
            /// </summary>
            [NameInMap("RemoteWriteName")]
            [Validation(Required=false)]
            public string RemoteWriteName { get; set; }

            /// <summary>
            /// The information about the queried remote write configuration item of the Prometheus instance. The information is displayed in the YAML format.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. Valid values: true and false.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
