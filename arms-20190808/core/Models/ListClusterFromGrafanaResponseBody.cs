// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListClusterFromGrafanaResponseBody : TeaModel {
        /// <summary>
        /// The cluster information.
        /// </summary>
        [NameInMap("PromClusterList")]
        [Validation(Required=false)]
        public List<ListClusterFromGrafanaResponseBodyPromClusterList> PromClusterList { get; set; }
        public class ListClusterFromGrafanaResponseBodyPromClusterList : TeaModel {
            /// <summary>
            /// The status of the Prometheus agent on the cluster. Valid values:
            /// 
            /// *   INSTALL_FAILED: The Prometheus agent failed to be installed.
            /// *   INSTALL_SUCCEED: The Prometheus agent was installed.
            /// *   NOT_REGISTER: You have not registered an Alibaba Cloud account.
            /// </summary>
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public string AgentStatus { get; set; }

            /// <summary>
            /// The cluster ID.
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
            /// The type of the cluster.
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// The controller ID.
            /// </summary>
            [NameInMap("ControllerId")]
            [Validation(Required=false)]
            public string ControllerId { get; set; }

            /// <summary>
            /// The time when the dashboard was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The extended fields. This parameter is a JSON string.
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// The ID of a database in the cluster.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The timestamp when the Prometheus agent was installed.
            /// </summary>
            [NameInMap("InstallTime")]
            [Validation(Required=false)]
            public long? InstallTime { get; set; }

            /// <summary>
            /// Indicates whether the Prometheus agent was installed. Valid values:
            /// 
            /// *   true: The Prometheus agent was installed.
            /// *   false: The Prometheus agent was not installed.
            /// </summary>
            [NameInMap("IsControllerInstalled")]
            [Validation(Required=false)]
            public bool? IsControllerInstalled { get; set; }

            /// <summary>
            /// The time when the last heartbeat was reported.
            /// </summary>
            [NameInMap("LastHeartBeatTime")]
            [Validation(Required=false)]
            public long? LastHeartBeatTime { get; set; }

            /// <summary>
            /// The number of nodes.
            /// </summary>
            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public int? NodeNum { get; set; }

            /// <summary>
            /// The custom parameter.
            /// </summary>
            [NameInMap("Options")]
            [Validation(Required=false)]
            public string Options { get; set; }

            /// <summary>
            /// The list of nodejsonar logs.
            /// </summary>
            [NameInMap("PluginsJsonArray")]
            [Validation(Required=false)]
            public string PluginsJsonArray { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The information about applications deployed in the cluster.
            /// </summary>
            [NameInMap("StateJson")]
            [Validation(Required=false)]
            public string StateJson { get; set; }

            /// <summary>
            /// The time when the dashboard was updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the cluster belongs.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// The request ID. You can use the ID to query logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
