// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CreateFunctionInput : TeaModel {
        /// <summary>
        /// <para>The code package of the function. Configure either code or customContainerConfig.</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public InputCodeLocation Code { get; set; }

        /// <summary>
        /// <para>The CPU power allocated to the function. Unit: vCPUs. The value must be a multiple of 0.05. The minimum value is 0.05 and the maximum value is 16. The ratio of cpu to memorySize (in GB) must be from 1:1 to 1:4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>The configurations of the Custom Container runtime. After you configure a Custom Container runtime for your function, Function Compute can execute the function in a custom container image. Configure either code or customContainerConfig.</para>
        /// </summary>
        [NameInMap("customContainerConfig")]
        [Validation(Required=false)]
        public CustomContainerConfig CustomContainerConfig { get; set; }

        /// <summary>
        /// <para>The custom DNS settings of the function.</para>
        /// </summary>
        [NameInMap("customDNS")]
        [Validation(Required=false)]
        public CustomDNS CustomDNS { get; set; }

        /// <summary>
        /// <para>The configurations of the custom runtime.</para>
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

        [NameInMap("disableInjectCredentials")]
        [Validation(Required=false)]
        public string DisableInjectCredentials { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("disableOndemand")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? DisableOndemand { get; set; }

        /// <summary>
        /// <para>The disk size of the function. Unit: MB. Valid values: 512 and 10240.</para>
        /// 
        /// <b>Example:</b>
        /// <para>512</para>
        /// </summary>
        [NameInMap("diskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("enableLongLiving")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? EnableLongLiving { get; set; }

        /// <summary>
        /// <para>The environment variables of the function. You can access the specified environment variables in the runtime.</para>
        /// </summary>
        [NameInMap("environmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// <para>The name of the function. The name must be 1 to 64 characters in length, and can contain only letters, digits, underscores (_), and hyphens (-). It cannot begin with a digit or a hyphen (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-function-1</para>
        /// </summary>
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// <para>The GPU configurations of the function.</para>
        /// </summary>
        [NameInMap("gpuConfig")]
        [Validation(Required=false)]
        public GPUConfig GpuConfig { get; set; }

        /// <summary>
        /// <para>The handler of the function. The format of the handler is related to the runtime you use.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>index.handler</para>
        /// </summary>
        [NameInMap("handler")]
        [Validation(Required=false)]
        public string Handler { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("idleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The maximum number of requests that a function instance can process at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("instanceConcurrency")]
        [Validation(Required=false)]
        public int? InstanceConcurrency { get; set; }

        [NameInMap("instanceIsolationMode")]
        [Validation(Required=false)]
        public string InstanceIsolationMode { get; set; }

        /// <summary>
        /// <para>The configurations of instance lifecycle hooks.</para>
        /// </summary>
        [NameInMap("instanceLifecycleConfig")]
        [Validation(Required=false)]
        public InstanceLifecycleConfig InstanceLifecycleConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow the function to access the Internet. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("internetAccess")]
        [Validation(Required=false)]
        public bool? InternetAccess { get; set; }

        /// <summary>
        /// <para>The layers. Multiple layers are merged based on the order of array subscripts. If two layers have the same file name, the content of the layer with the smaller subscript will overwrite the content of the layer with the larger subscript.</para>
        /// </summary>
        [NameInMap("layers")]
        [Validation(Required=false)]
        public List<string> Layers { get; set; }

        /// <summary>
        /// <para>The logging configurations. Logs generated by the function are written to the specified Logstore.</para>
        /// </summary>
        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public LogConfig LogConfig { get; set; }

        /// <summary>
        /// <para>The memory capacity for the function. Unit: MB. The value must be a multiple of 64. The minimum capacity is 128 MB and the maximum capacity is 32 GB. The ratio of cpu to memorySize (in GB) must be from 1:1 to 1:4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>512</para>
        /// </summary>
        [NameInMap("memorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        /// <summary>
        /// <para>The File Storage NAS (NAS) configurations. The configurations allow the function to access the specified NAS file system.</para>
        /// </summary>
        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public NASConfig NasConfig { get; set; }

        /// <summary>
        /// <para>The OSS mounting configurations.</para>
        /// </summary>
        [NameInMap("ossMountConfig")]
        [Validation(Required=false)]
        public OSSMountConfig OssMountConfig { get; set; }

        [NameInMap("polarFsConfig")]
        [Validation(Required=false)]
        public PolarFsConfig PolarFsConfig { get; set; }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The Resource Access Management (RAM) role that is assigned to the function. Function Compute assumes the role to obtain a Security Token Service (STS) token, which serves as a temporary key for your function to access other Alibaba Cloud services, such as Object Storage Service (OSS) and Tablestore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::188077086902****:role/fc-test</para>
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The runtime of the function. Valid values: nodejs8, nodejs10, nodejs12, nodejs14, nodejs16, nodejs18, nodejs20, go1, python3, python3.9, python3.10, java8, java11, php7.2, dotnetcore3.1, custom, custom.debian10, and custom-container.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python3.10</para>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public string Runtime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MCP_SSE</para>
        /// </summary>
        [NameInMap("sessionAffinity")]
        [Validation(Required=false)]
        public string SessionAffinity { get; set; }

        [NameInMap("sessionAffinityConfig")]
        [Validation(Required=false)]
        public string SessionAffinityConfig { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// <para>The timeout period for function execution. Unit: seconds. Default value: 3. Valid values: 1 to 86400. The execution of the function is terminated when the timeout period expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The configurations of Managed Service for OpenTelemetry. After Function Compute is integrated with Managed Service for OpenTelemetry, you can record the invocation duration of a request, view the cold start duration of a function, and track the execution duration of the function.</para>
        /// </summary>
        [NameInMap("tracingConfig")]
        [Validation(Required=false)]
        public TracingConfig TracingConfig { get; set; }

        /// <summary>
        /// <para>The Virtual Private Cloud (VPC) configurations. The configurations allow the function to access the specified VPC resources.</para>
        /// </summary>
        [NameInMap("vpcConfig")]
        [Validation(Required=false)]
        public VPCConfig VpcConfig { get; set; }

    }

}
