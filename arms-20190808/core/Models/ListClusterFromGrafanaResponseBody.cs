// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListClusterFromGrafanaResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PromClusterList")]
        [Validation(Required=false)]
        public List<ListClusterFromGrafanaResponseBodyPromClusterList> PromClusterList { get; set; }
        public class ListClusterFromGrafanaResponseBodyPromClusterList : TeaModel {
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("Options")]
            [Validation(Required=false)]
            public string Options { get; set; }

            [NameInMap("IsControllerInstalled")]
            [Validation(Required=false)]
            public bool? IsControllerInstalled { get; set; }

            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public string AgentStatus { get; set; }

            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            [NameInMap("ControllerId")]
            [Validation(Required=false)]
            public string ControllerId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("InstallTime")]
            [Validation(Required=false)]
            public long? InstallTime { get; set; }

            [NameInMap("PluginsJsonArray")]
            [Validation(Required=false)]
            public string PluginsJsonArray { get; set; }

            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("StateJson")]
            [Validation(Required=false)]
            public string StateJson { get; set; }

            [NameInMap("LastHeartBeatTime")]
            [Validation(Required=false)]
            public long? LastHeartBeatTime { get; set; }

            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public int? NodeNum { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

        }

    }

}
