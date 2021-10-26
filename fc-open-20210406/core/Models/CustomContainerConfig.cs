// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CustomContainerConfig : TeaModel {
        /// <summary>
        /// 镜像加速类型，取值Default为开启加速，None为关闭加速，默认关闭
        /// </summary>
        [NameInMap("accelerationType")]
        [Validation(Required=false)]
        public string AccelerationType { get; set; }

        /// <summary>
        /// 容器启动参数
        /// </summary>
        [NameInMap("args")]
        [Validation(Required=false)]
        public string Args { get; set; }

        /// <summary>
        /// 容器启动命令，等同于 Docker ENTRYPOINT
        /// </summary>
        [NameInMap("command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// 容器镜像地址，实例值： registry-vpc.cn-hangzhou.aliyuncs.com/fc-demo/helloworld:v1beta1
        /// </summary>
        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

    }

}
