// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class ListImagesRequest : TeaModel {
        /// <summary>
        /// 资源类型
        /// </summary>
        [NameInMap("AcceleratorTypeEquals")]
        [Validation(Required=false)]
        public string AcceleratorTypeEquals { get; set; }

        /// <summary>
        /// 容器名称关键字
        /// </summary>
        [NameInMap("ImageNameContains")]
        [Validation(Required=false)]
        public string ImageNameContains { get; set; }

        /// <summary>
        /// 镜像类型
        /// </summary>
        [NameInMap("ImageTypeEquals")]
        [Validation(Required=false)]
        public string ImageTypeEquals { get; set; }

        /// <summary>
        /// 产品
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        /// <summary>
        /// 工作空间Id
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
