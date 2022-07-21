// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ExtraPodSpec : TeaModel {
        /// <summary>
        /// 初始化容器
        /// </summary>
        [NameInMap("InitContainers")]
        [Validation(Required=false)]
        public List<ContainerSpec> InitContainers { get; set; }

        /// <summary>
        /// Pod注解
        /// </summary>
        [NameInMap("PodAnnotations")]
        [Validation(Required=false)]
        public Dictionary<string, string> PodAnnotations { get; set; }

        /// <summary>
        /// Pod标签
        /// </summary>
        [NameInMap("PodLabels")]
        [Validation(Required=false)]
        public Dictionary<string, string> PodLabels { get; set; }

        /// <summary>
        /// 容器间共享的本地目录
        /// </summary>
        [NameInMap("SharedVolumeMountPaths")]
        [Validation(Required=false)]
        public List<string> SharedVolumeMountPaths { get; set; }

        /// <summary>
        /// 伴随容器
        /// </summary>
        [NameInMap("SideCarContainers")]
        [Validation(Required=false)]
        public List<ContainerSpec> SideCarContainers { get; set; }

    }

}
