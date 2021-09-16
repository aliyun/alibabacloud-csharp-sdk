// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class RpcListInstanceResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// es 列表
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<RpcListInstanceResponseBodyResult> Result { get; set; }
        public class RpcListInstanceResponseBodyResult : TeaModel {
            [NameInMap("AdvancedDedicateMaster")]
            [Validation(Required=false)]
            public bool? AdvancedDedicateMaster { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("DataNode")]
            [Validation(Required=false)]
            public bool? DataNode { get; set; }

            [NameInMap("DedicateMaster")]
            [Validation(Required=false)]
            public bool? DedicateMaster { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("EnableKibanaPrivateNetwork")]
            [Validation(Required=false)]
            public bool? EnableKibanaPrivateNetwork { get; set; }

            [NameInMap("EnableKibanaPublicNetwork")]
            [Validation(Required=false)]
            public bool? EnableKibanaPublicNetwork { get; set; }

            [NameInMap("EnablePublic")]
            [Validation(Required=false)]
            public bool? EnablePublic { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("EsVersion")]
            [Validation(Required=false)]
            public string EsVersion { get; set; }

            [NameInMap("HaveCerebro")]
            [Validation(Required=false)]
            public bool? HaveCerebro { get; set; }

            [NameInMap("HaveClientNode")]
            [Validation(Required=false)]
            public bool? HaveClientNode { get; set; }

            [NameInMap("HaveElasticDataNode")]
            [Validation(Required=false)]
            public bool? HaveElasticDataNode { get; set; }

            [NameInMap("HaveGrafana")]
            [Validation(Required=false)]
            public bool? HaveGrafana { get; set; }

            [NameInMap("HaveKibana")]
            [Validation(Required=false)]
            public bool? HaveKibana { get; set; }

            [NameInMap("Inited")]
            [Validation(Required=false)]
            public bool? Inited { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("IsNewDeployment")]
            [Validation(Required=false)]
            public bool? IsNewDeployment { get; set; }

            [NameInMap("KibanaProtocol")]
            [Validation(Required=false)]
            public string KibanaProtocol { get; set; }

            [NameInMap("NodeAmount")]
            [Validation(Required=false)]
            public long? NodeAmount { get; set; }

            [NameInMap("PaymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("WarmNode")]
            [Validation(Required=false)]
            public bool? WarmNode { get; set; }

            [NameInMap("ZoneCount")]
            [Validation(Required=false)]
            public long? ZoneCount { get; set; }

        }

    }

}
