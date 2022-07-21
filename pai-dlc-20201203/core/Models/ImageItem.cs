// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ImageItem : TeaModel {
        /// <summary>
        /// 加速器类型
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        /// <summary>
        /// 镜像作者
        /// </summary>
        [NameInMap("AuthorId")]
        [Validation(Required=false)]
        public string AuthorId { get; set; }

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
        /// 镜像Tag
        /// </summary>
        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        /// <summary>
        /// 镜像地址
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 镜像vpc地址
        /// </summary>
        [NameInMap("ImageUrlVpc")]
        [Validation(Required=false)]
        public string ImageUrlVpc { get; set; }

    }

}
