// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryODPInstancesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryODPInstancesResponseBodyData Data { get; set; }
        public class QueryODPInstancesResponseBodyData : TeaModel {
            [NameInMap("BizVpcId")]
            [Validation(Required=false)]
            public string BizVpcId { get; set; }
            [NameInMap("ConfigSpecDesc")]
            [Validation(Required=false)]
            public string ConfigSpecDesc { get; set; }
            [NameInMap("EnvMode")]
            [Validation(Required=false)]
            public string EnvMode { get; set; }
            [NameInMap("EnvTenant")]
            [Validation(Required=false)]
            public string EnvTenant { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("InstanceLanAddress")]
            [Validation(Required=false)]
            public string InstanceLanAddress { get; set; }
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }
            [NameInMap("InstancePort")]
            [Validation(Required=false)]
            public long? InstancePort { get; set; }
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }
            [NameInMap("InstanceVip")]
            [Validation(Required=false)]
            public string InstanceVip { get; set; }
            [NameInMap("InstanceWanAddress")]
            [Validation(Required=false)]
            public string InstanceWanAddress { get; set; }
            [NameInMap("InstanceWanPort")]
            [Validation(Required=false)]
            public long? InstanceWanPort { get; set; }
            [NameInMap("InstanceZone")]
            [Validation(Required=false)]
            public string InstanceZone { get; set; }
            [NameInMap("Legacy")]
            [Validation(Required=false)]
            public bool? Legacy { get; set; }
            [NameInMap("MachineCount")]
            [Validation(Required=false)]
            public long? MachineCount { get; set; }
            [NameInMap("PaymentType")]
            [Validation(Required=false)]
            public long? PaymentType { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("SchemaCount")]
            [Validation(Required=false)]
            public long? SchemaCount { get; set; }
            [NameInMap("ZoneCount")]
            [Validation(Required=false)]
            public long? ZoneCount { get; set; }
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<QueryODPInstancesResponseBodyDataNodes> Nodes { get; set; }
            public class QueryODPInstancesResponseBodyDataNodes : TeaModel {
                public string AliyunInstanceId { get; set; }
                public string BizVpcId { get; set; }
                public string BizVswtichId { get; set; }
                public string CellId { get; set; }
                public string CellName { get; set; }
                public string ClusterId { get; set; }
                public string ConfigSpecDesc { get; set; }
                public long? CpuCount { get; set; }
                public string EnvId { get; set; }
                public string EnvMode { get; set; }
                public string EnvName { get; set; }
                public string EnvTenant { get; set; }
                public string ExecutionDetail { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public long? Id { get; set; }
                public long? MachineCount { get; set; }
                public long? MemoryCount { get; set; }
                public string NodeLanAddress { get; set; }
                public string NodeStatus { get; set; }
                public string NodeWanAddress { get; set; }
                public long? NodeWanPort { get; set; }
                public long? Port { get; set; }
                public string Vip { get; set; }
                public string YunyouDeployUnitUrl { get; set; }
                public string YunyouOpsPlanUrl { get; set; }
                public string ZdalproxyInstanceId { get; set; }
                public string ZdalproxyNodeId { get; set; }
                public string Zone { get; set; }
                public string ZoneDescription { get; set; }
            }
        };

    }

}
