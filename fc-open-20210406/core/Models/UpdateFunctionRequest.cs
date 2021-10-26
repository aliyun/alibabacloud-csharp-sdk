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

        /// <summary>
        /// 自定义、自定义容器运行时 HTTP Server 的监听端口
        /// </summary>
        [NameInMap("caPort")]
        [Validation(Required=false)]
        public int? CaPort { get; set; }

        [NameInMap("code")]
        [Validation(Required=false)]
        public Code Code { get; set; }

        [NameInMap("customContainerConfig")]
        [Validation(Required=false)]
        public CustomContainerConfig CustomContainerConfig { get; set; }

        /// <summary>
        /// 函数描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 为函数设置的环境变量，可以在函数中获取环境变量的值
        /// </summary>
        [NameInMap("environmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// function执行的入口，具体格式和语言相关
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

        [NameInMap("instanceLifecycleConfig")]
        [Validation(Required=false)]
        public InstanceLifecycleConfig InstanceLifecycleConfig { get; set; }

        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("layers")]
        [Validation(Required=false)]
        public List<string> Layers { get; set; }

        /// <summary>
        /// function的内存规格，单位为MB，为64MB的倍数
        /// </summary>
        [NameInMap("memorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        /// <summary>
        /// runtime
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public string Runtime { get; set; }

        /// <summary>
        /// function运行的超时时间，单位为秒，最小1秒，默认3秒。function超过这个时间后会被终止执行
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
