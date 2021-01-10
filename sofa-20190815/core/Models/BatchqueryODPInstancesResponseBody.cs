// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class BatchqueryODPInstancesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<BatchqueryODPInstancesResponseBodyData> Data { get; set; }
        public class BatchqueryODPInstancesResponseBodyData : TeaModel {
            [NameInMap("PaymentType")]
            [Validation(Required=false)]
            public long? PaymentType { get; set; }

            [NameInMap("ConfigSpecDesc")]
            [Validation(Required=false)]
            public string ConfigSpecDesc { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("BizVpcId")]
            [Validation(Required=false)]
            public string BizVpcId { get; set; }

            [NameInMap("MachineCount")]
            [Validation(Required=false)]
            public long? MachineCount { get; set; }

            [NameInMap("EnvMode")]
            [Validation(Required=false)]
            public string EnvMode { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("InstancePort")]
            [Validation(Required=false)]
            public long? InstancePort { get; set; }

            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<BatchqueryODPInstancesResponseBodyDataNodes> Nodes { get; set; }
            public class BatchqueryODPInstancesResponseBodyDataNodes : TeaModel {
                [NameInMap("ConfigSpecDesc")]
                [Validation(Required=false)]
                public string ConfigSpecDesc { get; set; }

                [NameInMap("MemoryCount")]
                [Validation(Required=false)]
                public long? MemoryCount { get; set; }

                [NameInMap("NodeWanPort")]
                [Validation(Required=false)]
                public long? NodeWanPort { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public long? Port { get; set; }

                [NameInMap("ZdalproxyNodeId")]
                [Validation(Required=false)]
                public string ZdalproxyNodeId { get; set; }

                [NameInMap("ZdalproxyInstanceId")]
                [Validation(Required=false)]
                public string ZdalproxyInstanceId { get; set; }

                [NameInMap("YunyouOpsPlanUrl")]
                [Validation(Required=false)]
                public string YunyouOpsPlanUrl { get; set; }

                [NameInMap("BizVpcId")]
                [Validation(Required=false)]
                public string BizVpcId { get; set; }

                [NameInMap("CellName")]
                [Validation(Required=false)]
                public string CellName { get; set; }

                [NameInMap("NodeStatus")]
                [Validation(Required=false)]
                public string NodeStatus { get; set; }

                [NameInMap("MachineCount")]
                [Validation(Required=false)]
                public long? MachineCount { get; set; }

                [NameInMap("ExecutionDetail")]
                [Validation(Required=false)]
                public string ExecutionDetail { get; set; }

                [NameInMap("EnvMode")]
                [Validation(Required=false)]
                public string EnvMode { get; set; }

                [NameInMap("Vip")]
                [Validation(Required=false)]
                public string Vip { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("EnvTenant")]
                [Validation(Required=false)]
                public string EnvTenant { get; set; }

                [NameInMap("EnvName")]
                [Validation(Required=false)]
                public string EnvName { get; set; }

                [NameInMap("BizVswtichId")]
                [Validation(Required=false)]
                public string BizVswtichId { get; set; }

                [NameInMap("YunyouDeployUnitUrl")]
                [Validation(Required=false)]
                public string YunyouDeployUnitUrl { get; set; }

                [NameInMap("CellId")]
                [Validation(Required=false)]
                public string CellId { get; set; }

                [NameInMap("NodeWanAddress")]
                [Validation(Required=false)]
                public string NodeWanAddress { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }

                [NameInMap("CpuCount")]
                [Validation(Required=false)]
                public long? CpuCount { get; set; }

                [NameInMap("NodeLanAddress")]
                [Validation(Required=false)]
                public string NodeLanAddress { get; set; }

                [NameInMap("EnvId")]
                [Validation(Required=false)]
                public string EnvId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            [NameInMap("EnvTenant")]
            [Validation(Required=false)]
            public string EnvTenant { get; set; }

            [NameInMap("Legacy")]
            [Validation(Required=false)]
            public bool? Legacy { get; set; }

            [NameInMap("InstanceLanAddress")]
            [Validation(Required=false)]
            public string InstanceLanAddress { get; set; }

            [NameInMap("SchemaCount")]
            [Validation(Required=false)]
            public long? SchemaCount { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceWanAddress")]
            [Validation(Required=false)]
            public string InstanceWanAddress { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("InstanceZone")]
            [Validation(Required=false)]
            public string InstanceZone { get; set; }

            [NameInMap("InstanceWanPort")]
            [Validation(Required=false)]
            public long? InstanceWanPort { get; set; }

            [NameInMap("ZoneCount")]
            [Validation(Required=false)]
            public long? ZoneCount { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            [NameInMap("InstanceVip")]
            [Validation(Required=false)]
            public string InstanceVip { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
