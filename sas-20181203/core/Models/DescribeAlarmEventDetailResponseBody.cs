// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAlarmEventDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAlarmEventDetailResponseBodyData Data { get; set; }
        public class DescribeAlarmEventDetailResponseBodyData : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }
            [NameInMap("K8sClusterName")]
            [Validation(Required=false)]
            public string K8sClusterName { get; set; }
            [NameInMap("ContainerImageId")]
            [Validation(Required=false)]
            public string ContainerImageId { get; set; }
            [NameInMap("AlarmEventDesc")]
            [Validation(Required=false)]
            public string AlarmEventDesc { get; set; }
            [NameInMap("AlarmUniqueInfo")]
            [Validation(Required=false)]
            public string AlarmUniqueInfo { get; set; }
            [NameInMap("CauseDetails")]
            [Validation(Required=false)]
            public List<DescribeAlarmEventDetailResponseBodyDataCauseDetails> CauseDetails { get; set; }
            public class DescribeAlarmEventDetailResponseBodyDataCauseDetails : TeaModel {
                public string Key { get; set; }
                public List<DescribeAlarmEventDetailResponseBodyDataCauseDetailsValue> Value { get; set; }
                public class DescribeAlarmEventDetailResponseBodyDataCauseDetailsValue : TeaModel {
                    public string Type { get; set; }
                    public string Value { get; set; }
                    public string Name { get; set; }
                }
            }
            [NameInMap("CanCancelFault")]
            [Validation(Required=false)]
            public bool? CanCancelFault { get; set; }
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("CanBeDealOnLine")]
            [Validation(Required=false)]
            public bool? CanBeDealOnLine { get; set; }
            [NameInMap("ContainerImageName")]
            [Validation(Required=false)]
            public string ContainerImageName { get; set; }
            [NameInMap("K8sClusterId")]
            [Validation(Required=false)]
            public string K8sClusterId { get; set; }
            [NameInMap("ContainHwMode")]
            [Validation(Required=false)]
            public bool? ContainHwMode { get; set; }
            [NameInMap("K8sNodeId")]
            [Validation(Required=false)]
            public string K8sNodeId { get; set; }
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }
            [NameInMap("Solution")]
            [Validation(Required=false)]
            public string Solution { get; set; }
            [NameInMap("DataSource")]
            [Validation(Required=false)]
            public string DataSource { get; set; }
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }
            [NameInMap("AlarmEventAliasName")]
            [Validation(Required=false)]
            public string AlarmEventAliasName { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }
            [NameInMap("K8sPodName")]
            [Validation(Required=false)]
            public string K8sPodName { get; set; }
            [NameInMap("ContainerId")]
            [Validation(Required=false)]
            public string ContainerId { get; set; }
            [NameInMap("K8sNamespace")]
            [Validation(Required=false)]
            public string K8sNamespace { get; set; }
            [NameInMap("K8sNodeName")]
            [Validation(Required=false)]
            public string K8sNodeName { get; set; }
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }
        };

    }

}
