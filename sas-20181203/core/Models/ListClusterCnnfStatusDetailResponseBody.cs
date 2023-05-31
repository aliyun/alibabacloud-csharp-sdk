// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListClusterCnnfStatusDetailResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the protection status of the container firewall.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListClusterCnnfStatusDetailResponseBodyData> Data { get; set; }
        public class ListClusterCnnfStatusDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the cluster.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// Indicates whether the container firewall plug-in is installed.
            /// </summary>
            [NameInMap("Installed")]
            [Validation(Required=false)]
            public bool? Installed { get; set; }

            /// <summary>
            /// The ID of the server.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The public IP address of the associated instance.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the associated instance.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The cause why the plug-in is invalid. Valid values:
            /// 
            /// *   **PLUGIN_OFFLINE**: The plug-in is offline.
            /// *   **PLUGIN\_NOT_INSTALLED**: The plug-in is not installed.
            /// *   **PLUGIN\_INVALID_VERSION**: The version of the plug-in is invalid.
            /// </summary>
            [NameInMap("InvalidType")]
            [Validation(Required=false)]
            public string InvalidType { get; set; }

            /// <summary>
            /// The name of the server.
            /// </summary>
            [NameInMap("MachineName")]
            [Validation(Required=false)]
            public string MachineName { get; set; }

            /// <summary>
            /// The machine type of the instance. The value is fixed as **ecs**.
            /// </summary>
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public int? MachineType { get; set; }

            /// <summary>
            /// The name of the plug-in. The value is fixed as **alinet**.
            /// </summary>
            [NameInMap("PluginName")]
            [Validation(Required=false)]
            public string PluginName { get; set; }

            /// <summary>
            /// The version of the plug-in.
            /// </summary>
            [NameInMap("PluginVersion")]
            [Validation(Required=false)]
            public string PluginVersion { get; set; }

            /// <summary>
            /// The online status of the plug-in. Valid values:
            /// 
            /// *   **false**: The plug-in is offline.
            /// *   **true**: The plug-in is online.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The UUID of the asset.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
