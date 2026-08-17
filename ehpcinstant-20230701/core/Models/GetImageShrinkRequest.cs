// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class GetImageShrinkRequest : TeaModel {
        [NameInMap("AdditionalRegionIds")]
        [Validation(Required=false)]
        public string AdditionalRegionIdsShrink { get; set; }

        /// <summary>
        /// <para>Image source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Public: public images provided by Alibaba Cloud.</para>
        /// </description></item>
        /// <item><description><para>Custom: custom images that you added.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("ImageCategory")]
        [Validation(Required=false)]
        public string ImageCategory { get; set; }

        /// <summary>
        /// <para>Image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-2ze74g5mvy4pjg*****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>Image type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>VM: virtual machine image.</para>
        /// </description></item>
        /// <item><description><para>Container: container image.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: VM</para>
        /// 
        /// <b>Example:</b>
        /// <para>VM</para>
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

    }

}
