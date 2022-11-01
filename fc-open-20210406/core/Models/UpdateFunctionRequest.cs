// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class UpdateFunctionRequest : TeaModel {
        [NameInMap("InstanceConcurrency")]
        [Validation(Required=false)]
        public int? InstanceConcurrency { get; set; }

        [NameInMap("caPort")]
        [Validation(Required=false)]
        public int? CaPort { get; set; }

        [NameInMap("code")]
        [Validation(Required=false)]
        public Code Code { get; set; }

        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        [NameInMap("customContainerConfig")]
        [Validation(Required=false)]
        public CustomContainerConfig CustomContainerConfig { get; set; }

        [NameInMap("customDNS")]
        [Validation(Required=false)]
        public CustomDNS CustomDNS { get; set; }

        [NameInMap("customHealthCheckConfig")]
        [Validation(Required=false)]
        public CustomHealthCheckConfig CustomHealthCheckConfig { get; set; }

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

        [NameInMap("handler")]
        [Validation(Required=false)]
        public string Handler { get; set; }

        [NameInMap("initializationTimeout")]
        [Validation(Required=false)]
        public int? InitializationTimeout { get; set; }

        [NameInMap("initializer")]
        [Validation(Required=false)]
        public string Initializer { get; set; }

        [NameInMap("instanceLifecycleConfig")]
        [Validation(Required=false)]
        public InstanceLifecycleConfig InstanceLifecycleConfig { get; set; }

        [NameInMap("instanceSoftConcurrency")]
        [Validation(Required=false)]
        public int? InstanceSoftConcurrency { get; set; }

        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("layers")]
        [Validation(Required=false)]
        public List<string> Layers { get; set; }

        [NameInMap("memorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        [NameInMap("runtime")]
        [Validation(Required=false)]
        public string Runtime { get; set; }

        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
