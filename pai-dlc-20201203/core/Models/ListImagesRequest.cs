// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ListImagesRequest : TeaModel {
        /// <summary>
        /// 加速器类型
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        /// <summary>
        /// 镜像包含的框架类型
        /// </summary>
        [NameInMap("Framework")]
        [Validation(Required=false)]
        public string Framework { get; set; }

        /// <summary>
        /// 镜像类型
        /// </summary>
        [NameInMap("ImageProviderType")]
        [Validation(Required=false)]
        public string ImageProviderType { get; set; }

        /// <summary>
        /// 排序顺序
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// 按返回字段排序
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// 工作空间ID
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
