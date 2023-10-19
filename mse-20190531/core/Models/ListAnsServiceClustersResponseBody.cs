// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListAnsServiceClustersResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAnsServiceClustersResponseBodyData Data { get; set; }
        public class ListAnsServiceClustersResponseBodyData : TeaModel {
            /// <summary>
            /// The information about the associated application for which Microservices Governance is enabled when the Source parameter is set to governance.
            /// </summary>
            [NameInMap("AppDetail")]
            [Validation(Required=false)]
            public ListAnsServiceClustersResponseBodyDataAppDetail AppDetail { get; set; }
            public class ListAnsServiceClustersResponseBodyDataAppDetail : TeaModel {
                /// <summary>
                /// The ID of the application for which Microservices Governance is enabled.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The name of the application for which Microservices Governance is enabled.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// The health check interval. Unit: seconds.
                /// </summary>
                [NameInMap("CheckInternal")]
                [Validation(Required=false)]
                public int? CheckInternal { get; set; }

                /// <summary>
                /// The path of the health check. This parameter is required only when the CheckType parameter is set to http.
                /// </summary>
                [NameInMap("CheckPath")]
                [Validation(Required=false)]
                public string CheckPath { get; set; }

                /// <summary>
                /// The timeout period of the health check response. Unit: seconds.
                /// </summary>
                [NameInMap("CheckTimeout")]
                [Validation(Required=false)]
                public int? CheckTimeout { get; set; }

                /// <summary>
                /// The type of the health check. Valid values:
                /// 
                /// *   connection: connection status check
                /// *   tcp: TCP connection check
                /// *   http: HTTP connection check
                /// </summary>
                [NameInMap("CheckType")]
                [Validation(Required=false)]
                public string CheckType { get; set; }

                /// <summary>
                /// The maximum number of health check retries when the instance state changes from unhealthy to healthy.
                /// </summary>
                [NameInMap("HealthyCheckTimes")]
                [Validation(Required=false)]
                public int? HealthyCheckTimes { get; set; }

                /// <summary>
                /// The port number of the application for which Microservices Governance is enabled.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The maximum number of health check retries when the instance state changes from healthy to unhealthy.
                /// </summary>
                [NameInMap("UnhealthyCheckTimes")]
                [Validation(Required=false)]
                public int? UnhealthyCheckTimes { get; set; }

            }

            /// <summary>
            /// The cluster information.
            /// </summary>
            [NameInMap("Clusters")]
            [Validation(Required=false)]
            public List<ListAnsServiceClustersResponseBodyDataClusters> Clusters { get; set; }
            public class ListAnsServiceClustersResponseBodyDataClusters : TeaModel {
                /// <summary>
                /// The default port used for a health check.
                /// </summary>
                [NameInMap("DefaultCheckPort")]
                [Validation(Required=false)]
                public int? DefaultCheckPort { get; set; }

                /// <summary>
                /// The default port.
                /// </summary>
                [NameInMap("DefaultPort")]
                [Validation(Required=false)]
                public int? DefaultPort { get; set; }

                /// <summary>
                /// The type of the health check.
                /// </summary>
                [NameInMap("HealthCheckerType")]
                [Validation(Required=false)]
                public string HealthCheckerType { get; set; }

                /// <summary>
                /// The metadata of the cluster.
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public Dictionary<string, object> Metadata { get; set; }

                /// <summary>
                /// The cluster name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The full name of the service.
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// Indicates whether an end-to-end health check was initiated by the server. This parameter is valid only if the service is not a temporary service.
                /// </summary>
                [NameInMap("UseIPPort4Check")]
                [Validation(Required=false)]
                public bool? UseIPPort4Check { get; set; }

            }

            /// <summary>
            /// Indicates whether the service is a temporary service. Valid values:
            /// 
            /// *   `true`: yes
            /// *   `false`: no
            /// </summary>
            [NameInMap("Ephemeral")]
            [Validation(Required=false)]
            public bool? Ephemeral { get; set; }

            /// <summary>
            /// The service group to which the service belongs.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The metadata of the service.
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// The name of the service.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The protection threshold.
            /// </summary>
            [NameInMap("ProtectThreshold")]
            [Validation(Required=false)]
            public float? ProtectThreshold { get; set; }

            /// <summary>
            /// The election mode.
            /// </summary>
            [NameInMap("SelectorType")]
            [Validation(Required=false)]
            public string SelectorType { get; set; }

            /// <summary>
            /// The source type of the service. Valid values:
            /// 
            /// *   console: The service was registered in the console.
            /// *   sdk: The service was registered by using the SDK.
            /// *   governance: The service was registered on Microservices Governance.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The HTTP status code.
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

    }

}
