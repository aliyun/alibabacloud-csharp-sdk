// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListClusterPluginInfoResponseBody : TeaModel {
        /// <summary>
        /// The information about the plug-in.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListClusterPluginInfoResponseBodyData> Data { get; set; }
        public class ListClusterPluginInfoResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the cluster.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The name of the cluster.
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// The status of the cluster. Valid values:
            /// 
            /// *   1: normal
            /// *   2: abnormal
            /// *   3: offline
            /// </summary>
            [NameInMap("ClusterStatus")]
            [Validation(Required=false)]
            public string ClusterStatus { get; set; }

            /// <summary>
            /// The plug-ins.
            /// </summary>
            [NameInMap("NodePluginInfoList")]
            [Validation(Required=false)]
            public List<ListClusterPluginInfoResponseBodyDataNodePluginInfoList> NodePluginInfoList { get; set; }
            public class ListClusterPluginInfoResponseBodyDataNodePluginInfoList : TeaModel {
                /// <summary>
                /// The error code returned.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The error message returned.
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// Indicates whether the plug-in is installed. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Installed")]
                [Validation(Required=false)]
                public bool? Installed { get; set; }

                /// <summary>
                /// The public IP address of the server.
                /// </summary>
                [NameInMap("MachineInternetIp")]
                [Validation(Required=false)]
                public string MachineInternetIp { get; set; }

                /// <summary>
                /// The private IP address of the server.
                /// </summary>
                [NameInMap("MachineIntranetIp")]
                [Validation(Required=false)]
                public string MachineIntranetIp { get; set; }

                /// <summary>
                /// The name of the server.
                /// </summary>
                [NameInMap("MachineName")]
                [Validation(Required=false)]
                public string MachineName { get; set; }

                /// <summary>
                /// The type of the instance. Valid values include:
                /// 
                /// *   **ecs**: Elastic Compute Service (ECS) instance
                /// *   **slb**: Server Load Balancer (SLB) instance
                /// </summary>
                [NameInMap("MachineType")]
                [Validation(Required=false)]
                public long? MachineType { get; set; }

                /// <summary>
                /// Indicates whether the Security Center agent is online. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// 
                /// >  If the Security Center agent of the server is offline, Security Center does not protect the server.
                /// </summary>
                [NameInMap("Online")]
                [Validation(Required=false)]
                public bool? Online { get; set; }

                /// <summary>
                /// The name of the plug-in.
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
                /// The UUID of the server.
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

                /// <summary>
                /// The instance ID of the server.
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
