// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListAnsServiceClustersResponseBody : TeaModel {
        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAnsServiceClustersResponseBodyData Data { get; set; }
        public class ListAnsServiceClustersResponseBodyData : TeaModel {
            /// <summary>
            /// The information about the clusters.
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
                /// The type of health check.
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
                /// The name of the cluster.
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
                /// Indicates whether an end-to-end health check is initiated by the server. This parameter is valid only if the service is a temporary service.
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
            /// The name of the contact group.
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

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

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
