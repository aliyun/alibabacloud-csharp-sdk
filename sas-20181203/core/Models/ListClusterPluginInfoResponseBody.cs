// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListClusterPluginInfoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListClusterPluginInfoResponseBodyData> Data { get; set; }
        public class ListClusterPluginInfoResponseBodyData : TeaModel {
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("ClusterStatus")]
            [Validation(Required=false)]
            public string ClusterStatus { get; set; }

            [NameInMap("NodePluginInfoList")]
            [Validation(Required=false)]
            public List<ListClusterPluginInfoResponseBodyDataNodePluginInfoList> NodePluginInfoList { get; set; }
            public class ListClusterPluginInfoResponseBodyDataNodePluginInfoList : TeaModel {
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("Installed")]
                [Validation(Required=false)]
                public bool? Installed { get; set; }

                [NameInMap("MachineInternetIp")]
                [Validation(Required=false)]
                public string MachineInternetIp { get; set; }

                [NameInMap("MachineIntranetIp")]
                [Validation(Required=false)]
                public string MachineIntranetIp { get; set; }

                [NameInMap("MachineName")]
                [Validation(Required=false)]
                public string MachineName { get; set; }

                [NameInMap("MachineType")]
                [Validation(Required=false)]
                public long? MachineType { get; set; }

                [NameInMap("Online")]
                [Validation(Required=false)]
                public bool? Online { get; set; }

                [NameInMap("PluginName")]
                [Validation(Required=false)]
                public string PluginName { get; set; }

                [NameInMap("PluginVersion")]
                [Validation(Required=false)]
                public string PluginVersion { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
