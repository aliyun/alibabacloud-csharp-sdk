// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryMonitorResponseBody : TeaModel {
        /// <summary>
        /// The data structure.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryMonitorResponseBodyData> Data { get; set; }
        public class QueryMonitorResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("clusterNamePrefix")]
            [Validation(Required=false)]
            public string ClusterNamePrefix { get; set; }

            /// <summary>
            /// The request was successfully processed.
            /// </summary>
            [NameInMap("podName")]
            [Validation(Required=false)]
            public string PodName { get; set; }

            /// <summary>
            /// The details of the data.
            /// </summary>
            [NameInMap("values")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Values { get; set; }

        }

        /// <summary>
        /// The name of the pod.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The interval between data points. Unit: seconds.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
