// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateApplicationInput : TeaModel {
        [NameInMap("applicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        [NameInMap("args")]
        [Validation(Required=false)]
        public string Args { get; set; }

        [NameInMap("caPort")]
        [Validation(Required=false)]
        public int? CaPort { get; set; }

        [NameInMap("code")]
        [Validation(Required=false)]
        public InputCodeLocation Code { get; set; }

        [NameInMap("command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        [NameInMap("customDNS")]
        [Validation(Required=false)]
        public CustomDNS CustomDNS { get; set; }

        [NameInMap("customHealthCheckConfig")]
        [Validation(Required=false)]
        public CustomHealthCheckConfig CustomHealthCheckConfig { get; set; }

        [NameInMap("customHostAlias")]
        [Validation(Required=false)]
        public CustomHostAlias CustomHostAlias { get; set; }

        [NameInMap("customRuntimeConfig")]
        [Validation(Required=false)]
        public CustomRuntimeConfig CustomRuntimeConfig { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("diskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        [NameInMap("enableAppMetric")]
        [Validation(Required=false)]
        public bool? EnableAppMetric { get; set; }

        [NameInMap("environmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        [NameInMap("gpuMemorySize")]
        [Validation(Required=false)]
        public int? GpuMemorySize { get; set; }

        [NameInMap("handler")]
        [Validation(Required=false)]
        public string Handler { get; set; }

        [NameInMap("httpTriggerConfig")]
        [Validation(Required=false)]
        public HTTPTriggerConfig HttpTriggerConfig { get; set; }

        [NameInMap("imageConfig")]
        [Validation(Required=false)]
        public ImageConfig ImageConfig { get; set; }

        [NameInMap("initializationTimeout")]
        [Validation(Required=false)]
        public int? InitializationTimeout { get; set; }

        [NameInMap("initializer")]
        [Validation(Required=false)]
        public string Initializer { get; set; }

        [NameInMap("instanceConcurrency")]
        [Validation(Required=false)]
        public int? InstanceConcurrency { get; set; }

        [NameInMap("instanceLifecycleConfig")]
        [Validation(Required=false)]
        public InstanceLifecycleConfig InstanceLifecycleConfig { get; set; }

        [NameInMap("instanceSoftConcurrency")]
        [Validation(Required=false)]
        public int? InstanceSoftConcurrency { get; set; }

        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("internetAccess")]
        [Validation(Required=false)]
        public bool? InternetAccess { get; set; }

        [NameInMap("layers")]
        [Validation(Required=false)]
        public List<string> Layers { get; set; }

        [NameInMap("livenessProbe")]
        [Validation(Required=false)]
        public Probe LivenessProbe { get; set; }

        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public LogConfig LogConfig { get; set; }

        [NameInMap("memorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        [NameInMap("namespaceID")]
        [Validation(Required=false)]
        public string NamespaceID { get; set; }

        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public NASConfig NasConfig { get; set; }

        [NameInMap("ossMountConfig")]
        [Validation(Required=false)]
        public OSSMountConfig OssMountConfig { get; set; }

        [NameInMap("programmingLanguage")]
        [Validation(Required=false)]
        public string ProgrammingLanguage { get; set; }

        [NameInMap("runtime")]
        [Validation(Required=false)]
        public string Runtime { get; set; }

        [NameInMap("scaleConfig")]
        [Validation(Required=false)]
        public ScaleConfig ScaleConfig { get; set; }

        [NameInMap("slsConfig")]
        [Validation(Required=false)]
        public SLSConfig SlsConfig { get; set; }

        [NameInMap("startupProbe")]
        [Validation(Required=false)]
        public Probe StartupProbe { get; set; }

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
