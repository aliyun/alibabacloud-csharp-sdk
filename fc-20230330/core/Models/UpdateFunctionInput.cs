// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class UpdateFunctionInput : TeaModel {
        /// <summary>
        /// <para>The ZIP package of the function code. Specify either code or customContainerConfig.</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public InputCodeLocation Code { get; set; }

        /// <summary>
        /// <para>The CPU specification of the function. Unit: vCPU. The value must be a multiple of 0.05 vCPU.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>The configuration of the custom container runtime. After this parameter is configured, the function can use a custom container image for execution. Specify either code or customContainerConfig.</para>
        /// </summary>
        [NameInMap("customContainerConfig")]
        [Validation(Required=false)]
        public CustomContainerConfig CustomContainerConfig { get; set; }

        /// <summary>
        /// <para>The custom DNS configuration.</para>
        /// </summary>
        [NameInMap("customDNS")]
        [Validation(Required=false)]
        public CustomDNS CustomDNS { get; set; }

        /// <summary>
        /// <para>The custom runtime configuration.</para>
        /// </summary>
        [NameInMap("customRuntimeConfig")]
        [Validation(Required=false)]
        public CustomRuntimeConfig CustomRuntimeConfig { get; set; }

        /// <summary>
        /// <para>The description of the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my function</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable STS token injection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>None: STS tokens are injected in all methods.</description></item>
        /// <item><description>Env: STS tokens are not injected through environment variables.</description></item>
        /// <item><description>Request: STS tokens are not injected through requests, including context and headers.</description></item>
        /// <item><description>All: STS tokens are not injected in any method.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Env</para>
        /// </summary>
        [NameInMap("disableInjectCredentials")]
        [Validation(Required=false)]
        public string DisableInjectCredentials { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether to disable the creation of on-demand instances. If this feature is enabled, on-demand instances are not created, and only provisioned instances can be used.</para>
        /// </summary>
        [NameInMap("disableOndemand")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? DisableOndemand { get; set; }

        /// <summary>
        /// <para>The disk specification of the function. Unit: MB. Valid values: 512 and 10240.</para>
        /// 
        /// <b>Example:</b>
        /// <para>512</para>
        /// </summary>
        [NameInMap("diskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether to allow provisioned instances of GPU functions to be long-running. When this feature is enabled, function instances that are created are not injected with STS tokens.</para>
        /// </summary>
        [NameInMap("enableLongLiving")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? EnableLongLiving { get; set; }

        /// <summary>
        /// <para>The environment variables of the function. You can access the configured environment variables in the runtime environment.</para>
        /// </summary>
        [NameInMap("environmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// <para>The GPU configuration of the function.</para>
        /// </summary>
        [NameInMap("gpuConfig")]
        [Validation(Required=false)]
        public GPUConfig GpuConfig { get; set; }

        /// <summary>
        /// <para>The function entry point. The specific format depends on the runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>index.handler</para>
        /// </summary>
        [NameInMap("handler")]
        [Validation(Required=false)]
        public string Handler { get; set; }

        /// <summary>
        /// <para>The deferred release time of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("idleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The maximum concurrency of an instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("instanceConcurrency")]
        [Validation(Required=false)]
        public int? InstanceConcurrency { get; set; }

        /// <summary>
        /// <para>The instance isolation mode.</para>
        /// </summary>
        [NameInMap("instanceIsolationMode")]
        [Validation(Required=false)]
        public string InstanceIsolationMode { get; set; }

        /// <summary>
        /// <para>The instance lifecycle hook configuration.</para>
        /// </summary>
        [NameInMap("instanceLifecycleConfig")]
        [Validation(Required=false)]
        public InstanceLifecycleConfig InstanceLifecycleConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow access to the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("internetAccess")]
        [Validation(Required=false)]
        public bool? InternetAccess { get; set; }

        [NameInMap("juiceFsConfig")]
        [Validation(Required=false)]
        public JuiceFsConfig JuiceFsConfig { get; set; }

        /// <summary>
        /// <para>The list of layers. Multiple layers are merged in descending order of array index. Files in a layer with a smaller index overwrite files with the same name in a layer with a larger index.</para>
        /// </summary>
        [NameInMap("layers")]
        [Validation(Required=false)]
        public List<string> Layers { get; set; }

        /// <summary>
        /// <para>The log configuration. Logs generated by the function are written to the configured Logstore.</para>
        /// </summary>
        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public LogConfig LogConfig { get; set; }

        /// <summary>
        /// <para>The memory specification of the function. Unit: MB. The value must be a multiple of 64 MB. The memory specification varies based on the function instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>512</para>
        /// </summary>
        [NameInMap("memorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        [NameInMap("microSandboxConfig")]
        [Validation(Required=false)]
        public MicroSandboxConfig MicroSandboxConfig { get; set; }

        /// <summary>
        /// <para>The NAS configuration. After this parameter is configured, the function can access the specified NAS resources.</para>
        /// </summary>
        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public NASConfig NasConfig { get; set; }

        /// <summary>
        /// <para>The OSS mount configuration.</para>
        /// </summary>
        [NameInMap("ossMountConfig")]
        [Validation(Required=false)]
        public OSSMountConfig OssMountConfig { get; set; }

        /// <summary>
        /// <para>The PolarFs configuration. After this parameter is configured, the function can access the specified PolarFs resources.</para>
        /// </summary>
        [NameInMap("polarFsConfig")]
        [Validation(Required=false)]
        public PolarFsConfig PolarFsConfig { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Access Management (RAM) role that grants Function Compute the required permissions. Scenarios include: 1. Sending logs generated by the function to your Logstore. 2. Generating temporary access tokens for the function to access other cloud resources during the execute procedure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::188077086902****:role/fc-test</para>
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The runtime environment of the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nodejs14</para>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public string Runtime { get; set; }

        /// <summary>
        /// <para>The affinity policy for Function Compute invocation requests. To implement request affinity for the MCP SSE protocol, set this parameter to MCP_SSE. To use cookie-based affinity, set this parameter to GENERATED_COOKIE. To use header-based affinity, set this parameter to HEADER_FIELD. If this parameter is not set or is set to NONE, no affinity is applied, and requests are routed based on the default scheduling policy of Function Compute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MCP_SSE</para>
        /// </summary>
        [NameInMap("sessionAffinity")]
        [Validation(Required=false)]
        public string SessionAffinity { get; set; }

        /// <summary>
        /// <para>The affinity configuration that corresponds to the sessionAffinity type. For MCP_SSE affinity, configure MCPSSESessionAffinityConfig. For cookie-based affinity, configure CookieSessionAffinityConfig. For header field affinity, configure HeaderFieldSessionAffinityConfig.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;sseEndpointPath\&quot;:\&quot;/sse\&quot;, \&quot;sessionConcurrencyPerInstance\&quot;:20}</para>
        /// </summary>
        [NameInMap("sessionAffinityConfig")]
        [Validation(Required=false)]
        public string SessionAffinityConfig { get; set; }

        /// <summary>
        /// <para>The timeout period for function execution. Unit: seconds. Minimum value: 1. Default value: 3. The function is terminated if it exceeds this time limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The Tracing Analysis configuration. After Function Compute is integrated with Tracing Analysis, you can record the time consumed by requests in Function Compute, view the cold start time of functions, and record the time consumed by internal function operations.</para>
        /// </summary>
        [NameInMap("tracingConfig")]
        [Validation(Required=false)]
        public TracingConfig TracingConfig { get; set; }

        /// <summary>
        /// <para>The VPC configuration. After this parameter is configured, the function can access the specified VPC resources.</para>
        /// </summary>
        [NameInMap("vpcConfig")]
        [Validation(Required=false)]
        public VPCConfig VpcConfig { get; set; }

    }

}
