// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ImageItem : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>gpu</para>
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ken</para>
        /// </summary>
        [NameInMap("AuthorId")]
        [Validation(Required=false)]
        public string AuthorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PyTorchJob</para>
        /// </summary>
        [NameInMap("Framework")]
        [Validation(Required=false)]
        public string Framework { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Community</para>
        /// </summary>
        [NameInMap("ImageProviderType")]
        [Validation(Required=false)]
        public string ImageProviderType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tensorflow-training:2.3-cpu-py36-ubuntu18.04</para>
        /// </summary>
        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>registry.cn-beijing.aliyuncs.com/pai-dlc/tensorflow-training:2.3-cpu-py36-ubuntu18.04</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>registry-vpc.cn-beijing.aliyuncs.com/pai-dlc/tensorflow-training:2.3-cpu-py36-ubuntu18.04</para>
        /// </summary>
        [NameInMap("ImageUrlVpc")]
        [Validation(Required=false)]
        public string ImageUrlVpc { get; set; }

    }

}
