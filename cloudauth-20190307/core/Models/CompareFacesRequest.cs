// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CompareFacesRequest : TeaModel {
        /// <summary>
        /// <para>The type of image 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FacePic</b>: A face photo of the user.</description></item>
        /// <item><description><b>IDPic</b>: A headshot photo from the chip of the user\&quot;s second-generation ID card (typically read and decoded by a second-generation ID card reader device).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FacePic</para>
        /// </summary>
        [NameInMap("SourceImageType")]
        [Validation(Required=false)]
        public string SourceImageType { get; set; }

        /// <summary>
        /// <para>The URL of image 1. For more information, see the description of image URL upload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http%3A%2F%2Fjiangsu.china.com.cn%2Fuploadfile%2F2015%2F0114%2F1421221304095989.jpg</para>
        /// </summary>
        [NameInMap("SourceImageValue")]
        [Validation(Required=false)]
        public string SourceImageValue { get; set; }

        /// <summary>
        /// <para>The type of image 2. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FacePic</b>: A face photo of the user.</description></item>
        /// <item><description><b>IDPic</b>: A headshot photo from the chip of the user\&quot;s second-generation ID card (typically read and decoded by a second-generation ID card reader device).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FacePic</para>
        /// </summary>
        [NameInMap("TargetImageType")]
        [Validation(Required=false)]
        public string TargetImageType { get; set; }

        /// <summary>
        /// <para>The URL of image 2. For more information, see the description of image URL upload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http%3A%2F%2Fjiangsu.china.com.cn%2Fuploadfile%2F2015%2F0114%2F1421221304095989.jpg</para>
        /// </summary>
        [NameInMap("TargetImageValue")]
        [Validation(Required=false)]
        public string TargetImageValue { get; set; }

    }

}
