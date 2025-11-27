// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class ListImagesRequest : TeaModel {
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
        /// <para>The array of image IDs.</para>
        /// </summary>
        [NameInMap("ImageIds")]
        [Validation(Required=false)]
        public List<string> ImageIds { get; set; }

        /// <summary>
        /// <para>The array of image names.</para>
        /// </summary>
        [NameInMap("ImageNames")]
        [Validation(Required=false)]
        public List<string> ImageNames { get; set; }

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

        /// <summary>
        /// <para>The query mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>List: queries the list of all corresponding image versions.</description></item>
        /// <item><description>Merge: merges images to query the latest version list.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Merge</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The number of the page to return.\
        /// Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of pieces per page.\
        /// Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
