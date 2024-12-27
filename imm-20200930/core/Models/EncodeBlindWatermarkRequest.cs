// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class EncodeBlindWatermarkRequest : TeaModel {
        /// <summary>
        /// <para>The text content of watermarks. It can be up to 256 characters in length.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>This parameter takes effect only if the input image format is JPG.</para>
        /// <para>The storage quality of the output image that carries the watermarks. Default value: 90. Valid values: 70 to 100. The higher the quality, the larger the image size and the higher the watermark resolution quality.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("ImageQuality")]
        [Validation(Required=false)]
        public int? ImageQuality { get; set; }

        /// <summary>
        /// <para>The name of the project. For more information, see <a href="https://help.aliyun.com/document_detail/478153.html">CreateProject</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The Object Storage Service (OSS) URI of the image.</para>
        /// <para>Specify the value in the oss://${Bucket}/${Object} format. <c>${Bucket}</c> specifies the name of the OSS bucket that resides in the same region with the current project. <c>${Object}</c> specifies the path of the object with the extension included.</para>
        /// <para>Supported image formats: JPG, PNG, BMP, TIFF, and WebP.</para>
        /// <para>Image size limit: 10,000 px maximum and 80 px x 80 px minimum.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-object.jpg</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// <para>The watermark strength level. The higher the strength, the more resistant the watermarked image is to attacks, but the more the image is distorted. Default value: low. Valid values: [low, medium, high].</para>
        /// 
        /// <b>Example:</b>
        /// <para>low</para>
        /// </summary>
        [NameInMap("StrengthLevel")]
        [Validation(Required=false)]
        public string StrengthLevel { get; set; }

        /// <summary>
        /// <para>The URI of the output image in OSS.</para>
        /// <para>Specify the URI in the oss://${Bucket}/${Object} format, where <c>${Bucket}</c> is the name of the bucket in the same region as the current project and <c>${Object}</c> is the path of the object with the extension included.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The format of the output image is the same as that of the input image.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/target-object.jpg</para>
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

    }

}
