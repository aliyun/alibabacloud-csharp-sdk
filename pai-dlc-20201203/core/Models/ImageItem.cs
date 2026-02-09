// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ImageItem : TeaModel {
        /// <summary>
        /// <para>The type of the image accelerator. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cpu</description></item>
        /// <item><description>gpu</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>gpu</para>
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        /// <summary>
        /// <para>The creator of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ken</para>
        /// </summary>
        [NameInMap("AuthorId")]
        [Validation(Required=false)]
        public string AuthorId { get; set; }

        /// <summary>
        /// <para>The computing framework that is encapsulated by the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TFJob</description></item>
        /// <item><description>PyTorchJob</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PyTorchJob</para>
        /// </summary>
        [NameInMap("Framework")]
        [Validation(Required=false)]
        public string Framework { get; set; }

        /// <summary>
        /// <para>The image type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Community</description></item>
        /// <item><description>PAI</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Community</para>
        /// </summary>
        [NameInMap("ImageProviderType")]
        [Validation(Required=false)]
        public string ImageProviderType { get; set; }

        /// <summary>
        /// <para>The tag of the docker image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tensorflow-training:2.3-cpu-py36-ubuntu18.04</para>
        /// </summary>
        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        /// <summary>
        /// <para>The image URL address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-beijing.aliyuncs.com/pai-dlc/tensorflow-training:2.3-cpu-py36-ubuntu18.04</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The VPC endpoint of the image URL. This address provides faster access speed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry-vpc.cn-beijing.aliyuncs.com/pai-dlc/tensorflow-training:2.3-cpu-py36-ubuntu18.04</para>
        /// </summary>
        [NameInMap("ImageUrlVpc")]
        [Validation(Required=false)]
        public string ImageUrlVpc { get; set; }

    }

}
