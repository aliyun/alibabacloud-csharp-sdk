// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdatePrometheusGlobalViewResponseBody : TeaModel {
        /// <summary>
        /// The response code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdatePrometheusGlobalViewResponseBodyData Data { get; set; }
        public class UpdatePrometheusGlobalViewResponseBodyData : TeaModel {
            /// <summary>
            /// The data sources that failed to be updated.
            /// </summary>
            [NameInMap("FailedInstances")]
            [Validation(Required=false)]
            public List<UpdatePrometheusGlobalViewResponseBodyDataFailedInstances> FailedInstances { get; set; }
            public class UpdatePrometheusGlobalViewResponseBodyDataFailedInstances : TeaModel {
                /// <summary>
                /// The ID of the Prometheus instance.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The name of the data source.
                /// </summary>
                [NameInMap("SourceName")]
                [Validation(Required=false)]
                public string SourceName { get; set; }

                /// <summary>
                /// The type of the data source. AlibabaPrometheus MetricStore CustomPrometheus
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// The user ID.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

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
        /// The error message that is returned if the request failed.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request. You can use the ID to query logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
