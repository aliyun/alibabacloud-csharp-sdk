// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GetWorkerListResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The job information.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWorkerListResponseBodyData Data { get; set; }
        public class GetWorkerListResponseBodyData : TeaModel {
            /// <summary>
            /// The worker information.
            /// </summary>
            [NameInMap("WorkerInfos")]
            [Validation(Required=false)]
            public List<GetWorkerListResponseBodyDataWorkerInfos> WorkerInfos { get; set; }
            public class GetWorkerListResponseBodyDataWorkerInfos : TeaModel {
                /// <summary>
                /// The IP address of the worker.
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// The label of the worker.
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// The port number of the worker.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The startup method of the worker.
                /// </summary>
                [NameInMap("Starter")]
                [Validation(Required=false)]
                public string Starter { get; set; }

                /// <summary>
                /// The version of the worker.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// The address of the worker. The address is in the format of ${worker_id}@${worker_ip}:${worker_port}.
                /// </summary>
                [NameInMap("WorkerAddress")]
                [Validation(Required=false)]
                public string WorkerAddress { get; set; }

            }

        }

        /// <summary>
        /// The additional information that is returned.
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
        /// Indicates whether the call is successful. Valid values:
        /// 
        /// *   **true**: The call is successful.
        /// *   **false**: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
