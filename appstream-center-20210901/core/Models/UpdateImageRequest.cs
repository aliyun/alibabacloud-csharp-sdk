// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class UpdateImageRequest : TeaModel {
        /// <summary>
        /// <para>The complete list of application adaptation IDs for the selected image version. A maximum of 100 items are supported. <b>When a non-empty list is passed, it must include the adaptations that you still want to retain. Omitting this parameter or passing an empty list does not clear the existing associations.</b></para>
        /// </summary>
        [NameInMap("AdaptorIdList")]
        [Validation(Required=false)]
        public List<string> AdaptorIdList { get; set; }

        /// <summary>
        /// <para>The new description of the image usage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Update office software and basic configurations</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The operating system distribution information of the image. This must be consistent with the actual operating system distribution of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ubuntu 22.04 64-bit</para>
        /// </summary>
        [NameInMap("Distro")]
        [Validation(Required=false)]
        public string Distro { get; set; }

        /// <summary>
        /// <para>The ID of the image to be modified. You must provide at least one of ImageId and VersionId. If both are provided, they must belong to the same image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imgc-bp1example****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The new name of the image. Specify this parameter only when you need to update the name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OfficeImage_202611</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The language of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh-CN</b>: Simplified Chinese.</description></item>
        /// <item><description><b>zh-HK</b>: Traditional Chinese (Hong Kong).</description></item>
        /// <item><description><b>en-US</b>: English.</description></item>
        /// <item><description><b>ja-JP</b>: Japanese.</description></item>
        /// <item><description><b>CN</b>: A compatible value for Simplified Chinese.</description></item>
        /// <item><description><b>EN</b>: A compatible value for English.</description></item>
        /// <item><description><b>JP</b>: A compatible value for Japanese.</description></item>
        /// <item><description><b>CN-HK</b>: A compatible value for Traditional Chinese (Hong Kong).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The ID of the image version to be modified. If this parameter is omitted, the current effective version of the image specified by ImageId is used. You must provide at least one of VersionId and ImageId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iv-bp1example****</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        /// <summary>
        /// <para>The new display name of the image version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office environment-202611</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
