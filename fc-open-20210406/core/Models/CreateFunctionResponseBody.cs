// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CreateFunctionResponseBody : TeaModel {
        /// <summary>
        /// 自定义、自定义容器运行时 HTTP Server 的监听端口
        /// </summary>
        [NameInMap("caPort")]
        [Validation(Required=false)]
        public int? CaPort { get; set; }

        /// <summary>
        /// function code包的CRC64值
        /// </summary>
        [NameInMap("codeChecksum")]
        [Validation(Required=false)]
        public string CodeChecksum { get; set; }

        /// <summary>
        /// 系统返回的function的code包大小，单位为byte Example : 1024
        /// </summary>
        [NameInMap("codeSize")]
        [Validation(Required=false)]
        public long? CodeSize { get; set; }

        /// <summary>
        /// function创建时间
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("customContainerConfig")]
        [Validation(Required=false)]
        public CustomContainerConfig CustomContainerConfig { get; set; }

        /// <summary>
        /// 函数自定义DNS配置
        /// </summary>
        [NameInMap("customDNS")]
        [Validation(Required=false)]
        public CustomDNS CustomDNS { get; set; }

        /// <summary>
        /// Custom Runtime函数详细配置
        /// </summary>
        [NameInMap("customRuntimeConfig")]
        [Validation(Required=false)]
        public CustomRuntimeConfig CustomRuntimeConfig { get; set; }

        /// <summary>
        /// 函数描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("environmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// 系统为每个function生成的唯一ID
        /// </summary>
        [NameInMap("functionId")]
        [Validation(Required=false)]
        public string FunctionId { get; set; }

        /// <summary>
        /// 函数名称
        /// </summary>
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// function的执行入口
        /// </summary>
        [NameInMap("handler")]
        [Validation(Required=false)]
        public string Handler { get; set; }

        /// <summary>
        /// 初始化function运行的超时时间，单位为秒，最小1秒，默认3秒。初始化function超过这个时间后会被终止执行
        /// </summary>
        [NameInMap("initializationTimeout")]
        [Validation(Required=false)]
        public int? InitializationTimeout { get; set; }

        /// <summary>
        /// 初始化 function 执行的入口，具体格式和语言相关
        /// </summary>
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

        /// <summary>
        /// function上次修改时间
        /// </summary>
        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        [NameInMap("layers")]
        [Validation(Required=false)]
        public List<string> Layers { get; set; }

        /// <summary>
        /// function设置的内存大小，单位为MB
        /// </summary>
        [NameInMap("memorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        /// <summary>
        /// function运行的语言环境，目前支持nodejs6, nodejs8, python2.7, python3, java8
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public string Runtime { get; set; }

        /// <summary>
        /// 运行的超时时间，单位为秒
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
