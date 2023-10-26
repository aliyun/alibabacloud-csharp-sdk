// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class Function : TeaModel {
        [NameInMap("codeChecksum")]
        [Validation(Required=false)]
        public string CodeChecksum { get; set; }

        [NameInMap("codeSize")]
        [Validation(Required=false)]
        public long? CodeSize { get; set; }

        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("customContainerConfig")]
        [Validation(Required=false)]
        public CustomContainerConfig CustomContainerConfig { get; set; }

        [NameInMap("customDNS")]
        [Validation(Required=false)]
        public CustomDNS CustomDNS { get; set; }

        [NameInMap("customRuntimeConfig")]
        [Validation(Required=false)]
        public CustomRuntimeConfig CustomRuntimeConfig { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("diskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        [NameInMap("environmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        [NameInMap("functionArn")]
        [Validation(Required=false)]
        public string FunctionArn { get; set; }

        [NameInMap("functionId")]
        [Validation(Required=false)]
        public string FunctionId { get; set; }

        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        [NameInMap("gpuConfig")]
        [Validation(Required=false)]
        public GPUConfig GpuConfig { get; set; }

        [NameInMap("handler")]
        [Validation(Required=false)]
        public string Handler { get; set; }

        [NameInMap("instanceConcurrency")]
        [Validation(Required=false)]
        public int? InstanceConcurrency { get; set; }

        [NameInMap("instanceLifecycleConfig")]
        [Validation(Required=false)]
        public InstanceLifecycleConfig InstanceLifecycleConfig { get; set; }

        [NameInMap("internetAccess")]
        [Validation(Required=false)]
        public bool? InternetAccess { get; set; }

        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        [NameInMap("lastUpdateStatus")]
        [Validation(Required=false)]
        public string LastUpdateStatus { get; set; }

        [NameInMap("lastUpdateStatusReason")]
        [Validation(Required=false)]
        public string LastUpdateStatusReason { get; set; }

        [NameInMap("lastUpdateStatusReasonCode")]
        [Validation(Required=false)]
        public string LastUpdateStatusReasonCode { get; set; }

        [NameInMap("layers")]
        [Validation(Required=false)]
        public List<FunctionLayer> Layers { get; set; }

        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public LogConfig LogConfig { get; set; }

        [NameInMap("memorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public NASConfig NasConfig { get; set; }

        [NameInMap("ossMountConfig")]
        [Validation(Required=false)]
        public OSSMountConfig OssMountConfig { get; set; }

        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("runtime")]
        [Validation(Required=false)]
        public string Runtime { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("stateReason")]
        [Validation(Required=false)]
        public string StateReason { get; set; }

        [NameInMap("stateReasonCode")]
        [Validation(Required=false)]
        public string StateReasonCode { get; set; }

        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        [NameInMap("tracingConfig")]
        [Validation(Required=false)]
        public TracingConfig TracingConfig { get; set; }

        [NameInMap("vpcConfig")]
        [Validation(Required=false)]
        public VPCConfig VpcConfig { get; set; }

    }

}
