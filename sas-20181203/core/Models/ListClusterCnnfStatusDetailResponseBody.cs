// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListClusterCnnfStatusDetailResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListClusterCnnfStatusDetailResponseBodyData> Data { get; set; }
        public class ListClusterCnnfStatusDetailResponseBodyData : TeaModel {
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("Installed")]
            [Validation(Required=false)]
            public bool? Installed { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("InvalidType")]
            [Validation(Required=false)]
            public string InvalidType { get; set; }

            [NameInMap("MachineName")]
            [Validation(Required=false)]
            public string MachineName { get; set; }

            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public int? MachineType { get; set; }

            [NameInMap("PluginName")]
            [Validation(Required=false)]
            public string PluginName { get; set; }

            [NameInMap("PluginVersion")]
            [Validation(Required=false)]
            public string PluginVersion { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
