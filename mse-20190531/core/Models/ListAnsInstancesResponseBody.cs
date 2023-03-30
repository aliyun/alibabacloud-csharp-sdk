// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListAnsInstancesResponseBody : TeaModel {
        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAnsInstancesResponseBodyData> Data { get; set; }
        public class ListAnsInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the application.
            /// </summary>
            [NameInMap("App")]
            [Validation(Required=false)]
            public string App { get; set; }

            /// <summary>
            /// The name of the cluster.
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// The reference key.
            /// </summary>
            [NameInMap("DatumKey")]
            [Validation(Required=false)]
            public string DatumKey { get; set; }

            /// <summary>
            /// The default key.
            /// </summary>
            [NameInMap("DefaultKey")]
            [Validation(Required=false)]
            public string DefaultKey { get; set; }

            /// <summary>
            /// The effective status of the instance. Valid values:
            /// 
            /// *   `true`: The instance takes effect.
            /// *   `false`: The instance does not take effect.
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// Indicates whether the information about the ephemeral node is obtained. Valid values:
            /// 
            /// *   `true`: yes
            /// *   `false`: no
            /// </summary>
            [NameInMap("Ephemeral")]
            [Validation(Required=false)]
            public bool? Ephemeral { get; set; }

            /// <summary>
            /// The number of counted failures.
            /// </summary>
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            /// <summary>
            /// The health status of the instance. Valid values:
            /// 
            /// *   `true`: The instance is healthy.
            /// *   `false`: The instance is unhealthy.
            /// </summary>
            [NameInMap("Healthy")]
            [Validation(Required=false)]
            public bool? Healthy { get; set; }

            /// <summary>
            /// The heartbeat interval of the instance. Unit: seconds.
            /// </summary>
            [NameInMap("InstanceHeartBeatInterval")]
            [Validation(Required=false)]
            public int? InstanceHeartBeatInterval { get; set; }

            /// <summary>
            /// The timeout period of the instance heartbeat.
            /// </summary>
            [NameInMap("InstanceHeartBeatTimeOut")]
            [Validation(Required=false)]
            public int? InstanceHeartBeatTimeOut { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The public IP address.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The timeout period for removing an IP address.
            /// </summary>
            [NameInMap("IpDeleteTimeout")]
            [Validation(Required=false)]
            public int? IpDeleteTimeout { get; set; }

            /// <summary>
            /// The last heartbeat time.
            /// </summary>
            [NameInMap("LastBeat")]
            [Validation(Required=false)]
            public long? LastBeat { get; set; }

            /// <summary>
            /// Indicates whether the instance was marked. Valid values:
            /// 
            /// *   `true`: The instance marking was successful.
            /// *   `false`: The instance marking failed.
            /// </summary>
            [NameInMap("Marked")]
            [Validation(Required=false)]
            public bool? Marked { get; set; }

            /// <summary>
            /// The metadata.
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// The number of counted successes.
            /// </summary>
            [NameInMap("OkCount")]
            [Validation(Required=false)]
            public int? OkCount { get; set; }

            /// <summary>
            /// The port number.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The name of the service.
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// The weight.
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of returned instances.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
