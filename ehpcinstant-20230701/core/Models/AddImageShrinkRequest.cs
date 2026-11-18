// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class AddImageShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The container image configuration.</para>
        /// </summary>
        [NameInMap("ContainerImageSpec")]
        [Validation(Required=false)]
        public string ContainerImageSpecShrink { get; set; }

        /// <summary>
        /// <para>The image description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test image</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The image type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VM: virtual machine image</description></item>
        /// <item><description>Container: container image</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VM</para>
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// <para>The image version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V1.0</para>
        /// </summary>
        [NameInMap("ImageVersion")]
        [Validation(Required=false)]
        public string ImageVersion { get; set; }

        /// <summary>
        /// <para>The image name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-image</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The virtual machine image configuration.</para>
        /// </summary>
        [NameInMap("VMImageSpec")]
        [Validation(Required=false)]
        public string VMImageSpecShrink { get; set; }

    }

}
