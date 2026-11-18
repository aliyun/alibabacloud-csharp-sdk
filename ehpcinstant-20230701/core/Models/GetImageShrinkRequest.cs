// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class GetImageShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of additional region IDs for which to query image information.</para>
        /// </summary>
        [NameInMap("AdditionalRegionIds")]
        [Validation(Required=false)]
        public string AdditionalRegionIdsShrink { get; set; }

        /// <summary>
        /// <para>The image source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Public: public images provided by Alibaba Cloud</description></item>
        /// <item><description>Custom: custom images added by you</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("ImageCategory")]
        [Validation(Required=false)]
        public string ImageCategory { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-2ze74g5mvy4pjg*****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The image type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VM: virtual machine image</description></item>
        /// <item><description>Container: container image</description></item>
        /// </list>
        /// <para>Default value: VM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VM</para>
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

    }

}
