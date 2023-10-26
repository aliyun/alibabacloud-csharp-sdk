// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEnvServiceMonitorsResponseBody : TeaModel {
        /// <summary>
        /// The status code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListEnvServiceMonitorsResponseBodyData> Data { get; set; }
        public class ListEnvServiceMonitorsResponseBodyData : TeaModel {
            /// <summary>
            /// addon name.
            /// </summary>
            [NameInMap("AddonName")]
            [Validation(Required=false)]
            public string AddonName { get; set; }

            /// <summary>
            /// addon release name.
            /// </summary>
            [NameInMap("AddonReleaseName")]
            [Validation(Required=false)]
            public string AddonReleaseName { get; set; }

            /// <summary>
            /// addon version.
            /// </summary>
            [NameInMap("AddonVersion")]
            [Validation(Required=false)]
            public string AddonVersion { get; set; }

            /// <summary>
            /// yaml configuration string.
            /// </summary>
            [NameInMap("ConfigYaml")]
            [Validation(Required=false)]
            public string ConfigYaml { get; set; }

            /// <summary>
            /// Creation time (timestamp).
            /// </summary>
            [NameInMap("CreationTimestamp")]
            [Validation(Required=false)]
            public string CreationTimestamp { get; set; }

            /// <summary>
            /// List of endpoints for ServiceMonitor.
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public List<ListEnvServiceMonitorsResponseBodyDataEndpoints> Endpoints { get; set; }
            public class ListEnvServiceMonitorsResponseBodyDataEndpoints : TeaModel {
                /// <summary>
                /// scrape interval.
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public string Interval { get; set; }

                /// <summary>
                /// The number of targets matched by servcieMonitor.Endpoint.
                /// </summary>
                [NameInMap("MatchedTargetCount")]
                [Validation(Required=false)]
                public int? MatchedTargetCount { get; set; }

                /// <summary>
                /// metric path.
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// External port.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// Destination port.
                /// </summary>
                [NameInMap("TargetPort")]
                [Validation(Required=false)]
                public int? TargetPort { get; set; }

            }

            /// <summary>
            /// Environment ID.
            /// </summary>
            [NameInMap("EnvironmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// The number of matching services.
            /// </summary>
            [NameInMap("MatchedServiceCount")]
            [Validation(Required=false)]
            public int? MatchedServiceCount { get; set; }

            /// <summary>
            /// The namespace.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// ServiceMonitor name.
            /// </summary>
            [NameInMap("ServiceMonitorName")]
            [Validation(Required=false)]
            public string ServiceMonitorName { get; set; }

            /// <summary>
            /// status.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
