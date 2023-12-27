// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CreateFunctionRequest : TeaModel {
        /// <summary>
        /// The port on which the HTTP server listens for the custom runtime or custom container runtime.
        /// </summary>
        [NameInMap("caPort")]
        [Validation(Required=false)]
        public int? CaPort { get; set; }

        /// <summary>
        /// The code of the function. The code must be packaged into a ZIP file. Configure **code** or **customContainerConfig**.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public Code Code { get; set; }

        /// <summary>
        /// The number of vCPUs of the function. The value is a multiple of 0.05.
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// The configurations of the Custom Container runtime. After you configure the Custom Container runtime, Function Compute can execute the function in a container created from a custom image. Configure **code** or **customContainerConfig**.
        /// </summary>
        [NameInMap("customContainerConfig")]
        [Validation(Required=false)]
        public CustomContainerConfig CustomContainerConfig { get; set; }

        /// <summary>
        /// The custom DNS configurations of the function.
        /// </summary>
        [NameInMap("customDNS")]
        [Validation(Required=false)]
        public CustomDNS CustomDNS { get; set; }

        /// <summary>
        /// The custom health check configuration of the function. This parameter is applicable only to custom runtimes and custom containers.
        /// </summary>
        [NameInMap("customHealthCheckConfig")]
        [Validation(Required=false)]
        public CustomHealthCheckConfig CustomHealthCheckConfig { get; set; }

        /// <summary>
        /// The configurations of the custom runtime.
        /// </summary>
        [NameInMap("customRuntimeConfig")]
        [Validation(Required=false)]
        public CustomRuntimeConfig CustomRuntimeConfig { get; set; }

        /// <summary>
        /// The description of the function.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The disk size of the function. Unit: MB. Valid values: 512 and 10240.
        /// </summary>
        [NameInMap("diskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// The environment variables that you configured for the function. You can obtain the values of the environment variables from the function. For more information, see [Environment variables](~~69777~~).
        /// </summary>
        [NameInMap("environmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// The name of the function. The name can contain letters, digits, underscores (\_), and hyphens (-) only. The name cannot start with a digit or a hyphen (-). The name must be 1 to 64 characters in length.
        /// </summary>
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// The GPU memory capacity for the function. Unit: MB. The value is a multiple of 1,024.
        /// </summary>
        [NameInMap("gpuMemorySize")]
        [Validation(Required=false)]
        public int? GpuMemorySize { get; set; }

        /// <summary>
        /// The handler of the function. The format varies based on the programming language. For more information, see [Function handlers](~~157704~~).
        /// </summary>
        [NameInMap("handler")]
        [Validation(Required=false)]
        public string Handler { get; set; }

        /// <summary>
        /// The timeout period for the execution of the Initializer hook. Unit: seconds. Default value: 3. Valid values: 1 to 300. When this period expires, the execution of the Initializer hook is terminated.
        /// </summary>
        [NameInMap("initializationTimeout")]
        [Validation(Required=false)]
        public int? InitializationTimeout { get; set; }

        /// <summary>
        /// The handler of the Initializer hook. For more information, see [Initializer hooks](~~157704~~).
        /// </summary>
        [NameInMap("initializer")]
        [Validation(Required=false)]
        public string Initializer { get; set; }

        /// <summary>
        /// The number of requests that can be concurrently processed by a single instance.
        /// </summary>
        [NameInMap("instanceConcurrency")]
        [Validation(Required=false)]
        public int? InstanceConcurrency { get; set; }

        /// <summary>
        /// The lifecycle configurations of the instance.
        /// </summary>
        [NameInMap("instanceLifecycleConfig")]
        [Validation(Required=false)]
        public InstanceLifecycleConfig InstanceLifecycleConfig { get; set; }

        /// <summary>
        /// The soft concurrency of the instance. You can use this property to implement graceful scale-ups for instances. If the number of concurrent requests on an instance is greater than the soft concurrency value of the instance, an instance scale-up is triggered. For example, if your instance requires a long time to start, you can specify a suitable soft concurrency to start the instance in advance.
        /// 
        /// The value must be less than or equal to that of the **instanceConcurrency** parameter.
        /// </summary>
        [NameInMap("instanceSoftConcurrency")]
        [Validation(Required=false)]
        public int? InstanceSoftConcurrency { get; set; }

        /// <summary>
        /// The instance type of the function. Valid values:
        /// 
        /// *   **e1**: elastic instance
        /// *   **c1**: performance instance
        /// *   **fc.gpu.tesla.1**: GPU-accelerated instance (Tesla T4)
        /// *   **fc.gpu.ampere.1**: GPU-accelerated instance (Ampere A10)
        /// *   **g1**: same as **fc.gpu.tesla.1**
        /// 
        /// Default value: e1
        /// </summary>
        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// An array that consists of the information of layers.
        /// 
        /// >  If multiple layers exist, the layers are merged based on the array subscripts in descending order. The content of a layer with a smaller subscript overwrites that of a larger subscript.
        /// </summary>
        [NameInMap("layers")]
        [Validation(Required=false)]
        public List<string> Layers { get; set; }

        /// <summary>
        /// The memory size of the function. Unit: MB. The value must be a multiple of 64. The memory size varies based on the function instance type. For more information, see the "Instance types" section of the [Instance types and usage modes](~~179379~~) topic.
        /// </summary>
        [NameInMap("memorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        /// <summary>
        /// The runtime of the function. Valid values: **nodejs16**, **nodejs14**, **nodejs12**, **nodejs10**, **nodejs8**, **nodejs6**, **nodejs4.4**, **python3.10**, **python3.9**, **python3**, **python2.7**, **java11**, **java8**, **go1**, **php7.2**, **dotnetcore3.1**, **dotnetcore2.1**, **custom.debian10**, **custom**, and **custom-container**. For more information, see [Supported function runtime environments](~~73338~~).
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public string Runtime { get; set; }

        /// <summary>
        /// The timeout period for the execution of the function. Unit: seconds. Default value: 3. Minimum value: 1. When this period is elapsed, the function execution is terminated.
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
