// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobSpec : TeaModel {
        /// <summary>
        /// Ecs实例规格
        /// </summary>
        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public string EcsSpec { get; set; }

        /// <summary>
        /// 额外的Pod配置
        /// </summary>
        [NameInMap("ExtraPodSpec")]
        [Validation(Required=false)]
        public ExtraPodSpec ExtraPodSpec { get; set; }

        /// <summary>
        /// 镜像
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// 实例数量
        /// </summary>
        [NameInMap("PodCount")]
        [Validation(Required=false)]
        public long? PodCount { get; set; }

        /// <summary>
        /// 资源配置
        /// </summary>
        [NameInMap("ResourceConfig")]
        [Validation(Required=false)]
        public ResourceConfig ResourceConfig { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// 是否使用竞价实例
        /// </summary>
        [NameInMap("UseSpotInstance")]
        [Validation(Required=false)]
        public bool? UseSpotInstance { get; set; }

    }

}
