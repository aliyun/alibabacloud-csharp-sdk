// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetPrometheusIntegrationResponseBody : TeaModel {
        /// <summary>
        /// The status code. The status code 200 indicates that the request was successful. If another status code is returned, the request failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The struct returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPrometheusIntegrationResponseBodyData Data { get; set; }
        public class GetPrometheusIntegrationResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the exporter can be deleted.
            /// </summary>
            [NameInMap("CanDelete")]
            [Validation(Required=false)]
            public bool? CanDelete { get; set; }

            /// <summary>
            /// Indicates whether the exporter can be modified.
            /// </summary>
            [NameInMap("CanEditor")]
            [Validation(Required=false)]
            public bool? CanEditor { get; set; }

            /// <summary>
            /// The ID of the Prometheus instance.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The container name.
            /// </summary>
            [NameInMap("ContainerName")]
            [Validation(Required=false)]
            public string ContainerName { get; set; }

            /// <summary>
            /// The description of the exporter.
            /// </summary>
            [NameInMap("Describe")]
            [Validation(Required=false)]
            public string Describe { get; set; }

            /// <summary>
            /// The type of the exporter.
            /// </summary>
            [NameInMap("ExporterType")]
            [Validation(Required=false)]
            public string ExporterType { get; set; }

            /// <summary>
            /// The exporter ID.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// The name of the exporter.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The type of the integration.
            /// </summary>
            [NameInMap("IntegrationType")]
            [Validation(Required=false)]
            public string IntegrationType { get; set; }

            /// <summary>
            /// The namespace.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// Indicates whether an upgrade is required.
            /// </summary>
            [NameInMap("NeedUpgrade")]
            [Validation(Required=false)]
            public bool? NeedUpgrade { get; set; }

            /// <summary>
            /// The configurations of the exporter. The value is a JSON string.
            /// </summary>
            [NameInMap("Param")]
            [Validation(Required=false)]
            public string Param { get; set; }

            /// <summary>
            /// Indicates whether the description is displayed.
            /// </summary>
            [NameInMap("ShowDescribe")]
            [Validation(Required=false)]
            public bool? ShowDescribe { get; set; }

            /// <summary>
            /// Indicates whether the exporter logs are displayed.
            /// </summary>
            [NameInMap("ShowLog")]
            [Validation(Required=false)]
            public string ShowLog { get; set; }

            /// <summary>
            /// The status of the exporter.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The monitored IP address.
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// The version information.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// The message returned.
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
