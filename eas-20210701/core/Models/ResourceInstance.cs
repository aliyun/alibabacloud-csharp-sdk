// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ResourceInstance : TeaModel {
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        [NameInMap("InstanceCpuCount")]
        [Validation(Required=false)]
        public int? InstanceCpuCount { get; set; }

        [NameInMap("InstanceGpuCount")]
        [Validation(Required=false)]
        public int? InstanceGpuCount { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceIp")]
        [Validation(Required=false)]
        public string InstanceIp { get; set; }

        [NameInMap("InstanceMemory")]
        [Validation(Required=false)]
        public string InstanceMemory { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("InstanceUsedCpu")]
        [Validation(Required=false)]
        public float? InstanceUsedCpu { get; set; }

        [NameInMap("InstanceUsedGpu")]
        [Validation(Required=false)]
        public int? InstanceUsedGpu { get; set; }

        [NameInMap("InstanceUsedMemory")]
        [Validation(Required=false)]
        public string InstanceUsedMemory { get; set; }

    }

}
