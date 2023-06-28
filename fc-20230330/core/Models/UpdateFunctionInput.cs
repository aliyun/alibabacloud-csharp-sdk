// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class UpdateFunctionInput : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public InputCodeLocation Code { get; set; }

        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

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

        [NameInMap("layers")]
        [Validation(Required=false)]
        public List<string> Layers { get; set; }

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

        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        [NameInMap("tracingConfig")]
        [Validation(Required=false)]
        public TracingConfig TracingConfig { get; set; }

        [NameInMap("vpcBinding")]
        [Validation(Required=false)]
        public VPCBinding VpcBinding { get; set; }

        [NameInMap("vpcConfig")]
        [Validation(Required=false)]
        public VPCConfig VpcConfig { get; set; }

    }

}
