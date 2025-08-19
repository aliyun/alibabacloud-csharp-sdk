// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CompareFacesRequest : TeaModel {
        /// <summary>
        /// <para>Type of Image 1, with values:</para>
        /// <list type="bullet">
        /// <item><description><b>FacePic</b>: User\&quot;s face photo</description></item>
        /// <item><description><b>IDPic</b>: Headshot from the user\&quot;s second-generation ID card chip (typically obtained and decoded by a second-generation ID card reader)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FacePic</para>
        /// </summary>
        [NameInMap("SourceImageType")]
        [Validation(Required=false)]
        public string SourceImageType { get; set; }

        /// <summary>
        /// <para>Address of Image 1. Please refer to the instructions on uploading image addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http%3A%2F%2Fjiangsu.china.com.cn%2Fuploadfile%2F2015%2F0114%2F1421221304095989.jpg</para>
        /// </summary>
        [NameInMap("SourceImageValue")]
        [Validation(Required=false)]
        public string SourceImageValue { get; set; }

        /// <summary>
        /// <para>Type of Image 2, with values:</para>
        /// <list type="bullet">
        /// <item><description><b>FacePic</b>: User\&quot;s face photo</description></item>
        /// <item><description><b>IDPic</b>: Headshot from the user\&quot;s second-generation ID card chip (typically obtained and decoded by a second-generation ID card reader)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FacePic</para>
        /// </summary>
        [NameInMap("TargetImageType")]
        [Validation(Required=false)]
        public string TargetImageType { get; set; }

        /// <summary>
        /// <para>Address of Image 2. Please refer to the instructions on uploading image addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http%3A%2F%2Fjiangsu.china.com.cn%2Fuploadfile%2F2015%2F0114%2F1421221304095989.jpg</para>
        /// </summary>
        [NameInMap("TargetImageValue")]
        [Validation(Required=false)]
        public string TargetImageValue { get; set; }

    }

}
