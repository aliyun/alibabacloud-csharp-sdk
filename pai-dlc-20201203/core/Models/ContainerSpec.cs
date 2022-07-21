// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ContainerSpec : TeaModel {
        /// <summary>
        /// 命令参数
        /// </summary>
        [NameInMap("Args")]
        [Validation(Required=false)]
        public List<string> Args { get; set; }

        /// <summary>
        /// 用户命令
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public List<string> Command { get; set; }

        /// <summary>
        /// 环境变量
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public List<EnvVar> Env { get; set; }

        /// <summary>
        /// 容器镜像地址
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// 容器名称
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 容器资源
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public ResourceRequirements Resources { get; set; }

        /// <summary>
        /// 容器内工作目录
        /// </summary>
        [NameInMap("WorkingDir")]
        [Validation(Required=false)]
        public string WorkingDir { get; set; }

    }

}
