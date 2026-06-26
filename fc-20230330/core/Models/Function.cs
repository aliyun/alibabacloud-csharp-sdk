// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class Function : TeaModel {
        /// <summary>
        /// <para>The CRC-64 value of the function code package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2825179536350****</para>
        /// </summary>
        [NameInMap("codeChecksum")]
        [Validation(Required=false)]
        public string CodeChecksum { get; set; }

        /// <summary>
        /// <para>The size of the function code package returned by the system. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>412</para>
        /// </summary>
        [NameInMap("codeSize")]
        [Validation(Required=false)]
        public long? CodeSize { get; set; }

        /// <summary>
        /// <para>The CPU specification of the function. Unit: vCPU. The value must be a multiple of 0.05 vCPU. Minimum value: 0.05. Maximum value: 16. The ratio of cpu to memorySize (in GB) must be between 1:1 and 1:4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>The time when the function was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-01T08:15:27Z</para>
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The custom container runtime configuration. After this parameter is configured, the function can use a custom container image to execute the function. Specify either code or customContainerConfig.</para>
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
        /// <item><description>None: injects STS tokens in all methods.</description></item>
        /// <item><description>Env: does not inject STS tokens through environment variables.</description></item>
        /// <item><description>Request: does not inject STS tokens through requests, including context and headers.</description></item>
        /// <item><description>All: does not inject STS tokens in any method.</description></item>
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
        /// <para>When a sessionAffinity type is set, configure the corresponding affinity settings. For MCP_SSE affinity, populate the MCPSSESessionAffinityConfig configuration. For cookie-based affinity, populate the CookieSessionAffinityConfig configuration. For header field affinity, populate the HeaderFieldSessionAffinityConfig configuration.</para>
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
        /// <para>The Alibaba Cloud Resource Name (ARN) of the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:fc:cn-shanghai:123:functions/functionName</para>
        /// </summary>
        [NameInMap("functionArn")]
        [Validation(Required=false)]
        public string FunctionArn { get; set; }

        /// <summary>
        /// <para>The globally unique ID generated by the system for the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aa715851-1c20-4b89-a8fb-***</para>
        /// </summary>
        [NameInMap("functionId")]
        [Validation(Required=false)]
        public string FunctionId { get; set; }

        /// <summary>
        /// <para>The name of the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-function-1</para>
        /// </summary>
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

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
        /// <para>The deferred instance release time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("idleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The maximum concurrency per instance.</para>
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
        /// <para>The instance lifecycle hook method configuration.</para>
        /// </summary>
        [NameInMap("instanceLifecycleConfig")]
        [Validation(Required=false)]
        public InstanceLifecycleConfig InstanceLifecycleConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether the function can access the Internet. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("internetAccess")]
        [Validation(Required=false)]
        public bool? InternetAccess { get; set; }

        [NameInMap("invocationRestriction")]
        [Validation(Required=false)]
        public FunctionRestriction InvocationRestriction { get; set; }

        [NameInMap("juiceFsConfig")]
        [Validation(Required=false)]
        public JuiceFsConfig JuiceFsConfig { get; set; }

        /// <summary>
        /// <para>The time when the function was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-01T08:15:27Z</para>
        /// </summary>
        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        /// <summary>
        /// <para>The status of the most recent function update operation. When a function is created, this value is Successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Successful</description></item>
        /// <item><description>Failed</description></item>
        /// <item><description>InProgress.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InProgress</para>
        /// </summary>
        [NameInMap("lastUpdateStatus")]
        [Validation(Required=false)]
        public string LastUpdateStatus { get; set; }

        /// <summary>
        /// <para>The reason that caused the most recent function update operation to have the current status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The system is currently processing the acceleration optimization for the image.</para>
        /// </summary>
        [NameInMap("lastUpdateStatusReason")]
        [Validation(Required=false)]
        public string LastUpdateStatusReason { get; set; }

        /// <summary>
        /// <para>The status code of the reason that caused the most recent function update operation to have the current status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ImageOptimizing</para>
        /// </summary>
        [NameInMap("lastUpdateStatusReasonCode")]
        [Validation(Required=false)]
        public string LastUpdateStatusReasonCode { get; set; }

        /// <summary>
        /// <para>The list of layers.</para>
        /// </summary>
        [NameInMap("layers")]
        [Validation(Required=false)]
        public List<FunctionLayer> Layers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;lockedBy&quot;:&quot;AgentRun&quot;,&quot;lockedAt&quot;:&quot;2025-04-05T10:00:00Z&quot;,&quot;lockedResources&quot;:[&quot;function&quot;,&quot;trigger&quot;,&quot;version&quot;,&quot;alias&quot;]}</para>
        /// </summary>
        [NameInMap("lockInfo")]
        [Validation(Required=false)]
        public FunctionLockInfo LockInfo { get; set; }

        /// <summary>
        /// <para>The log configuration. Logs generated by the function are written to the configured Logstore.</para>
        /// </summary>
        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public LogConfig LogConfig { get; set; }

        /// <summary>
        /// <para>The memory specification of the function. Unit: MB. The value must be a multiple of 64 MB. Minimum value: 128. Maximum value: 32768 (32 GB). The ratio of cpu to memorySize (in GB) must be between 1:1 and 1:4.</para>
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
        /// <para>The ID of the resource group.</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The RAM role that the user grants to Function Compute. After this parameter is configured, Function Compute assumes this role to generate temporary access credentials. You can use the temporary access credentials of this role in the function to access specified Alibaba Cloud services such as OSS and OTS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::188077086902****:role/fc-test</para>
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The runtime environment of the function. Currently supported runtime environments include: nodejs12, nodejs14, nodejs16, nodejs18, nodejs20, go1, python3, python3.9, python3.10, python3.12, java8, java11, php7.2, dotnetcore3.1, custom, custom.debian10, custom.debian11, custom.debian12, and custom-container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python3.10</para>
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
        /// <para>When a sessionAffinity type is set, configure the corresponding affinity settings. For MCP_SSE affinity, populate the MCPSSESessionAffinityConfig configuration. For cookie-based affinity, populate the CookieSessionAffinityConfig configuration. For header field affinity, populate the HeaderFieldSessionAffinityConfig configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;sseEndpointPath\&quot;:\&quot;/sse\&quot;, \&quot;sessionConcurrencyPerInstance\&quot;:20}</para>
        /// </summary>
        [NameInMap("sessionAffinityConfig")]
        [Validation(Required=false)]
        public string SessionAffinityConfig { get; set; }

        /// <summary>
        /// <para>The current state of the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pending</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The reason why the function is in the current state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Function creating</para>
        /// </summary>
        [NameInMap("stateReason")]
        [Validation(Required=false)]
        public string StateReason { get; set; }

        /// <summary>
        /// <para>The status code of the reason why the function is in the current state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Creating</para>
        /// </summary>
        [NameInMap("stateReasonCode")]
        [Validation(Required=false)]
        public string StateReasonCode { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// <para>The timeout period for the function execution. Unit: seconds. Minimum value: 1. Maximum value: 86400. Default value: 3. The function is terminated if it exceeds this time limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The Tracing Analysis configuration. After Function Compute is integrated with Tracing Analysis, you can record the time consumed by requests in Function Compute, view the cold start time of functions, and record the time consumed by internal operations of functions.</para>
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
