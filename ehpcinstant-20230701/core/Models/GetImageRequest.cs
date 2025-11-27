// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class GetImageRequest : TeaModel {
        [NameInMap("AdditionalRegionIds")]
        [Validation(Required=false)]
        public List<string> AdditionalRegionIds { get; set; }

        /// <summary>
        /// <para>The source of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Public: public images provided by Alibaba Cloud.</description></item>
        /// <item><description>Custom: the custom image that you added.</description></item>
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
        /// <para>The type of the images. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VM: virtual machine image.</description></item>
        /// <item><description>Container: the container image.</description></item>
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
