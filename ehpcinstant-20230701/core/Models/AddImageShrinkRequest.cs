// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class AddImageShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of the container image.</para>
        /// </summary>
        [NameInMap("ContainerImageSpec")]
        [Validation(Required=false)]
        public string ContainerImageSpecShrink { get; set; }

        /// <summary>
        /// <para>The description of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test image</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The type of the images. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VM: virtual machine image.</description></item>
        /// <item><description>Container: the container image.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VM</para>
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// <para>The version of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V1.0</para>
        /// </summary>
        [NameInMap("ImageVersion")]
        [Validation(Required=false)]
        public string ImageVersion { get; set; }

        /// <summary>
        /// <para>The name of the custom image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-image</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The image configuration of the virtual machine.</para>
        /// </summary>
        [NameInMap("VMImageSpec")]
        [Validation(Required=false)]
        public string VMImageSpecShrink { get; set; }

    }

}
